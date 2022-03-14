using System.IO;
using System.Windows.Forms;

namespace SnowLogCollector
{
    public partial class frmDirectoryCustomize : Form
    {

        public string FormName { get; set; }
        public string DirectoryPath { get; set; }

        public frmDirectoryCustomize()
        {
            InitializeComponent();
        }

        private void frmDirectoryCustomize_Load(object sender, System.EventArgs e)
        {
            Text = FormName;

            GetDirectories(DirectoryPath);
        }

        private void GetDirectories(string directory)
        {
            foreach (var i in Directory.GetDirectories(directory))
            {
                var dir = new DirectoryInfo(i);
                clbDirectoryList.Items.Add(dir.Name);
            }
        }

        private void btnGrabData_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(DirectoryPath + clbDirectoryList.SelectedItem.ToString());
        }
    }
}
