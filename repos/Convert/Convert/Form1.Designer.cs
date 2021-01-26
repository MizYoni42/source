
namespace Convert
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
            this.FahrenheitBtn = new System.Windows.Forms.Label();
            this.CelsiusBtn = new System.Windows.Forms.Label();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.fahrTxtbox = new System.Windows.Forms.TextBox();
            this.celsTxtbox = new System.Windows.Forms.TextBox();
            this.FahrtoC = new System.Windows.Forms.RadioButton();
            this.CtoFahr = new System.Windows.Forms.RadioButton();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FahrenheitBtn
            // 
            this.FahrenheitBtn.AutoSize = true;
            this.FahrenheitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FahrenheitBtn.ForeColor = System.Drawing.Color.Navy;
            this.FahrenheitBtn.Location = new System.Drawing.Point(387, 40);
            this.FahrenheitBtn.Name = "FahrenheitBtn";
            this.FahrenheitBtn.Size = new System.Drawing.Size(78, 18);
            this.FahrenheitBtn.TabIndex = 0;
            this.FahrenheitBtn.Text = "Farenheit";
            // 
            // CelsiusBtn
            // 
            this.CelsiusBtn.AutoSize = true;
            this.CelsiusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelsiusBtn.ForeColor = System.Drawing.Color.Navy;
            this.CelsiusBtn.Location = new System.Drawing.Point(599, 40);
            this.CelsiusBtn.Name = "CelsiusBtn";
            this.CelsiusBtn.Size = new System.Drawing.Size(64, 18);
            this.CelsiusBtn.TabIndex = 1;
            this.CelsiusBtn.Text = "Celsius";
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ConvertBtn.Location = new System.Drawing.Point(224, 378);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(103, 47);
            this.ConvertBtn.TabIndex = 2;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = false;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ExitBtn.Location = new System.Drawing.Point(602, 378);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(100, 47);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // fahrTxtbox
            // 
            this.fahrTxtbox.Location = new System.Drawing.Point(471, 38);
            this.fahrTxtbox.Name = "fahrTxtbox";
            this.fahrTxtbox.Size = new System.Drawing.Size(100, 20);
            this.fahrTxtbox.TabIndex = 4;
            // 
            // celsTxtbox
            // 
            this.celsTxtbox.Location = new System.Drawing.Point(669, 41);
            this.celsTxtbox.Name = "celsTxtbox";
            this.celsTxtbox.Size = new System.Drawing.Size(100, 20);
            this.celsTxtbox.TabIndex = 5;
            // 
            // FahrtoC
            // 
            this.FahrtoC.AutoSize = true;
            this.FahrtoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FahrtoC.ForeColor = System.Drawing.Color.Navy;
            this.FahrtoC.Location = new System.Drawing.Point(224, 122);
            this.FahrtoC.Name = "FahrtoC";
            this.FahrtoC.Size = new System.Drawing.Size(126, 22);
            this.FahrtoC.TabIndex = 6;
            this.FahrtoC.TabStop = true;
            this.FahrtoC.Text = "Fahr to Celsius";
            this.FahrtoC.UseVisualStyleBackColor = true;
            // 
            // CtoFahr
            // 
            this.CtoFahr.AutoSize = true;
            this.CtoFahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtoFahr.ForeColor = System.Drawing.Color.Navy;
            this.CtoFahr.Location = new System.Drawing.Point(224, 212);
            this.CtoFahr.Name = "CtoFahr";
            this.CtoFahr.Size = new System.Drawing.Size(121, 22);
            this.CtoFahr.TabIndex = 7;
            this.CtoFahr.TabStop = true;
            this.CtoFahr.Text = "Celsius to fahr";
            this.CtoFahr.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(419, 390);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.CtoFahr);
            this.Controls.Add(this.FahrtoC);
            this.Controls.Add(this.celsTxtbox);
            this.Controls.Add(this.fahrTxtbox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.CelsiusBtn);
            this.Controls.Add(this.FahrenheitBtn);
            this.Name = "Form1";
            this.Text = "Convert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FahrenheitBtn;
        private System.Windows.Forms.Label CelsiusBtn;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox fahrTxtbox;
        private System.Windows.Forms.TextBox celsTxtbox;
        private System.Windows.Forms.RadioButton FahrtoC;
        private System.Windows.Forms.RadioButton CtoFahr;
        private System.Windows.Forms.Button clearBtn;
    }
}

