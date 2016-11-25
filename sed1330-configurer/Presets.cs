using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sed1330_configurer
{
    public class SEDPreset
    {
        /// <summary>
        /// Preset name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// CMDs Params RAW string
        /// </summary>
        public string RAW_PARAMS { get; set; }
        /// <summary>
        /// Display resolution width
        /// </summary>
        public int DispX { get; set; }
        /// <summary>
        /// Display resolution height
        /// </summary>
        public int DispY { get; set; }
        /// <summary>
        /// SED fosc/CLKI frequency in kHz
        /// </summary>
        public int FOSC { get; set; }
        /// <summary>
        /// Refresh frame rate in Hz
        /// </summary>
        public int FFR { get; set; }
        /// <summary>
        /// Is diplay dual-panel
        /// </summary>
        public bool DualPanel { get; set; }

        /// <summary>
        /// SYSTEM SET command - Parameter 1
        /// </summary>
        public byte C40P1 { get; set; }
        /// <summary>
        /// SYSTEM SET command - Parameter 2
        /// </summary>
        public byte C40P2 { get; set; }
        /// <summary>
        /// SYSTEM SET command - Parameter 3
        /// </summary>
        public byte C40P3 { get; set; }
        /// <summary>
        /// SYSTEM SET command - Parameter 4
        /// </summary>
        public byte C40P4 { get; set; }
        /// <summary>
        /// SYSTEM SET command - Parameter 5
        /// </summary>
        public byte C40P5 { get; set; }
        /// <summary>
        /// SYSTEM SET command - Parameter 6
        /// </summary>
        public byte C40P6 { get; set; }
        /// <summary>
        /// SYSTEM SET command - Parameter 7
        /// </summary>
        public byte C40P7 { get; set; }
        /// <summary>
        /// SYSTEM SET command - Parameter 8
        /// </summary>
        public byte C40P8 { get; set; }

        /// <summary>
        /// SCROLL command - Parameters P3 and P6
        /// </summary>
        public byte C44P3_P6 { get; set; }

        /// <summary>
        /// HDOT SCR Command - Parameter 1
        /// </summary>
        public byte C5A_P1 { get; set; }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public SEDPreset()
        {
            C40P1 = C40P2 = C40P3 = C40P4 = C40P5 = C40P6 = C40P7 = C40P8 = C44P3_P6 = C5A_P1 = 0;
            RAW_PARAMS = "00000000000000000000";
            Name = "-";
            DispX = DispY = 0;
            FOSC = 4000; FFR = 50;
            DualPanel = false;
        }

        public SEDPreset(string line)
        {
            LoadFromPresetLine(line);
        }

        /// <summary>
        /// Load information from Preset file line.
        /// Will throw exception on error in any block
        /// </summary>
        /// <param name="line"></param>
        public void LoadFromPresetLine(string line)
        {
            if (line.Length < 1) throw new Exception("Line is empty.");
            string[] ln = line.Split(new char[] { ';' }, 3);

            if (ln.Length != 3) throw new Exception("Line have inavalid format.");

            RAW_PARAMS = ln[0];
            UpdateCMDParamsFromRawProperty();
            Name = ln[2].Trim();
            LoadDispInfoFromPresetBlock(ln[1]);
        }

        /// <summary>
        /// Load display information from DispInfo block in preset line.
        /// </summary>
        /// <param name="bl"></param>
        public void LoadDispInfoFromPresetBlock(string bl)
        {
            if (bl.Length < 1) throw new Exception("Display info block is empty");
            string[] sb = bl.Split(new char[] { ',' }, 5);

            if (sb.Length != 5) throw new Exception("Display info block have invalid format.");

            int step=0;
            try
            {
                DispX = int.Parse(sb[0]);
                step++;
                DispY = int.Parse(sb[1]);
                step++;
                DualPanel = (int.Parse(sb[2]) == 0 ? false : true);
                step++;
                FOSC = int.Parse(sb[3]);
                step++;
                FFR = int.Parse(sb[4]);
            } catch
            {
                throw new Exception("Display info block have invalid data. Step(" + step.ToString() + ")");
            }

        }

        /// <summary>
        /// Return DispInfo block for preset file from display information 
        /// </summary>
        /// <returns></returns>
        public string GetDispInfoBlock()
        {
            string r = "";

            r += DispX.ToString() + "," + DispY.ToString() + ",";
            r += (DualPanel ? "1" : "0") + ",";
            r += FOSC.ToString() + "," + FFR.ToString();

            return r;
        }

        /// <summary>
        /// Update cmd's parameters from RAW_PARAMS property content
        /// </summary>
        public void UpdateCMDParamsFromRawProperty()
        {
            UpdateCMDParamsFromRAW(RAW_PARAMS);
        }

        /// <summary>
        /// Update cmd's params from raw string from raw block from preset file line
        /// </summary>
        /// <param name="raw"></param>
        public void UpdateCMDParamsFromRAW(string raw)
        {
            if (RAW_PARAMS.Length % 2 == 1) throw new Exception("RAW does not have valid length (odd length)");
            if (RAW_PARAMS.Length != 20) throw new Exception("RAW does not have valid length.");

            string r = raw;
            string b = "00";
            // cmd40
            b = r.Substring(0, 2); C40P1 = byte.Parse(b, System.Globalization.NumberStyles.AllowHexSpecifier);
            b = r.Substring(2, 2); C40P2 = byte.Parse(b, System.Globalization.NumberStyles.AllowHexSpecifier);
            b = r.Substring(4, 2); C40P3 = byte.Parse(b, System.Globalization.NumberStyles.AllowHexSpecifier);
            b = r.Substring(6, 2); C40P4 = byte.Parse(b, System.Globalization.NumberStyles.AllowHexSpecifier);
            b = r.Substring(8, 2); C40P5 = byte.Parse(b, System.Globalization.NumberStyles.AllowHexSpecifier);
            b = r.Substring(10, 2); C40P6 = byte.Parse(b, System.Globalization.NumberStyles.AllowHexSpecifier);
            b = r.Substring(12, 2); C40P7 = byte.Parse(b, System.Globalization.NumberStyles.AllowHexSpecifier);
            b = r.Substring(14, 2); C40P8 = byte.Parse(b, System.Globalization.NumberStyles.AllowHexSpecifier);
            // cmd44
            b = r.Substring(16, 2); C44P3_P6 = byte.Parse(b, System.Globalization.NumberStyles.AllowHexSpecifier);
            // cmd5A
            b = r.Substring(18, 2); C5A_P1 = byte.Parse(b, System.Globalization.NumberStyles.AllowHexSpecifier);

        }

        /// <summary>
        /// Return raw string of cmd's params for preset file line
        /// </summary>
        /// <returns></returns>
        public string GetRAWFromParams()
        {
            string r = "";

            r += C40P1.ToString("X2");
            r += C40P2.ToString("X2");
            r += C40P3.ToString("X2");
            r += C40P4.ToString("X2");
            r += C40P5.ToString("X2");
            r += C40P6.ToString("X2");
            r += C40P7.ToString("X2");
            r += C40P8.ToString("X2");
            r += C44P3_P6.ToString("X2");
            r += C5A_P1.ToString("X2");

            return r;

        }

        /// <summary>
        /// Update RAW property from cmd's params
        /// </summary>
        public void UpdateRAWFromParams()
        {
            RAW_PARAMS = GetRAWFromParams();
        }

        /// <summary>
        /// Return whole preset file line
        /// </summary>
        /// <returns></returns>
        public string GetPresetLine()
        {
            string ln = "";

            ln += GetRAWFromParams() + ";" + GetDispInfoBlock() + ";" + Name;

            return ln;
        }

    }

    public class SEDPresets : CollectionBase
    {
        public SEDPreset this[int index]
        {
            get
            {
                if (index < 0 || index >= Count) throw new IndexOutOfRangeException("Index out of range: SEDPresets[index=" + index.ToString() + "].");
                return (SEDPreset)List[index];
            }

            set
            {
                if (index < 0 || index >= Count) throw new IndexOutOfRangeException("Index out of range: SEDPresets[index=" + index.ToString() + "].");
                List[index] = value;
            }
        }

        public void AddPresetLine(string presetLine)
        {
            try
            {
                SEDPreset p = new SEDPreset(presetLine);
                List.Add(p);
            } catch(Exception ee)
            {
                throw new Exception("SEDPresets.AddPresetLine failed with error: " + ee.ToString());
            }
        }

        public void Add(SEDPreset preset)
        {
            try
            {
                List.Add(preset);
            }
            catch (Exception ee)
            {
                throw new Exception("SEDPresets.Add failed with error: " + ee.ToString());
            }
        }

        public void LoadPresetsFile(string path)
        {
            
            string line;
            if (!File.Exists(path)) throw new FileNotFoundException("No preset file at path.", path);
            try
            {
                StreamReader file = new StreamReader(path);
                Clear();
                while ((line = file.ReadLine()) != null)
                {
                    AddPresetLine(line);

                }
            }
            catch (Exception ee)
            {
                throw new Exception("Read file `"+path+"` failed:" + ee.ToString());
            }

        }
        
        public void SavePresetsFile(string path)
        {
            try
            {
                StreamWriter file = new StreamWriter(path, false);
                foreach (SEDPreset p in List)
                {
                    file.WriteLine(p.GetPresetLine());
                }
                file.Flush();
                file.Close();
            } catch (Exception ee)
            {
                throw new Exception("Saving preset file `" + path + "` failed: " + ee.ToString());    
            }
        }

        /// <summary>
        /// Return index by preset name or -1 if not exists
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int GetPresetByName(string name)
        {
            
            foreach(SEDPreset p in List)
            {
                if (p.Name == name)
                {
                    return List.IndexOf(p);
                }
            }


            return -1;
        }

    }
}
