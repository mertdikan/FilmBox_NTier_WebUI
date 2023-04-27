
namespace WinUI
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTabloyaGit = new System.Windows.Forms.Button();
            this.Tablolar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTabloyaGit
            // 
            this.btnTabloyaGit.BackColor = System.Drawing.Color.Lavender;
            this.btnTabloyaGit.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTabloyaGit.Location = new System.Drawing.Point(368, 12);
            this.btnTabloyaGit.Name = "btnTabloyaGit";
            this.btnTabloyaGit.Size = new System.Drawing.Size(130, 35);
            this.btnTabloyaGit.TabIndex = 0;
            this.btnTabloyaGit.Text = "GİT";
            this.btnTabloyaGit.UseVisualStyleBackColor = false;
            this.btnTabloyaGit.Click += new System.EventHandler(this.btnTabloyaGit_Click);
            // 
            // Tablolar
            // 
            this.Tablolar.BackColor = System.Drawing.Color.AliceBlue;
            this.Tablolar.FormattingEnabled = true;
            this.Tablolar.Location = new System.Drawing.Point(12, 77);
            this.Tablolar.Name = "Tablolar";
            this.Tablolar.Size = new System.Drawing.Size(340, 407);
            this.Tablolar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lütfen Tablo Seçiniz.";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(532, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tablolar);
            this.Controls.Add(this.btnTabloyaGit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTabloyaGit;
        private System.Windows.Forms.ListBox Tablolar;
        private System.Windows.Forms.Label label1;
    }
}