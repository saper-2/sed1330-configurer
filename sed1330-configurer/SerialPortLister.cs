using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Management;
using System.IO.Ports;

public class SerialPortListerItem
{
    private string pName = "";
    private string pDesc = "";
    private bool isModem = false;
    private ManagementScope manScope = null;
    private bool fastScanMode = false;

    public string PortName { get { return pName; } }
    public string Description { get { return pDesc; } }
    public bool IsModem { get { return isModem; } }
    /// <summary>
    /// If true, then getting name and description is faster but IsModem property is not updated.
    /// </summary>
    public bool FastMode { set { fastScanMode = FastMode; } get { return fastScanMode; } }

    /// <summary>
    /// Update port information (description, IsModem - when FastMode is false).
    /// </summary>
    public void UpdatePortInfo()
    {
        int noRes = 0;
        
        // two scan modes
        if (fastScanMode)
        {
            try
            {
                ManagementObjectSearcher searcher;

                if (manScope != null)
                {
                    ObjectQuery manQuery = new ObjectQuery("root\\CIMV2", "SELECT * FROM Win32_PnPEntity WHERE ConfigManagerErrorCode = 0");
                    searcher = new ManagementObjectSearcher(manScope, manQuery);
                }
                else
                {
                    searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity WHERE ConfigManagerErrorCode = 0");
                }

                if (searcher.Get().Count > 0)
                {
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        if (queryObj["Caption"] != null)
                        {
                            string cap = (string)queryObj["Caption"];
                            if (cap.Contains("(COM"))
                            { // yep it's a com port
                                string name = cap.Substring(cap.LastIndexOf("(COM")).Replace("(", string.Empty).Replace(")", string.Empty);
                                if (name.ToUpper() == pName.ToUpper())
                                {
                                    pDesc = cap.Substring(0, cap.LastIndexOf("(") - 1);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }
            // FastMode = false, slower scan but can tell witch port is a Modem
        else
        {

            // check com port as normal serial port
            try
            {
                ManagementObjectSearcher searcher;

                if (manScope != null)
                {
                    ObjectQuery manQuery = new ObjectQuery("root\\CIMV2", "SELECT * FROM Win32_SerialPort WHERE DeviceID=\"" + pName.ToUpper() + "\"");
                    searcher = new ManagementObjectSearcher(manScope, manQuery);
                }
                else
                {
                    searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_SerialPort WHERE DeviceID=\"" + pName.ToUpper() + "\"");
                }

                //noRes = 0;
                if (searcher.Get().Count > 0)
                {
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        if (((string)queryObj["DeviceID"]).ToUpper() == pName.ToUpper())
                        {
                            //pDesc = (string)queryObj["Caption"];
                            pDesc = (string)queryObj["Description"];
                            isModem = false;
                        }
                    }
                }
                else
                {
                    noRes = 1;
                }

            }
            catch //(ManagementException e)
            {
            }
            // re-check port as modem port
            try
            {
                ManagementObjectSearcher searcher;

                if (manScope != null)
                {
                    ObjectQuery manQuery = new ObjectQuery("root\\CIMV2", "SELECT * FROM Win32_POTSModem WHERE AttachedTo=\"" + pName.ToUpper() + "\"");
                    searcher = new ManagementObjectSearcher(manScope, manQuery);
                }
                else
                {
                    searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_POTSModem WHERE AttachedTo=\"" + pName.ToUpper() + "\"");
                }


                //noRes = 0;
                if (searcher.Get().Count > 0)
                {
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        if (((string)queryObj["AttachedTo"]).ToUpper() == pName.ToUpper())
                        {
                            pDesc = (string)queryObj["Caption"];
                            isModem = true;
                        }
                    }
                }
                else
                {
                    noRes = 1;
                }

                // search it in Win32_PNPEntity class
            }
            catch
            {
            }

            try
            {
                if (noRes == 1)
                {
                    ManagementObjectSearcher searcher;

                    if (manScope != null)
                    {
                        ObjectQuery manQuery = new ObjectQuery("root\\CIMV2", "SELECT * FROM Win32_PnPEntity WHERE ConfigManagerErrorCode = 0");
                        searcher = new ManagementObjectSearcher(manScope, manQuery);
                    }
                    else
                    {
                        searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity WHERE ConfigManagerErrorCode = 0");
                    }

                    if (searcher.Get().Count > 0)
                    {
                        foreach (ManagementObject queryObj in searcher.Get())
                        {
                            if (queryObj["Caption"] != null)
                            {
                                string cap = (string)queryObj["Caption"];
                                if (cap.Contains("(COM"))
                                { // yep it's a com port
                                    string name = cap.Substring(cap.LastIndexOf("(COM")).Replace("(", string.Empty).Replace(")", string.Empty);
                                    if (name.ToUpper() == pName.ToUpper())
                                    {
                                        pDesc = cap.Substring(0, cap.LastIndexOf("(") - 1);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }
    }

    /// <summary>
    /// init class and fill up data
    /// </summary>
    /// <param name="portName">Serial port name</param>
    /// <param name="fastMode">Decide if data should be obtained faster or slower</param>
    public SerialPortListerItem(string portName, bool fastMode = false)
    {
        pName = portName;
        fastScanMode = fastMode;
        UpdatePortInfo();
        manScope = null;

    }

    /// <summary>
    /// init class and fill up data
    /// </summary>
    /// <param name="portName">Serial port name</param>
    /// <param name="scope"></param>
    /// <param name="fastMode">Decide if data should be obtained faster or slower</param>
    public SerialPortListerItem(string portName, ManagementScope scope, bool fastMode = false)
    {
        pName = portName;
        fastScanMode = fastMode;
        UpdatePortInfo();
        manScope = scope;
    }

}

public class SerialPortLister
{
    // Com port list
    private List<string> serPortList = new List<string>();
    private List<SerialPortListerItem> spList = new List<SerialPortListerItem>();
    private bool fastScanMode = false;
    private ManagementScope connectionScope;


    public int Count { get { return spList.Count; } }
    public SerialPortListerItem this[int index] { get { return spList[index]; } }
    public SerialPortListerItem this[string portName] { 
        get { 
            //return spList[index]; 
            int idx = -1;
            for (int i = 0; i < spList.Count; i++)
            {
                if (portName.ToUpper() == spList[i].PortName.ToUpper())
                {
                    idx = i;
                }
            }
            if (idx > -1) return spList[idx];
            
            return null;
        } 
    }

    private void FillPortList()
    {
        string[] pl = SerialPort.GetPortNames();
        if (pl.Length < 1) return;

        serPortList.Clear();
        foreach (string s in pl)
        {
            serPortList.Add(s);
        }
    }

    /// <summary>
    /// Build final port list for class
    /// </summary>
    private void BuildPortList()
    {
        if (serPortList.Count < 1) return;
        spList.Clear();
        foreach (string s in serPortList)
        {
            SerialPortListerItem i = new SerialPortListerItem(s, connectionScope, fastScanMode);
            spList.Add(i);
        }
    }

    /// <summary>
    /// Constructor
    /// </summary>
    public SerialPortLister(bool FastScanMode=false)
    {
        connectionScope = new ManagementScope(@"\\" + Environment.MachineName);
        fastScanMode = FastScanMode;
        FillPortList();
        BuildPortList();
    }

    /// <summary>
    /// Returns array of port names in format "[PortName] - [Description]"
    /// </summary>
    /// <returns>Array of port names with description</returns>
    public string[] GetSerialPorts()
    {
        string[] s = new string[spList.Count];

        for (int i = 0; i < spList.Count; i++)
        {
            string ss = spList[i].PortName.ToUpper() + " - " + spList[i].Description;
            s[i] = ss;
        }
        return s;
    }

    /// <summary>
    /// Get serial port description (port device name) by port name
    /// </summary>
    /// <param name="portName">Port name, eg.: COM2, com3, etc...</param>
    /// <returns>Port device name</returns>
    public string GetSerialPortDesc(string portName)
    {
        SerialPortListerItem sp = this[portName];
        if (sp != null) return sp.Description;

        return "";
    }

    /// <summary>
    /// Returns serial port name from string formatted in format: "[portName] - [description]"
    /// </summary>
    /// <param name="SerialPortNameWithDescription">Port name with description separated by text " - "</param>
    /// <returns>port name (upper case)</returns>
    public string DecodeSerialPortName(string SerialPortNameWithDescription)
    {
        string s = SerialPortNameWithDescription; // this parameter is too long :)

        if (s.IndexOf(' ') > 3)
        {
            s = s.Substring(0, s.IndexOf(' '));
        }

        return s.Trim().ToUpper();

    }
    
}
