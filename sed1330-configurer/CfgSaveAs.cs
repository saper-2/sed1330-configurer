using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sed1330_configurer
{
    public partial class FormCfgSaveAs : Form
    {
        public FormCfgSaveAs()
        {
            InitializeComponent();
        }

        public FormCfgSaveAs(string[] items, int selected = -1)
        {
            InitializeComponent();

            if (items != null)
            {
                cbNames.Items.Clear();
                foreach(string s in items)
                {
                    cbNames.Items.Add(s);
                }
            }
            if ((selected > -1) && (cbNames.Items.Count < selected))
            {
                cbNames.SelectedIndex = selected;
            }
        }

        public string SelectedName {  get { return cbNames.Text.Trim(); } }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (cbNames.Text.Trim().Length > 0)
            {
                DialogResult = DialogResult.OK;
            } else
            {
                MessageBox.Show("Name can not be empty.", "Boo boo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
