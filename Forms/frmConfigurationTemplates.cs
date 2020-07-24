using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLC.Forms
{
    public partial class frmConfigurationTemplates : Form
    {
        public frmConfigurationTemplates()
        {
            InitializeComponent();
        }

        private void frmConfigurationManager_Load(object sender, EventArgs e)
        {
            foreach(var i in Directory.GetFiles(Global.ConfigurationTemplates))
            {
                var file = new FileInfo(i);
                lbConfigurations.Items.Add(file.Name);
            }
        }


        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("This will overwrite your current configuration, do you wish to proceed?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(result == DialogResult.Yes)
                {
                    if (File.Exists(Global.ConfigurationTemplates + @"\" + lbConfigurations.SelectedItem))
                    {
                        if (File.Exists(Global.ConfigurationPath))
                        {
                            File.Delete(Global.ConfigurationPath);
                        }

                        File.Copy(Global.ConfigurationTemplates + @"\" + lbConfigurations.SelectedItem, Global.ConfigurationPath);

                        MessageBox.Show("Configuration loaded, the application will now restart.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uncaught Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
