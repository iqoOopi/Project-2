namespace AllWindowsForms
{
    partial class SupplierEditAddForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierEditAddForm));
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.suppliersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.suppliersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.txtSupConFirstName = new System.Windows.Forms.TextBox();
            this.txtSupConCompany = new System.Windows.Forms.TextBox();
            this.txtSupConLastName = new System.Windows.Forms.TextBox();
            this.txtSupConCity = new System.Windows.Forms.TextBox();
            this.txtSupConProv = new System.Windows.Forms.TextBox();
            this.txtSupConAddress = new System.Windows.Forms.TextBox();
            this.txtSupConPostal = new System.Windows.Forms.TextBox();
            this.lablel1 = new System.Windows.Forms.Label();
            this.lablel2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSupConURL = new System.Windows.Forms.TextBox();
            this.txtSupConEmail = new System.Windows.Forms.TextBox();
            this.txtSupConBusPhone = new System.Windows.Forms.TextBox();
            this.txtSupConFax = new System.Windows.Forms.TextBox();
            this.txtSupConCountry = new System.Windows.Forms.TextBox();
            this.cmbAffiliationID = new System.Windows.Forms.ComboBox();
            this.supplierContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.affiliationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSupplierId = new System.Windows.Forms.ComboBox();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingNavigator)).BeginInit();
            this.suppliersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierContactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affiliationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // suppliersBindingNavigatorSaveItem
            // 
            this.suppliersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.suppliersBindingNavigatorSaveItem.Enabled = false;
            this.suppliersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("suppliersBindingNavigatorSaveItem.Image")));
            this.suppliersBindingNavigatorSaveItem.Name = "suppliersBindingNavigatorSaveItem";
            this.suppliersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.suppliersBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // suppliersBindingNavigator
            // 
            this.suppliersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.suppliersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.suppliersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.suppliersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.suppliersBindingNavigatorSaveItem});
            this.suppliersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.suppliersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.suppliersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.suppliersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.suppliersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.suppliersBindingNavigator.Name = "suppliersBindingNavigator";
            this.suppliersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.suppliersBindingNavigator.Size = new System.Drawing.Size(633, 25);
            this.suppliersBindingNavigator.TabIndex = 7;
            this.suppliersBindingNavigator.Text = "bindingNavigator1";
            // 
            // txtSupConFirstName
            // 
            this.txtSupConFirstName.Location = new System.Drawing.Point(134, 72);
            this.txtSupConFirstName.Name = "txtSupConFirstName";
            this.txtSupConFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtSupConFirstName.TabIndex = 8;
            // 
            // txtSupConCompany
            // 
            this.txtSupConCompany.Location = new System.Drawing.Point(134, 124);
            this.txtSupConCompany.Name = "txtSupConCompany";
            this.txtSupConCompany.Size = new System.Drawing.Size(100, 20);
            this.txtSupConCompany.TabIndex = 9;
            // 
            // txtSupConLastName
            // 
            this.txtSupConLastName.Location = new System.Drawing.Point(134, 98);
            this.txtSupConLastName.Name = "txtSupConLastName";
            this.txtSupConLastName.Size = new System.Drawing.Size(100, 20);
            this.txtSupConLastName.TabIndex = 10;
            // 
            // txtSupConCity
            // 
            this.txtSupConCity.Location = new System.Drawing.Point(134, 176);
            this.txtSupConCity.Name = "txtSupConCity";
            this.txtSupConCity.Size = new System.Drawing.Size(100, 20);
            this.txtSupConCity.TabIndex = 13;
            // 
            // txtSupConProv
            // 
            this.txtSupConProv.Location = new System.Drawing.Point(134, 202);
            this.txtSupConProv.Name = "txtSupConProv";
            this.txtSupConProv.Size = new System.Drawing.Size(100, 20);
            this.txtSupConProv.TabIndex = 12;
            // 
            // txtSupConAddress
            // 
            this.txtSupConAddress.Location = new System.Drawing.Point(134, 150);
            this.txtSupConAddress.Name = "txtSupConAddress";
            this.txtSupConAddress.Size = new System.Drawing.Size(100, 20);
            this.txtSupConAddress.TabIndex = 11;
            // 
            // txtSupConPostal
            // 
            this.txtSupConPostal.Location = new System.Drawing.Point(134, 228);
            this.txtSupConPostal.Name = "txtSupConPostal";
            this.txtSupConPostal.Size = new System.Drawing.Size(100, 20);
            this.txtSupConPostal.TabIndex = 14;
            // 
            // lablel1
            // 
            this.lablel1.AutoSize = true;
            this.lablel1.Location = new System.Drawing.Point(20, 75);
            this.lablel1.Name = "lablel1";
            this.lablel1.Size = new System.Drawing.Size(92, 13);
            this.lablel1.TabIndex = 15;
            this.lablel1.Text = "SupConFirstName";
            // 
            // lablel2
            // 
            this.lablel2.AutoSize = true;
            this.lablel2.Location = new System.Drawing.Point(20, 105);
            this.lablel2.Name = "lablel2";
            this.lablel2.Size = new System.Drawing.Size(93, 13);
            this.lablel2.TabIndex = 16;
            this.lablel2.Text = "SupConLastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "SupConCompany";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "SupConProv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "SupConCity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "SupConAddress";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "SupConPostal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Supplier Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Affiliation Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "SupConURL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "SupConEmail";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(293, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "SupConFax";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(293, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "SupConBusPhone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(293, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "SupConCountry";
            // 
            // txtSupConURL
            // 
            this.txtSupConURL.Location = new System.Drawing.Point(407, 176);
            this.txtSupConURL.Name = "txtSupConURL";
            this.txtSupConURL.Size = new System.Drawing.Size(100, 20);
            this.txtSupConURL.TabIndex = 27;
            // 
            // txtSupConEmail
            // 
            this.txtSupConEmail.Location = new System.Drawing.Point(407, 150);
            this.txtSupConEmail.Name = "txtSupConEmail";
            this.txtSupConEmail.Size = new System.Drawing.Size(100, 20);
            this.txtSupConEmail.TabIndex = 25;
            // 
            // txtSupConBusPhone
            // 
            this.txtSupConBusPhone.Location = new System.Drawing.Point(407, 98);
            this.txtSupConBusPhone.Name = "txtSupConBusPhone";
            this.txtSupConBusPhone.Size = new System.Drawing.Size(100, 20);
            this.txtSupConBusPhone.TabIndex = 24;
            // 
            // txtSupConFax
            // 
            this.txtSupConFax.Location = new System.Drawing.Point(407, 124);
            this.txtSupConFax.Name = "txtSupConFax";
            this.txtSupConFax.Size = new System.Drawing.Size(100, 20);
            this.txtSupConFax.TabIndex = 23;
            // 
            // txtSupConCountry
            // 
            this.txtSupConCountry.Location = new System.Drawing.Point(407, 72);
            this.txtSupConCountry.Name = "txtSupConCountry";
            this.txtSupConCountry.Size = new System.Drawing.Size(100, 20);
            this.txtSupConCountry.TabIndex = 22;
            // 
            // cmbAffiliationID
            // 
            this.cmbAffiliationID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplierContactBindingSource, "AffiliationID", true));
            this.cmbAffiliationID.DataSource = this.affiliationsBindingSource;
            this.cmbAffiliationID.DisplayMember = "AffName";
            this.cmbAffiliationID.FormattingEnabled = true;
            this.cmbAffiliationID.Location = new System.Drawing.Point(407, 201);
            this.cmbAffiliationID.Name = "cmbAffiliationID";
            this.cmbAffiliationID.Size = new System.Drawing.Size(100, 21);
            this.cmbAffiliationID.TabIndex = 36;
            this.cmbAffiliationID.ValueMember = "AffiliationId";
            // 
            // supplierContactBindingSource
            // 
            this.supplierContactBindingSource.DataSource = typeof(ClassLibary.SupplierContacts);
            // 
            // affiliationsBindingSource
            // 
            this.affiliationsBindingSource.DataSource = typeof(ClassLibary.Affiliations);
            // 
            // cmbSupplierId
            // 
            this.cmbSupplierId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplierContactBindingSource, "SupplierId", true));
            this.cmbSupplierId.DataSource = this.suppliersBindingSource;
            this.cmbSupplierId.DisplayMember = "SupName";
            this.cmbSupplierId.FormattingEnabled = true;
            this.cmbSupplierId.Location = new System.Drawing.Point(407, 227);
            this.cmbSupplierId.Name = "cmbSupplierId";
            this.cmbSupplierId.Size = new System.Drawing.Size(100, 21);
            this.cmbSupplierId.TabIndex = 37;
            this.cmbSupplierId.ValueMember = "SupplierId";
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataSource = typeof(ClassLibrary.Suppliers);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(546, 121);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 38;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(546, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SupplierEditAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 272);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cmbSupplierId);
            this.Controls.Add(this.cmbAffiliationID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSupConURL);
            this.Controls.Add(this.txtSupConEmail);
            this.Controls.Add(this.txtSupConBusPhone);
            this.Controls.Add(this.txtSupConFax);
            this.Controls.Add(this.txtSupConCountry);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lablel2);
            this.Controls.Add(this.lablel1);
            this.Controls.Add(this.txtSupConPostal);
            this.Controls.Add(this.txtSupConCity);
            this.Controls.Add(this.txtSupConProv);
            this.Controls.Add(this.txtSupConAddress);
            this.Controls.Add(this.txtSupConLastName);
            this.Controls.Add(this.txtSupConCompany);
            this.Controls.Add(this.txtSupConFirstName);
            this.Controls.Add(this.suppliersBindingNavigator);
            this.Name = "SupplierEditAddForm";
            this.Text = "SupplierEditAddForm";
            this.Load += new System.EventHandler(this.SupplierEditAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingNavigator)).EndInit();
            this.suppliersBindingNavigator.ResumeLayout(false);
            this.suppliersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierContactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affiliationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton suppliersBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator suppliersBindingNavigator;
        private System.Windows.Forms.TextBox txtSupConFirstName;
        private System.Windows.Forms.TextBox txtSupConCompany;
        private System.Windows.Forms.TextBox txtSupConLastName;
        private System.Windows.Forms.TextBox txtSupConCity;
        private System.Windows.Forms.TextBox txtSupConProv;
        private System.Windows.Forms.TextBox txtSupConAddress;
        private System.Windows.Forms.TextBox txtSupConPostal;
        private System.Windows.Forms.Label lablel1;
        private System.Windows.Forms.Label lablel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSupConURL;
        private System.Windows.Forms.TextBox txtSupConEmail;
        private System.Windows.Forms.TextBox txtSupConBusPhone;
        private System.Windows.Forms.TextBox txtSupConFax;
        private System.Windows.Forms.TextBox txtSupConCountry;
        private System.Windows.Forms.ComboBox cmbAffiliationID;
        private System.Windows.Forms.ComboBox cmbSupplierId;
        private System.Windows.Forms.BindingSource supplierContactBindingSource;
        private System.Windows.Forms.BindingSource affiliationsBindingSource;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}