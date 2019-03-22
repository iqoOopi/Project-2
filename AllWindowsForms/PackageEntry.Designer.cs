namespace AllWindowsForms
{
    partial class Form2
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
            this.ErrStart = new System.Windows.Forms.Label();
            this.ErrDesc = new System.Windows.Forms.Label();
            this.ErrEnd = new System.Windows.Forms.Label();
            this.ErrAgency = new System.Windows.Forms.Label();
            this.ErrBase = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Products = new System.Windows.Forms.ListBox();
            this.ErrTotal = new System.Windows.Forms.Label();
            this.ErrDate = new System.Windows.Forms.Label();
            this.ErrDup = new System.Windows.Forms.Label();
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
            this.button1.TabIndex = 26;
            this.button1.Text = "Add";
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(507, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Cancel";
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // ErrStart
            // 
            this.ErrStart.AutoSize = true;
            this.ErrStart.ForeColor = System.Drawing.Color.Red;
            this.ErrStart.Location = new System.Drawing.Point(405, 54);
            this.ErrStart.Name = "ErrStart";
            this.ErrStart.Size = new System.Drawing.Size(64, 13);
            this.ErrStart.TabIndex = 16;
            this.ErrStart.Text = "Invalid Date";
            this.ErrStart.Visible = false;
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
            // ErrEnd
            // 
            this.ErrEnd.AutoSize = true;
            this.ErrEnd.ForeColor = System.Drawing.Color.Red;
            this.ErrEnd.Location = new System.Drawing.Point(405, 80);
            this.ErrEnd.Name = "ErrEnd";
            this.ErrEnd.Size = new System.Drawing.Size(64, 13);
            this.ErrEnd.TabIndex = 17;
            this.ErrEnd.Text = "Invalid Date";
            this.ErrEnd.Visible = false;
            // 
            // ErrAgency
            // 
            this.ErrAgency.AutoSize = true;
            this.ErrAgency.ForeColor = System.Drawing.Color.Red;
            this.ErrAgency.Location = new System.Drawing.Point(405, 158);
            this.ErrAgency.Name = "ErrAgency";
            this.ErrAgency.Size = new System.Drawing.Size(96, 13);
            this.ErrAgency.TabIndex = 20;
            this.ErrAgency.Text = "Invalid Commission";
            this.ErrAgency.Visible = false;
            // 
            // ErrBase
            // 
            this.ErrBase.AutoSize = true;
            this.ErrBase.ForeColor = System.Drawing.Color.Red;
            this.ErrBase.Location = new System.Drawing.Point(405, 132);
            this.ErrBase.Name = "ErrBase";
            this.ErrBase.Size = new System.Drawing.Size(65, 13);
            this.ErrBase.TabIndex = 19;
            this.ErrBase.Text = "Invalid Price";
            this.ErrBase.Visible = false;
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
            // ErrTotal
            // 
            this.ErrTotal.AutoSize = true;
            this.ErrTotal.ForeColor = System.Drawing.Color.Red;
            this.ErrTotal.Location = new System.Drawing.Point(313, 188);
            this.ErrTotal.Name = "ErrTotal";
            this.ErrTotal.Size = new System.Drawing.Size(188, 13);
            this.ErrTotal.TabIndex = 23;
            this.ErrTotal.Text = "Agency Must be lower than base price";
            this.ErrTotal.Visible = false;
            // 
            // ErrDate
            // 
            this.ErrDate.AutoSize = true;
            this.ErrDate.ForeColor = System.Drawing.Color.Red;
            this.ErrDate.Location = new System.Drawing.Point(289, 211);
            this.ErrDate.Name = "ErrDate";
            this.ErrDate.Size = new System.Drawing.Size(206, 13);
            this.ErrDate.TabIndex = 24;
            this.ErrDate.Text = "Package end date must be after start date";
            this.ErrDate.Visible = false;
            // 
            // ErrDup
            // 
            this.ErrDup.AutoSize = true;
            this.ErrDup.ForeColor = System.Drawing.Color.Red;
            this.ErrDup.Location = new System.Drawing.Point(396, 241);
            this.ErrDup.Name = "ErrDup";
            this.ErrDup.Size = new System.Drawing.Size(99, 13);
            this.ErrDup.TabIndex = 27;
            this.ErrDup.Text = "Duplicate Detected";
            this.ErrDup.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 297);
            this.Controls.Add(this.ErrDup);
            this.Controls.Add(this.ErrDate);
            this.Controls.Add(this.ErrTotal);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ErrAgency);
            this.Controls.Add(this.ErrBase);
            this.Controls.Add(this.ErrDesc);
            this.Controls.Add(this.ErrEnd);
            this.Controls.Add(this.ErrStart);
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
            this.Name = "Form2";
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
        private System.Windows.Forms.Label ErrStart;
        private System.Windows.Forms.Label ErrDesc;
        private System.Windows.Forms.Label ErrEnd;
        private System.Windows.Forms.Label ErrAgency;
        private System.Windows.Forms.Label ErrBase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox Products;
        private System.Windows.Forms.Label ErrTotal;
        private System.Windows.Forms.Label ErrDate;
        private System.Windows.Forms.Label ErrDup;
    }
}

