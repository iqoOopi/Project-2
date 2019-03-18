namespace AllWindowsForms
{
    partial class MainForm
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
            this.prodForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prodForm
            // 
            this.prodForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodForm.Location = new System.Drawing.Point(0, 0);
            this.prodForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prodForm.Name = "prodForm";
            this.prodForm.Size = new System.Drawing.Size(1200, 692);
            this.prodForm.TabIndex = 0;
            this.prodForm.Text = "prodForm";
            this.prodForm.UseVisualStyleBackColor = true;
            this.prodForm.Click += new System.EventHandler(this.prodForm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 278);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.prodForm);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "someForm2Test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button prodForm;
        private System.Windows.Forms.Button button2;
    }
}