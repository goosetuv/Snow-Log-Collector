using SnowLogCollector.Classes;
using System;
using System.IO;
using System.Windows.Forms;

namespace SnowLogCollector
{
    public partial class frmDirectoryCustomize : Form
    {

        public string FormName { get; set; }
        public string DirectoryPath { get; set; }
        public string ApplicationDataRoot { get; set; }
        public string CollectedLogsRoot { get; set; }

        public frmDirectoryCustomize()
        {
            InitializeComponent();
        }

        private void frmDirectoryCustomize_Load(object sender, EventArgs e)
        {
            Text = FormName;

            GetDirectories(DirectoryPath);
        }

        private void GetDirectories(string directory)
        {
            // get a list of the available directories within the root directory
            foreach (var i in Directory.GetDirectories(directory))
            {
                // get the information about the directory
                var dir = new DirectoryInfo(i);
                
                // add it to the listbox to allow checking
                clbDirectoryList.Items.Add(dir.Name);
            }
        }

        private void btnGrabData_Click(object sender, EventArgs e)
        {
            // Create a new instance of the FileCopier
            FileCopier fc = new FileCopier();

            // Loop through each checked item in the list
            foreach (string i in clbDirectoryList.CheckedItems)
            {
                // Copy the files from the original directory, to the new one, and append the name to
                // have the directory name at the start of it
                // Because snow have logs called YYYY-MM-DD for some reason

                fc.Copy(Path.Combine(DirectoryPath, i), CollectedLogsRoot, i);
            }

            MessageBox.Show("Data grab finished", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
