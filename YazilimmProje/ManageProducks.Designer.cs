namespace YazilimmProje
{
    partial class ManageProducks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productData = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.combaCatPro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textProQty = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textProName = new System.Windows.Forms.TextBox();
            this.textProID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textProDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textProPrince = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-64, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1390, 134);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1302, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(424, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(538, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(553, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 784);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1309, 32);
            this.panel2.TabIndex = 21;
            // 
            // productData
            // 
            this.productData.BackgroundColor = System.Drawing.Color.White;
            this.productData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productData.Location = new System.Drawing.Point(572, 232);
            this.productData.Name = "productData";
            this.productData.RowHeadersWidth = 51;
            this.productData.RowTemplate.Height = 29;
            this.productData.Size = new System.Drawing.Size(725, 316);
            this.productData.TabIndex = 22;
            this.productData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productData_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkMagenta;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(216, 591);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 41);
            this.button3.TabIndex = 29;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkMagenta;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(113, 685);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 41);
            this.button2.TabIndex = 28;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkMagenta;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(113, 591);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 41);
            this.button1.TabIndex = 27;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.DarkMagenta;
            this.Addbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.Location = new System.Drawing.Point(20, 591);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(85, 41);
            this.Addbtn.TabIndex = 26;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // combaCatPro
            // 
            this.combaCatPro.BackColor = System.Drawing.Color.Ivory;
            this.combaCatPro.ForeColor = System.Drawing.Color.DarkMagenta;
            this.combaCatPro.FormattingEnabled = true;
            this.combaCatPro.Location = new System.Drawing.Point(30, 499);
            this.combaCatPro.Name = "combaCatPro";
            this.combaCatPro.Size = new System.Drawing.Size(187, 28);
            this.combaCatPro.TabIndex = 32;
            this.combaCatPro.Text = "Product Category";
            this.combaCatPro.SelectedIndexChanged += new System.EventHandler(this.combaCatPro_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Ivory;
            this.label4.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(810, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 47);
            this.label4.TabIndex = 4;
            this.label4.Text = "PRODUCTS LIST";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textProQty
            // 
            this.textProQty.BackColor = System.Drawing.Color.Ivory;
            this.textProQty.Location = new System.Drawing.Point(204, 296);
            this.textProQty.Name = "textProQty";
            this.textProQty.Size = new System.Drawing.Size(169, 27);
            this.textProQty.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Ivory;
            this.label13.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label13.Location = new System.Drawing.Point(31, 299);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "Product Qty";
            // 
            // textProName
            // 
            this.textProName.BackColor = System.Drawing.Color.Ivory;
            this.textProName.ForeColor = System.Drawing.Color.Black;
            this.textProName.Location = new System.Drawing.Point(204, 220);
            this.textProName.Name = "textProName";
            this.textProName.Size = new System.Drawing.Size(169, 27);
            this.textProName.TabIndex = 41;
            // 
            // textProID
            // 
            this.textProID.BackColor = System.Drawing.Color.Ivory;
            this.textProID.Location = new System.Drawing.Point(204, 159);
            this.textProID.Name = "textProID";
            this.textProID.Size = new System.Drawing.Size(169, 27);
            this.textProID.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Ivory;
            this.label11.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label11.Location = new System.Drawing.Point(31, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Product Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Ivory;
            this.label12.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label12.Location = new System.Drawing.Point(31, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "Produc ID";
            // 
            // textProDesc
            // 
            this.textProDesc.BackColor = System.Drawing.Color.Ivory;
            this.textProDesc.Location = new System.Drawing.Point(204, 437);
            this.textProDesc.Name = "textProDesc";
            this.textProDesc.Size = new System.Drawing.Size(169, 27);
            this.textProDesc.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Ivory;
            this.label5.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label5.Location = new System.Drawing.Point(31, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Decripciton";
            // 
            // textProPrince
            // 
            this.textProPrince.BackColor = System.Drawing.Color.Ivory;
            this.textProPrince.Location = new System.Drawing.Point(204, 361);
            this.textProPrince.Name = "textProPrince";
            this.textProPrince.Size = new System.Drawing.Size(169, 27);
            this.textProPrince.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Ivory;
            this.label6.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label6.Location = new System.Drawing.Point(31, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Product Prince";
            // 
            // ManageProducks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1309, 816);
            this.Controls.Add(this.textProDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textProPrince);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textProQty);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textProName);
            this.Controls.Add(this.textProID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combaCatPro);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.productData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProducks";
            this.Text = "ManageProducks";
            this.Load += new System.EventHandler(this.ManageProducks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private DataGridView productData;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button Addbtn;
        private ComboBox combaCatPro;
        private Label label4;
        private TextBox textProQty;
        private Label label13;
        private TextBox textProName;
        private TextBox textProID;
        private Label label11;
        private Label label12;
        private TextBox textProDesc;
        private Label label5;
        private TextBox textProPrince;
        private Label label6;
    }
}