
using System;

namespace GoTeam
{
    partial class Form1
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.GoTeamBtn = new System.Windows.Forms.Button();
            this.HelloLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ExitBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.ExitBtn.Location = new System.Drawing.Point(516, 358);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(133, 55);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // GoTeamBtn
            // 
            this.GoTeamBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.GoTeamBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.GoTeamBtn.Location = new System.Drawing.Point(225, 358);
            this.GoTeamBtn.Name = "GoTeamBtn";
            this.GoTeamBtn.Size = new System.Drawing.Size(129, 55);
            this.GoTeamBtn.TabIndex = 1;
            this.GoTeamBtn.Text = "Go Team";
            this.GoTeamBtn.UseVisualStyleBackColor = false;
            this.GoTeamBtn.Click += new System.EventHandler(this.GoTeamBtn_Click);
            // 
            // HelloLbl
            // 
            this.HelloLbl.AutoSize = true;
            this.HelloLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.HelloLbl.Location = new System.Drawing.Point(383, 81);
            this.HelloLbl.Name = "HelloLbl";
            this.HelloLbl.Size = new System.Drawing.Size(62, 13);
            this.HelloLbl.TabIndex = 2;
            this.HelloLbl.Text = "Hello World";
            this.HelloLbl.Click += new System.EventHandler(this.HelloLbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 463);
            this.Controls.Add(this.HelloLbl);
            this.Controls.Add(this.GoTeamBtn);
            this.Controls.Add(this.ExitBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button GoTeamBtn;
        private System.Windows.Forms.Label HelloLbl;
    }
}

