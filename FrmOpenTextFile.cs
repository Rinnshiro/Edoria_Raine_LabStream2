using System;
using System.IO;
using System.Windows.Forms;

namespace Edoria_Raine_LabStream
{
    public partial class FrmOpenTextFile : Form
    {
        private string path = string.Empty;
        public FrmOpenTextFile()
        {
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {
            btnOpen.Click -= btnOpen_Click;
            btnOpen.Click += btnOpen_Click;
            btnRecords.Click -= btnRecords_Click;
            btnRecords.Click += btnRecords_Click;
            btnLab1.Click -= btnLab1_Click;
            btnLab1.Click += btnLab1_Click;
        }
        private void btnOpen_Click(object sender, EventArgs e) { DisplayToList(); }
        private void btnLab1_Click(object sender, EventArgs e)
        {
            using (FrmLab1 form = new FrmLab1()) form.ShowDialog(this);
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            using (FrmRegistration form = new FrmRegistration()) form.ShowDialog(this);
        }
        private void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog(this) != DialogResult.OK) return;
            path = openFileDialog1.FileName;
            lvShowText.Items.Clear();
            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string getText;
                    while ((getText = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(getText);
                        lvShowText.Items.Add(getText);
                    }
                }
            }
            catch (UnauthorizedAccessException ex) { ShowError(new TextFileReadException("Access to the selected file was denied.", ex)); }
            catch (IOException ex) { ShowError(new TextFileReadException("The selected text file could not be read.", ex)); }
            catch (Exception ex) { ShowError(new TextFileReadException("An unexpected error occurred while reading the file.", ex)); }
        }
        private static void ShowError(TextFileReadException ex)
        {
            MessageBox.Show(ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
