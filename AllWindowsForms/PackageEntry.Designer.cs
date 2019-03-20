namespace PackageEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PkgName = new System.Windows.Forms.TextBox();
            this.PkgStart = new System.Windows.Forms.TextBox();
            this.PkgDesc = new System.Windows.Forms.TextBox();
            this.PkgEnd = new System.Windows.Forms.TextBox();
            this.PkgCom = new System.Windows.Forms.TextBox();
            this.PkgBase = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ErrName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ErrDesc = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Products = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pkg Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pkg End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pkg Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Base Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Agency Commission";
            // 
            // PkgName
            // 
            this.PkgName.Location = new System.Drawing.Point(102, 25);
            this.PkgName.Name = "PkgName";
            this.PkgName.Size = new System.Drawing.Size(289, 20);
            this.PkgName.TabIndex = 6;
            // 
            // PkgStart
            // 
            this.PkgStart.Location = new System.Drawing.Point(102, 51);
            this.PkgStart.Name = "PkgStart";
            this.PkgStart.Size = new System.Drawing.Size(289, 20);
            this.PkgStart.TabIndex = 7;
            // 
            // PkgDesc
            // 
            this.PkgDesc.Location = new System.Drawing.Point(102, 103);
            this.PkgDesc.Name = "PkgDesc";
            this.PkgDesc.Size = new System.Drawing.Size(289, 20);
            this.PkgDesc.TabIndex = 9;
            // 
            // PkgEnd
            // 
            this.PkgEnd.Location = new System.Drawing.Point(102, 77);
            this.PkgEnd.Name = "PkgEnd";
            this.PkgEnd.Size = new System.Drawing.Size(289, 20);
            this.PkgEnd.TabIndex = 8;
            // 
            // PkgCom
            // 
            this.PkgCom.Location = new System.Drawing.Point(102, 155);
            this.PkgCom.Name = "PkgCom";
            this.PkgCom.Size = new System.Drawing.Size(289, 20);
            this.PkgCom.TabIndex = 11;
            // 
            // PkgBase
            // 
            this.PkgBase.Location = new System.Drawing.Point(102, 129);
            this.PkgBase.Name = "PkgBase";
            this.PkgBase.Size = new System.Drawing.Size(289, 20);
            this.PkgBase.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(501, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "ClearAll";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(501, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ErrName
            // 
            this.ErrName.AutoSize = true;
            this.ErrName.ForeColor = System.Drawing.Color.Red;
            this.ErrName.Location = new System.Drawing.Point(405, 28);
            this.ErrName.Name = "ErrName";
            this.ErrName.Size = new System.Drawing.Size(75, 13);
            this.ErrName.TabIndex = 15;
            this.ErrName.Text = "Cannot be null";
            this.ErrName.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(405, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Invalid Date";
            this.label8.Visible = false;
            // 
            // ErrDesc
            // 
            this.ErrDesc.AutoSize = true;
            this.ErrDesc.ForeColor = System.Drawing.Color.Red;
            this.ErrDesc.Location = new System.Drawing.Point(405, 106);
            this.ErrDesc.Name = "ErrDesc";
            this.ErrDesc.Size = new System.Drawing.Size(75, 13);
            this.ErrDesc.TabIndex = 18;
            this.ErrDesc.Text = "Cannot be null";
            this.ErrDesc.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(405, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Invalid Date";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(405, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Invalid Commission";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(405, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Invalid Price";
            this.label12.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Products";
            // 
            // Products
            // 
            this.Products.FormattingEnabled = true;
            this.Products.Location = new System.Drawing.Point(102, 188);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(120, 95);
            this.Products.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 297);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ErrDesc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ErrName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PkgCom);
            this.Controls.Add(this.PkgBase);
            this.Controls.Add(this.PkgDesc);
            this.Controls.Add(this.PkgEnd);
            this.Controls.Add(this.PkgStart);
            this.Controls.Add(this.PkgName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "New Package";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PkgName;
        private System.Windows.Forms.TextBox PkgStart;
        private System.Windows.Forms.TextBox PkgDesc;
        private System.Windows.Forms.TextBox PkgEnd;
        private System.Windows.Forms.TextBox PkgCom;
        private System.Windows.Forms.TextBox PkgBase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label ErrName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ErrDesc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox Products;
    }
}

