using System.Drawing;
using System.Windows.Forms;

namespace Edoria_Raine_LabStream2
{
    partial class FrmLab1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblPrompt;
        private TextBox txtInput;
        private Button btnCreate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblPrompt = new Label();
            txtInput = new TextBox();
            btnCreate = new Button();
            SuspendLayout();
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(28, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(225, 41);
            lblTitle.Text = "Creating Text File";
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(31, 77);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(154, 20);
            lblPrompt.Text = "Enter the text to save:";
            txtInput.Location = new Point(34, 105);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Size = new Size(450, 105);
            btnCreate.Location = new Point(364, 228);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(120, 40);
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            AcceptButton = btnCreate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 300);
            Controls.Add(btnCreate);
            Controls.Add(txtInput);
            Controls.Add(lblPrompt);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmLab1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmLab1 - Creating Text File";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
