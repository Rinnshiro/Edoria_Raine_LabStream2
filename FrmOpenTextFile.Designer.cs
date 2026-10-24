using System;
using System.Drawing;
using System.Windows.Forms;

namespace Edoria_Raine_LabStream2
{
partial class FrmOpenTextFile
{
    private System.ComponentModel.IContainer components = null;
    private ListView lvShowText;
    private Button btnOpen;
    private Button btnRecords;
    private Button btnLab1;
    private OpenFileDialog openFileDialog1;
    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
			this.lvShowText = new System.Windows.Forms.ListView();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnRecords = new System.Windows.Forms.Button();
			this.btnLab1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// lvShowText
			// 
			this.lvShowText.HideSelection = false;
			this.lvShowText.Location = new System.Drawing.Point(20, 18);
			this.lvShowText.Name = "lvShowText";
			this.lvShowText.Size = new System.Drawing.Size(390, 205);
			this.lvShowText.TabIndex = 0;
			this.lvShowText.UseCompatibleStateImageBehavior = false;
			this.lvShowText.View = System.Windows.Forms.View.List;
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(170, 240);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(95, 38);
			this.btnOpen.TabIndex = 1;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			// 
			// btnRecords
			// 
			this.btnRecords.Location = new System.Drawing.Point(315, 240);
			this.btnRecords.Name = "btnRecords";
			this.btnRecords.Size = new System.Drawing.Size(95, 38);
			this.btnRecords.TabIndex = 2;
			this.btnRecords.Text = "Records";
			this.btnRecords.UseVisualStyleBackColor = true;
			// 
			// btnLab1
			// 
			this.btnLab1.Location = new System.Drawing.Point(20, 240);
			this.btnLab1.Name = "btnLab1";
			this.btnLab1.Size = new System.Drawing.Size(95, 38);
			this.btnLab1.TabIndex = 3;
			this.btnLab1.Text = "Text";
			this.btnLab1.UseVisualStyleBackColor = true;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "txt";
			this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			this.openFileDialog1.Title = "Browse Text Files";
			// 
			// FrmOpenTextFile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 295);
			this.Controls.Add(this.btnLab1);
			this.Controls.Add(this.btnRecords);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.lvShowText);
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FrmOpenTextFile";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmOpenTextFile";
			this.ResumeLayout(false);

    }
}

}
