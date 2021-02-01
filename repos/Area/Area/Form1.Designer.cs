
namespace Area
{
    partial class Area
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
            this.radiusBtn = new System.Windows.Forms.Label();
            this.widthBtn = new System.Windows.Forms.Label();
            this.areaBtn = new System.Windows.Forms.Label();
            this.calcAreabtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.radiusTxtbox = new System.Windows.Forms.TextBox();
            this.widthTxtbox = new System.Windows.Forms.TextBox();
            this.areaTxtbox = new System.Windows.Forms.TextBox();
            this.radioBtn1 = new System.Windows.Forms.RadioButton();
            this.radioBtn2 = new System.Windows.Forms.RadioButton();
            this.radioBtn3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radiusBtn
            // 
            this.radiusBtn.AutoSize = true;
            this.radiusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiusBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radiusBtn.Location = new System.Drawing.Point(532, 57);
            this.radiusBtn.Name = "radiusBtn";
            this.radiusBtn.Size = new System.Drawing.Size(58, 18);
            this.radiusBtn.TabIndex = 0;
            this.radiusBtn.Text = "Radius:";
            // 
            // widthBtn
            // 
            this.widthBtn.AutoSize = true;
            this.widthBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.widthBtn.Location = new System.Drawing.Point(532, 27);
            this.widthBtn.Name = "widthBtn";
            this.widthBtn.Size = new System.Drawing.Size(50, 18);
            this.widthBtn.TabIndex = 1;
            this.widthBtn.Text = "Width:";
            // 
            // areaBtn
            // 
            this.areaBtn.AutoSize = true;
            this.areaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.areaBtn.Location = new System.Drawing.Point(532, 83);
            this.areaBtn.Name = "areaBtn";
            this.areaBtn.Size = new System.Drawing.Size(42, 18);
            this.areaBtn.TabIndex = 2;
            this.areaBtn.Text = "Area:";
            // 
            // calcAreabtn
            // 
            this.calcAreabtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calcAreabtn.Location = new System.Drawing.Point(143, 394);
            this.calcAreabtn.Name = "calcAreabtn";
            this.calcAreabtn.Size = new System.Drawing.Size(75, 44);
            this.calcAreabtn.TabIndex = 3;
            this.calcAreabtn.Text = "Calc Area";
            this.calcAreabtn.UseVisualStyleBackColor = false;
            this.calcAreabtn.Click += new System.EventHandler(this.calcAreabtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearBtn.Location = new System.Drawing.Point(289, 394);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 44);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitBtn.Location = new System.Drawing.Point(422, 394);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 44);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // radiusTxtbox
            // 
            this.radiusTxtbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radiusTxtbox.Location = new System.Drawing.Point(621, 54);
            this.radiusTxtbox.Name = "radiusTxtbox";
            this.radiusTxtbox.Size = new System.Drawing.Size(100, 20);
            this.radiusTxtbox.TabIndex = 6;
            // 
            // widthTxtbox
            // 
            this.widthTxtbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.widthTxtbox.Location = new System.Drawing.Point(621, 28);
            this.widthTxtbox.Name = "widthTxtbox";
            this.widthTxtbox.Size = new System.Drawing.Size(100, 20);
            this.widthTxtbox.TabIndex = 7;
            // 
            // areaTxtbox
            // 
            this.areaTxtbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.areaTxtbox.Location = new System.Drawing.Point(621, 81);
            this.areaTxtbox.Name = "areaTxtbox";
            this.areaTxtbox.Size = new System.Drawing.Size(100, 20);
            this.areaTxtbox.TabIndex = 8;
            // 
            // radioBtn1
            // 
            this.radioBtn1.AutoSize = true;
            this.radioBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn1.Location = new System.Drawing.Point(266, 167);
            this.radioBtn1.Name = "radioBtn1";
            this.radioBtn1.Size = new System.Drawing.Size(64, 22);
            this.radioBtn1.TabIndex = 9;
            this.radioBtn1.TabStop = true;
            this.radioBtn1.Text = "Circle";
            this.radioBtn1.UseVisualStyleBackColor = true;
            this.radioBtn1.CheckedChanged += new System.EventHandler(this.radioBtn1_CheckedChanged);
            // 
            // radioBtn2
            // 
            this.radioBtn2.AutoSize = true;
            this.radioBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn2.Location = new System.Drawing.Point(266, 205);
            this.radioBtn2.Name = "radioBtn2";
            this.radioBtn2.Size = new System.Drawing.Size(73, 22);
            this.radioBtn2.TabIndex = 10;
            this.radioBtn2.TabStop = true;
            this.radioBtn2.Text = "Square";
            this.radioBtn2.UseVisualStyleBackColor = true;
            this.radioBtn2.CheckedChanged += new System.EventHandler(this.radioBtn2_CheckedChanged);
            // 
            // radioBtn3
            // 
            this.radioBtn3.AutoSize = true;
            this.radioBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn3.Location = new System.Drawing.Point(266, 243);
            this.radioBtn3.Name = "radioBtn3";
            this.radioBtn3.Size = new System.Drawing.Size(92, 22);
            this.radioBtn3.TabIndex = 11;
            this.radioBtn3.TabStop = true;
            this.radioBtn3.Text = "Rectangle";
            this.radioBtn3.UseVisualStyleBackColor = true;
            this.radioBtn3.CheckedChanged += new System.EventHandler(this.radioBtn3_CheckedChanged);
            // 
            // Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioBtn3);
            this.Controls.Add(this.radioBtn2);
            this.Controls.Add(this.radioBtn1);
            this.Controls.Add(this.areaTxtbox);
            this.Controls.Add(this.widthTxtbox);
            this.Controls.Add(this.radiusTxtbox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calcAreabtn);
            this.Controls.Add(this.areaBtn);
            this.Controls.Add(this.widthBtn);
            this.Controls.Add(this.radiusBtn);
            this.Name = "Area";
            this.Text = "Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label radiusBtn;
        private System.Windows.Forms.Label widthBtn;
        private System.Windows.Forms.Label areaBtn;
        private System.Windows.Forms.Button calcAreabtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox radiusTxtbox;
        private System.Windows.Forms.TextBox widthTxtbox;
        private System.Windows.Forms.TextBox areaTxtbox;
        private System.Windows.Forms.RadioButton radioBtn1;
        private System.Windows.Forms.RadioButton radioBtn2;
        private System.Windows.Forms.RadioButton radioBtn3;
    }
}

