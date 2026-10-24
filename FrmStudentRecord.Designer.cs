using System;
using System.Drawing;
using System.Windows.Forms;

namespace Edoria_Raine_LabStream2
{
partial class FrmStudentRecord
{
    private System.ComponentModel.IContainer components = null;
    private Label lblViewRecord;
    private ListView lvStudentRecord;
    private Button btnRegister;
    private Button btnFind;
    private Button btnUpload;
    private OpenFileDialog openFileDialog1;
    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        lblViewRecord = new Label();
        lvStudentRecord = new ListView();
        btnRegister = new Button();
        btnFind = new Button();
        btnUpload = new Button();
        openFileDialog1 = new OpenFileDialog();
        SuspendLayout();
        lblViewRecord.AutoSize = true;
        lblViewRecord.Font = new Font("Segoe UI", 13F);
        lblViewRecord.Location = new Point(14, 12);
        lblViewRecord.Name = "lblViewRecord";
        lblViewRecord.Size = new Size(130, 30);
        lblViewRecord.Text = "View Record";
        lvStudentRecord.Location = new Point(16, 45);
        lvStudentRecord.Name = "lvStudentRecord";
        lvStudentRecord.Size = new Size(405, 167);
        lvStudentRecord.UseCompatibleStateImageBehavior = false;
        lvStudentRecord.View = View.List;
        btnRegister.Location = new Point(430, 45);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(98, 33);
        btnRegister.Text = "Register";
        btnRegister.UseVisualStyleBackColor = true;
        btnFind.Location = new Point(430, 88);
        btnFind.Name = "btnFind";
        btnFind.Size = new Size(98, 33);
        btnFind.Text = "Find";
        btnFind.UseVisualStyleBackColor = true;
        btnUpload.Location = new Point(430, 131);
        btnUpload.Name = "btnUpload";
        btnUpload.Size = new Size(98, 33);
        btnUpload.Text = "Upload";
        btnUpload.UseVisualStyleBackColor = true;
        openFileDialog1.DefaultExt = "txt";
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(545, 232);
        Controls.Add(btnUpload);
        Controls.Add(btnFind);
        Controls.Add(btnRegister);
        Controls.Add(lvStudentRecord);
        Controls.Add(lblViewRecord);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "FrmStudentRecord";
        StartPosition = FormStartPosition.CenterParent;
        Text = "FrmStudentRecord";
        ResumeLayout(false);
        PerformLayout();
    }
}

}
