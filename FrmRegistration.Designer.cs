using System;
using System.Drawing;
using System.Windows.Forms;

namespace Edoria_Raine_LabStream2
{

partial class FrmRegistration
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private Label lblStudentNo;
    private Label lblProgram;
    private Label lblLastName;
    private Label lblFirstName;
    private Label lblMI;
    private Label lblAge;
    private Label lblGender;
    private Label lblBirthday;
    private Label lblContact;
    private TextBox txtStudentNo;
    private TextBox txtLastName;
    private TextBox txtFirstName;
    private TextBox txtMiddleInitial;
    private TextBox txtContactNo;
    private ComboBox cboProgram;
    private ComboBox cboGender;
    private NumericUpDown numAge;
    private DateTimePicker dtpBirthday;
    private Button btnRegister;
    private Button btnStudentRecord;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblStudentNo = new System.Windows.Forms.Label();
			this.lblProgram = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblMI = new System.Windows.Forms.Label();
			this.lblAge = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.lblBirthday = new System.Windows.Forms.Label();
			this.lblContact = new System.Windows.Forms.Label();
			this.txtStudentNo = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtMiddleInitial = new System.Windows.Forms.TextBox();
			this.txtContactNo = new System.Windows.Forms.TextBox();
			this.cboProgram = new System.Windows.Forms.ComboBox();
			this.cboGender = new System.Windows.Forms.ComboBox();
			this.numAge = new System.Windows.Forms.NumericUpDown();
			this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnStudentRecord = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
			this.lblTitle.Location = new System.Drawing.Point(32, 20);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(175, 37);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Registration";
			// 
			// lblStudentNo
			// 
			this.lblStudentNo.AutoSize = true;
			this.lblStudentNo.Location = new System.Drawing.Point(32, 94);
			this.lblStudentNo.Name = "lblStudentNo";
			this.lblStudentNo.Size = new System.Drawing.Size(82, 19);
			this.lblStudentNo.TabIndex = 1;
			this.lblStudentNo.Text = "Student No.";
			// 
			// lblProgram
			// 
			this.lblProgram.AutoSize = true;
			this.lblProgram.Location = new System.Drawing.Point(390, 94);
			this.lblProgram.Name = "lblProgram";
			this.lblProgram.Size = new System.Drawing.Size(62, 19);
			this.lblProgram.TabIndex = 3;
			this.lblProgram.Text = "Program";
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(32, 125);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(74, 19);
			this.lblLastName.TabIndex = 5;
			this.lblLastName.Text = "Last Name";
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location = new System.Drawing.Point(390, 125);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(75, 19);
			this.lblFirstName.TabIndex = 7;
			this.lblFirstName.Text = "First Name";
			// 
			// lblMI
			// 
			this.lblMI.AutoSize = true;
			this.lblMI.Location = new System.Drawing.Point(640, 125);
			this.lblMI.Name = "lblMI";
			this.lblMI.Size = new System.Drawing.Size(32, 19);
			this.lblMI.TabIndex = 9;
			this.lblMI.Text = "M.I.";
			// 
			// lblAge
			// 
			this.lblAge.AutoSize = true;
			this.lblAge.Location = new System.Drawing.Point(103, 156);
			this.lblAge.Name = "lblAge";
			this.lblAge.Size = new System.Drawing.Size(33, 19);
			this.lblAge.TabIndex = 11;
			this.lblAge.Text = "Age";
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Location = new System.Drawing.Point(390, 156);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(54, 19);
			this.lblGender.TabIndex = 13;
			this.lblGender.Text = "Gender";
			// 
			// lblBirthday
			// 
			this.lblBirthday.AutoSize = true;
			this.lblBirthday.Location = new System.Drawing.Point(63, 187);
			this.lblBirthday.Name = "lblBirthday";
			this.lblBirthday.Size = new System.Drawing.Size(60, 19);
			this.lblBirthday.TabIndex = 15;
			this.lblBirthday.Text = "Birthday";
			// 
			// lblContact
			// 
			this.lblContact.AutoSize = true;
			this.lblContact.Location = new System.Drawing.Point(420, 187);
			this.lblContact.Name = "lblContact";
			this.lblContact.Size = new System.Drawing.Size(82, 19);
			this.lblContact.TabIndex = 17;
			this.lblContact.Text = "Contact No.";
			// 
			// txtStudentNo
			// 
			this.txtStudentNo.Location = new System.Drawing.Point(145, 89);
			this.txtStudentNo.Name = "txtStudentNo";
			this.txtStudentNo.Size = new System.Drawing.Size(205, 25);
			this.txtStudentNo.TabIndex = 2;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(145, 120);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(205, 25);
			this.txtLastName.TabIndex = 6;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(475, 120);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(150, 25);
			this.txtFirstName.TabIndex = 8;
			// 
			// txtMiddleInitial
			// 
			this.txtMiddleInitial.Location = new System.Drawing.Point(680, 120);
			this.txtMiddleInitial.MaxLength = 2;
			this.txtMiddleInitial.Name = "txtMiddleInitial";
			this.txtMiddleInitial.Size = new System.Drawing.Size(40, 25);
			this.txtMiddleInitial.TabIndex = 10;
			// 
			// txtContactNo
			// 
			this.txtContactNo.Location = new System.Drawing.Point(515, 182);
			this.txtContactNo.Name = "txtContactNo";
			this.txtContactNo.Size = new System.Drawing.Size(205, 25);
			this.txtContactNo.TabIndex = 18;
			// 
			// cboProgram
			// 
			this.cboProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboProgram.FormattingEnabled = true;
			this.cboProgram.Items.AddRange(new object[] {
            "BS Information Technology",
            "BS Computer Science",
            "BS Information Systems"});
			this.cboProgram.Location = new System.Drawing.Point(475, 89);
			this.cboProgram.Name = "cboProgram";
			this.cboProgram.Size = new System.Drawing.Size(245, 25);
			this.cboProgram.TabIndex = 4;
			// 
			// cboGender
			// 
			this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboGender.FormattingEnabled = true;
			this.cboGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Prefer not to say"});
			this.cboGender.Location = new System.Drawing.Point(475, 151);
			this.cboGender.Name = "cboGender";
			this.cboGender.Size = new System.Drawing.Size(155, 25);
			this.cboGender.TabIndex = 14;
			// 
			// numAge
			// 
			this.numAge.Location = new System.Drawing.Point(145, 151);
			this.numAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
			this.numAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numAge.Name = "numAge";
			this.numAge.Size = new System.Drawing.Size(105, 25);
			this.numAge.TabIndex = 12;
			this.numAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
			// 
			// dtpBirthday
			// 
			this.dtpBirthday.Location = new System.Drawing.Point(145, 182);
			this.dtpBirthday.Name = "dtpBirthday";
			this.dtpBirthday.Size = new System.Drawing.Size(260, 25);
			this.dtpBirthday.TabIndex = 16;
			// 
			// btnRegister
			// 
			this.btnRegister.Location = new System.Drawing.Point(546, 235);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(158, 45);
			this.btnRegister.TabIndex = 20;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = true;
			// 
			// btnStudentRecord
			// 
			this.btnStudentRecord.Location = new System.Drawing.Point(46, 235);
			this.btnStudentRecord.Name = "btnStudentRecord";
			this.btnStudentRecord.Size = new System.Drawing.Size(168, 45);
			this.btnStudentRecord.TabIndex = 19;
			this.btnStudentRecord.Text = "Records";
			this.btnStudentRecord.UseVisualStyleBackColor = true;
			// 
			// FrmRegistration
			// 
			this.AcceptButton = this.btnRegister;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 300);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.btnStudentRecord);
			this.Controls.Add(this.txtContactNo);
			this.Controls.Add(this.lblContact);
			this.Controls.Add(this.dtpBirthday);
			this.Controls.Add(this.lblBirthday);
			this.Controls.Add(this.cboGender);
			this.Controls.Add(this.lblGender);
			this.Controls.Add(this.numAge);
			this.Controls.Add(this.lblAge);
			this.Controls.Add(this.txtMiddleInitial);
			this.Controls.Add(this.lblMI);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.cboProgram);
			this.Controls.Add(this.lblProgram);
			this.Controls.Add(this.txtStudentNo);
			this.Controls.Add(this.lblStudentNo);
			this.Controls.Add(this.lblTitle);
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FrmRegistration";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FrmRegistration";
			((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }
}

}
