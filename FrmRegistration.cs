using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Edoria_Raine_LabStream2
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {
            btnStudentRecord.Click -= btnStudentRecord_Click;
            btnStudentRecord.Click += btnStudentRecord_Click;
            btnRegister.Click -= btnRegister_Click;
            btnRegister.Click += btnRegister_Click;
            dtpBirthday.ValueChanged -= dtpBirthday_ValueChanged;
            dtpBirthday.ValueChanged += dtpBirthday_ValueChanged;
        }

        private void btnStudentRecord_Click(object sender, EventArgs e)
        {
            Hide();
            using (FrmStudentRecord form = new FrmStudentRecord())
            {
                form.ShowDialog(this);
            }
            Show();
        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dtpBirthday.Value.Year;
            if (dtpBirthday.Value.Date > today.AddYears(-age))
                age--;
            numAge.Value = Math.Max(1, Math.Min(120, age));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentNo.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Complete the required fields.", "Incomplete information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentNo = txtStudentNo.Text.Trim();
            if (studentNo.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("Student number contains an invalid file-name character.",
                    "Invalid student number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string initial = txtMiddleInitial.Text.Trim().TrimEnd('.');
            string[] record = new string[]
            {
                "Student No.: " + studentNo,
                "Full Name: " + txtLastName.Text.Trim() + ", " + txtFirstName.Text.Trim() +
                    (initial.Length > 0 ? " " + initial + "." : ""),
                "Program: " + cboProgram.Text,
                "Gender: " + cboGender.Text,
                "Age: " + numAge.Value,
                "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd"),
                "Contact No.: " + txtContactNo.Text.Trim()
            };

            string file = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                studentNo + ".txt");

            try
            {
                using (StreamWriter writer = new StreamWriter(file, false, Encoding.UTF8))
                {
                    foreach (string line in record)
                        writer.WriteLine(line);
                }
                MessageBox.Show("Registration saved.\n\n" + file, "Registration saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
