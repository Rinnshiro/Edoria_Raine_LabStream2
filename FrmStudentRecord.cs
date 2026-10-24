using System;
using System.IO;
using System.Windows.Forms;

namespace Edoria_Raine_LabStream
{
    public partial class FrmStudentRecord : Form
    {
        private string selectedPath = string.Empty;
        public FrmStudentRecord()
        {
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {
            btnRegister.Click -= btnRegister_Click;
            btnRegister.Click += btnRegister_Click;
            btnFind.Click -= btnFind_Click;
            btnFind.Click += btnFind_Click;
            btnUpload.Click -= btnUpload_Click;
            btnUpload.Click += btnUpload_Click;
        }
        private void btnRegister_Click(object sender, EventArgs e) { Close(); }
        private void btnFind_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Title = "Find Student Record";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog(this) != DialogResult.OK) return;
            selectedPath = openFileDialog1.FileName;
            lvStudentRecord.Items.Clear();
            try { foreach (string line in File.ReadLines(selectedPath)) lvStudentRecord.Items.Add(line); }
            catch (Exception ex) { MessageBox.Show("Unable to read the selected record.\n\n" + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!", "Upload", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lvStudentRecord.Items.Clear(); selectedPath = string.Empty;
        }
    }
}
