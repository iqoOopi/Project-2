namespace AllWindowsForms
{
    partial class StartingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingForm));
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnPackages = new System.Windows.Forms.Button();
            this.lblChoose = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tblPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblPanelBottomRow = new System.Windows.Forms.TableLayoutPanel();
            this.tblPanelTopRow = new System.Windows.Forms.TableLayoutPanel();
            this.tblPanelMain.SuspendLayout();
            this.tblPanelBottomRow.SuspendLayout();
            this.tblPanelTopRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProducts
            // 
            this.btnProducts.AutoSize = true;
            this.btnProducts.BackColor = System.Drawing.Color.SandyBrown;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProducts.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProducts.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Location = new System.Drawing.Point(3, 3);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(304, 38);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.AutoSize = true;
            this.btnSuppliers.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSuppliers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSuppliers.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSuppliers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.Location = new System.Drawing.Point(313, 3);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(304, 38);
            this.btnSuppliers.TabIndex = 2;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnPackages
            // 
            this.btnPackages.AutoSize = true;
            this.btnPackages.BackColor = System.Drawing.Color.SandyBrown;
            this.btnPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPackages.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPackages.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPackages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPackages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackages.Location = new System.Drawing.Point(623, 3);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(306, 38);
            this.btnPackages.TabIndex = 3;
            this.btnPackages.Text = "Packages";
            this.btnPackages.UseVisualStyleBackColor = false;
            this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
            // 
            // lblChoose
            // 
            this.lblChoose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(171, 7);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(470, 29);
            this.lblChoose.TabIndex = 4;
            this.lblChoose.Text = "Choose the item that you wish to work with:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(815, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tblPanelMain
            // 
            this.tblPanelMain.ColumnCount = 1;
            this.tblPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelMain.Controls.Add(this.tblPanelBottomRow, 0, 1);
            this.tblPanelMain.Controls.Add(this.tblPanelTopRow, 0, 0);
            this.tblPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblPanelMain.Location = new System.Drawing.Point(0, 524);
            this.tblPanelMain.Name = "tblPanelMain";
            this.tblPanelMain.RowCount = 2;
            this.tblPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelMain.Size = new System.Drawing.Size(938, 100);
            this.tblPanelMain.TabIndex = 6;
            // 
            // tblPanelBottomRow
            // 
            this.tblPanelBottomRow.ColumnCount = 3;
            this.tblPanelBottomRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPanelBottomRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPanelBottomRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPanelBottomRow.Controls.Add(this.btnPackages, 2, 0);
            this.tblPanelBottomRow.Controls.Add(this.btnProducts, 0, 0);
            this.tblPanelBottomRow.Controls.Add(this.btnSuppliers, 1, 0);
            this.tblPanelBottomRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelBottomRow.Location = new System.Drawing.Point(3, 53);
            this.tblPanelBottomRow.Name = "tblPanelBottomRow";
            this.tblPanelBottomRow.RowCount = 1;
            this.tblPanelBottomRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelBottomRow.Size = new System.Drawing.Size(932, 44);
            this.tblPanelBottomRow.TabIndex = 5;
            // 
            // tblPanelTopRow
            // 
            this.tblPanelTopRow.BackColor = System.Drawing.Color.Chocolate;
            this.tblPanelTopRow.ColumnCount = 2;
            this.tblPanelTopRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelTopRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPanelTopRow.Controls.Add(this.lblChoose, 0, 0);
            this.tblPanelTopRow.Controls.Add(this.btnExit, 1, 0);
            this.tblPanelTopRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelTopRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblPanelTopRow.Location = new System.Drawing.Point(3, 3);
            this.tblPanelTopRow.Name = "tblPanelTopRow";
            this.tblPanelTopRow.RowCount = 1;
            this.tblPanelTopRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelTopRow.Size = new System.Drawing.Size(932, 44);
            this.tblPanelTopRow.TabIndex = 6;
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 624);
            this.Controls.Add(this.tblPanelMain);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(960, 680);
            this.Name = "StartingForm";
            this.Text = "StartingForm";
            this.tblPanelMain.ResumeLayout(false);
            this.tblPanelBottomRow.ResumeLayout(false);
            this.tblPanelBottomRow.PerformLayout();
            this.tblPanelTopRow.ResumeLayout(false);
            this.tblPanelTopRow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnPackages;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tblPanelMain;
        private System.Windows.Forms.TableLayoutPanel tblPanelBottomRow;
        private System.Windows.Forms.TableLayoutPanel tblPanelTopRow;
    }
}