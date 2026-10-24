using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Edoria_Raine_LabStream2
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
            btnCreate.Click -= btnCreate_Click;
            btnCreate.Click += btnCreate_Click;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string getInput = txtInput.Text;
            if (string.IsNullOrWhiteSpace(getInput))
            {
                MessageBox.Show("Enter text before creating the file.", "Missing input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.Focus();
                return;
            }

            using (FrmFileName fileNameForm = new FrmFileName())
            {
                if (fileNameForm.ShowDialog(this) != DialogResult.OK)
                    return;
            }

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fullPath = Path.Combine(docPath, FrmFileName.SetFileName);

            try
            {
                using (StreamWriter outputFile = new StreamWriter(fullPath, false, Encoding.UTF8))
                {
                    outputFile.WriteLine(getInput);
                    Console.WriteLine(getInput);
                }

                MessageBox.Show("Text file created successfully.\n\n" + fullPath,
                    "File created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The file could not be created.\n\n" + ex.Message,
                    "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
