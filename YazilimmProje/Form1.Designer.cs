namespace YazilimmProje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(125, 141);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(125, 27);
            this.passwordtb.TabIndex = 10;
            this.passwordtb.TextChanged += new System.EventHandler(this.passwordtb_TextChanged);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.White;
            this.clearbtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.clearbtn.Location = new System.Drawing.Point(9, 225);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(63, 29);
            this.clearbtn.TabIndex = 5;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(9, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "PASSWORD";
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.White;
            this.loginbtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.loginbtn.Location = new System.Drawing.Point(214, 385);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(134, 48);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(10, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "USERNAME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(125, 61);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(125, 27);
            this.nameTb.TabIndex = 9;
            this.nameTb.TextChanged += new System.EventHandler(this.nameTb_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBox1.Location = new System.Drawing.Point(118, 228);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(98, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.passwordtb);
            this.panel1.Controls.Add(this.clearbtn);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.nameTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(159, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 280);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(666, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Button clearbtn;
        private Button loginbtn;
        private CheckBox checkBox1;
        private TextBox passwordtb;
        private TextBox nameTb;
        private Label label4;
        private Label label3;
        private Panel panel1;
    }
}