using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using SnowLogCollector.Classes;

namespace SnowLogCollector
{
    public partial class frmMain : Form
    {

        private string conString = "Server=snow.int.laim.scot;User Id=sa;Password=cum";
        private string rootDirectory, dataDirectory, exportDirectory, resourceDirectory;

        public frmMain()
        {
            InitializeComponent();
            CreateDirectories();
        }

        #region Snow License Manager
        private void btnSLMDataUpdateJobCustomize_Click(object sender, EventArgs e)
        {
            try
            {

                if (File.Exists(Path.Combine(resourceDirectory, "DataUpdateJob.xml")))
                {
                    Process.Start(Path.Combine(resourceDirectory, "DataUpdateJob.xml"));
                }
                else
                {
                    MessageBox.Show("Please use the default grab before trying to customize.", "Update Job Customize", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Job Customize", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSLMLogsWebGrab_Click(object sender, EventArgs e)
        {
            foreach (var i in Directory.GetDirectories(@"C:\"))
            {
                MessageBox.Show(i);
            }
        }

        private void btnSLMLogsWebCustomize_Click(object sender, EventArgs e)
        {
            frmDirectoryCustomize fdc = new frmDirectoryCustomize
            {
                FormName = "License Manager Web Logs",
                DirectoryPath = @"C:\Users\"
            };
            fdc.ShowDialog();
        }

        private void btnSLMDataUpdateJobExport_Click(object sender, EventArgs e)
        {

            string resourceFile = Path.Combine(resourceDirectory, "DataUpdateJob.xml");

            // Write sql scripts to file so they can be modified later by end user.
            // Create this when using the feature rather at on-load, in case the
            // end user never actually uses this option, no point having wasteful files
            if (!File.Exists(resourceFile))
            {
                File.WriteAllText(resourceFile, Properties.Resources.DataUpdateJob);
            }

            // Load up the file that contains our SQL Scripts for
            // running against the database
            XDocument xdoc = XDocument.Load(resourceFile);

            // Initiate the Excel Exporter and Database Manager
            ExcelExporter ee = new ExcelExporter();
            DatabaseManager dbm = new DatabaseManager();

            // Loop through each node, we do this instead of hardcoding them
            // So that an end user can add custom scripts at a later date
            // If they want to.  This also means that if something changes
            // and I'm too busy or lazy to update the tool, end user can
            // update the script themselves - nice! 
            foreach (XElement element in xdoc.Descendants())
            {
                if (element.Name.ToString() != "Resource") // Ignore the root node
                {
                    // Make sure no one has added a DELETE, TRUNCATE or UPDATE query ... 
                    if (!element.Value.ToString().Contains("DELETE") || !element.Value.ToString().Contains("TRUNCATE") || !element.Value.ToString().Contains("UPDATE"))
                    {
                        ee.Save(
                            DateTime.Now.ToString("ddMMyyyy"),                      // Filename
                            exportDirectory,                                       // Export Path
                            "DataUpdateJob",                                        // Data Type
                            dbm.ExecuteQuery(conString, element.Value.ToString()),  // Database Execution
                            OfficeOpenXml.Table.TableStyles.None,                   // Table Style
                            element.Name.ToString()                                 // Name of Sql Script
                        );

                    }

                }
            }

        }

        #endregion

        private void CreateDirectories()
        {

            // Define our paths, probably not the best way
            // of doing this but, i don't have code reviewers lol
            rootDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Goosetuv\Snow Log Collector\";
            dataDirectory = rootDirectory + @"Data\";
            exportDirectory = dataDirectory + @"Exports\";
            resourceDirectory = dataDirectory + @"Resources\";

            // Create our root directory first in
            // AppData (%AppData%\Goosetuv\Snow Log Collector\)
            // Check if it doesn't exist first
            if (!Directory.Exists(rootDirectory))
            {
                // Doesn't exist, create it
                Directory.CreateDirectory(rootDirectory);
            }

            // Make sure the root directory exists
            // then create the child directories
            if (Directory.Exists(rootDirectory))
            {
                Directory.CreateDirectory(dataDirectory);
                Directory.CreateDirectory(exportDirectory);
                Directory.CreateDirectory(resourceDirectory);
            }
        }
    }
}
