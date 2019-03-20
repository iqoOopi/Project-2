namespace AllWindowsForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.StartBox = new System.Windows.Forms.TextBox();
            this.EndDate = new System.Windows.Forms.TextBox();
            this.BaseBox = new System.Windows.Forms.TextBox();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.AgencyBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.ErrIDFind = new System.Windows.Forms.Label();
            this.ErrName = new System.Windows.Forms.Label();
            this.ErrDesc = new System.Windows.Forms.Label();
            this.ErrBase = new System.Windows.Forms.Label();
            this.ErrAgency = new System.Windows.Forms.Label();
            this.ErrEnd = new System.Windows.Forms.Label();
            this.ErrStart = new System.Windows.Forms.Label();
            this.ErrTotal = new System.Windows.Forms.Label();
            this.ErrDate = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Previous";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(379, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Save Changes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(119, 45);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(254, 20);
            this.NameBox.TabIndex = 20;
            // 
            // StartBox
            // 
            this.StartBox.Location = new System.Drawing.Point(119, 72);
            this.StartBox.Name = "StartBox";
            this.StartBox.Size = new System.Drawing.Size(254, 20);
            this.StartBox.TabIndex = 4;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(119, 98);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(254, 20);
            this.EndDate.TabIndex = 5;
            // 
            // BaseBox
            // 
            this.BaseBox.Location = new System.Drawing.Point(119, 150);
            this.BaseBox.Name = "BaseBox";
            this.BaseBox.Size = new System.Drawing.Size(254, 20);
            this.BaseBox.TabIndex = 6;
            // 
            // DescBox
            // 
            this.DescBox.Location = new System.Drawing.Point(119, 124);
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(254, 20);
            this.DescBox.TabIndex = 7;
            // 
            // AgencyBox
            // 
            this.AgencyBox.Location = new System.Drawing.Point(119, 176);
            this.AgencyBox.Name = "AgencyBox";
            this.AgencyBox.Size = new System.Drawing.Size(254, 20);
            this.AgencyBox.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(379, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(298, 314);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Clear All";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Package Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Base Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Agency Commission";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Pkg Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Find By Package ID";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(52, 269);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 18;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(159, 265);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Find";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ErrIDFind
            // 
            this.ErrIDFind.AutoSize = true;
            this.ErrIDFind.ForeColor = System.Drawing.Color.Red;
            this.ErrIDFind.Location = new System.Drawing.Point(66, 292);
            this.ErrIDFind.Name = "ErrIDFind";
            this.ErrIDFind.Size = new System.Drawing.Size(66, 13);
            this.ErrIDFind.TabIndex = 21;
            this.ErrIDFind.Text = "ID not found";
            this.ErrIDFind.Visible = false;
            // 
            // ErrName
            // 
            this.ErrName.AutoSize = true;
            this.ErrName.ForeColor = System.Drawing.Color.Red;
            this.ErrName.Location = new System.Drawing.Point(380, 45);
            this.ErrName.Name = "ErrName";
            this.ErrName.Size = new System.Drawing.Size(77, 13);
            this.ErrName.TabIndex = 23;
            this.ErrName.Text = "Cannot be Null";
            this.ErrName.Visible = false;
            // 
            // ErrDesc
            // 
            this.ErrDesc.AutoSize = true;
            this.ErrDesc.ForeColor = System.Drawing.Color.Red;
            this.ErrDesc.Location = new System.Drawing.Point(383, 124);
            this.ErrDesc.Name = "ErrDesc";
            this.ErrDesc.Size = new System.Drawing.Size(77, 13);
            this.ErrDesc.TabIndex = 24;
            this.ErrDesc.Text = "Cannot be Null";
            this.ErrDesc.Visible = false;
            // 
            // ErrBase
            // 
            this.ErrBase.AutoSize = true;
            this.ErrBase.ForeColor = System.Drawing.Color.Red;
            this.ErrBase.Location = new System.Drawing.Point(383, 153);
            this.ErrBase.Name = "ErrBase";
            this.ErrBase.Size = new System.Drawing.Size(65, 13);
            this.ErrBase.TabIndex = 25;
            this.ErrBase.Text = "Invalid Price";
            this.ErrBase.Visible = false;
            // 
            // ErrAgency
            // 
            this.ErrAgency.AutoSize = true;
            this.ErrAgency.ForeColor = System.Drawing.Color.Red;
            this.ErrAgency.Location = new System.Drawing.Point(383, 179);
            this.ErrAgency.Name = "ErrAgency";
            this.ErrAgency.Size = new System.Drawing.Size(65, 13);
            this.ErrAgency.TabIndex = 26;
            this.ErrAgency.Text = "Invalid Price";
            this.ErrAgency.Visible = false;
            // 
            // ErrEnd
            // 
            this.ErrEnd.AutoSize = true;
            this.ErrEnd.ForeColor = System.Drawing.Color.Red;
            this.ErrEnd.Location = new System.Drawing.Point(383, 98);
            this.ErrEnd.Name = "ErrEnd";
            this.ErrEnd.Size = new System.Drawing.Size(64, 13);
            this.ErrEnd.TabIndex = 28;
            this.ErrEnd.Text = "Invalid Date";
            this.ErrEnd.Visible = false;
            // 
            // ErrStart
            // 
            this.ErrStart.AutoSize = true;
            this.ErrStart.ForeColor = System.Drawing.Color.Red;
            this.ErrStart.Location = new System.Drawing.Point(384, 75);
            this.ErrStart.Name = "ErrStart";
            this.ErrStart.Size = new System.Drawing.Size(64, 13);
            this.ErrStart.TabIndex = 27;
            this.ErrStart.Text = "Invalid Date";
            this.ErrStart.Visible = false;
            // 
            // ErrTotal
            // 
            this.ErrTotal.AutoSize = true;
            this.ErrTotal.ForeColor = System.Drawing.Color.Red;
            this.ErrTotal.Location = new System.Drawing.Point(160, 209);
            this.ErrTotal.Name = "ErrTotal";
            this.ErrTotal.Size = new System.Drawing.Size(213, 13);
            this.ErrTotal.TabIndex = 29;
            this.ErrTotal.Text = "Agency must high lower than the base price";
            this.ErrTotal.Visible = false;
            // 
            // ErrDate
            // 
            this.ErrDate.AutoSize = true;
            this.ErrDate.ForeColor = System.Drawing.Color.Red;
            this.ErrDate.Location = new System.Drawing.Point(184, 232);
            this.ErrDate.Name = "ErrDate";
            this.ErrDate.Size = new System.Drawing.Size(189, 13);
            this.ErrDate.TabIndex = 30;
            this.ErrDate.Text = "Start date must be before the end date";
            this.ErrDate.Visible = false;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(102, 317);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(100, 20);
            this.test.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 349);
            this.Controls.Add(this.test);
            this.Controls.Add(this.ErrDate);
            this.Controls.Add(this.ErrTotal);
            this.Controls.Add(this.ErrEnd);
            this.Controls.Add(this.ErrStart);
            this.Controls.Add(this.ErrAgency);
            this.Controls.Add(this.ErrBase);
            this.Controls.Add(this.ErrDesc);
            this.Controls.Add(this.ErrName);
            this.Controls.Add(this.ErrIDFind);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AgencyBox);
            this.Controls.Add(this.DescBox);
            this.Controls.Add(this.BaseBox);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox StartBox;
        private System.Windows.Forms.TextBox EndDate;
        private System.Windows.Forms.TextBox BaseBox;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.TextBox AgencyBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label ErrIDFind;
        private System.Windows.Forms.Label ErrName;
        private System.Windows.Forms.Label ErrDesc;
        private System.Windows.Forms.Label ErrBase;
        private System.Windows.Forms.Label ErrAgency;
        private System.Windows.Forms.Label ErrEnd;
        private System.Windows.Forms.Label ErrStart;
        private System.Windows.Forms.Label ErrTotal;
        private System.Windows.Forms.Label ErrDate;
        private System.Windows.Forms.TextBox test;
    }
}

