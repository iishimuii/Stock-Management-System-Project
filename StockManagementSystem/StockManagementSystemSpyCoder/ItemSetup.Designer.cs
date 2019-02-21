namespace StockManagementSystemSpyCoder
{
    partial class ItemSetup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.ItemSetupSaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryItemComboBox = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockManagementSystemDataSet = new StockManagementSystemSpyCoder.StockManagementSystemDataSet();
            this.companyItemComboBox = new System.Windows.Forms.ComboBox();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockManagementSystemDataSet1 = new StockManagementSystemSpyCoder.StockManagementSystemDataSet1();
            this.categoriesTableAdapter = new StockManagementSystemSpyCoder.StockManagementSystemDataSetTableAdapters.CategoriesTableAdapter();
            this.companiesTableAdapter = new StockManagementSystemSpyCoder.StockManagementSystemDataSet1TableAdapters.CompaniesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Location = new System.Drawing.Point(294, 219);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(186, 20);
            this.reorderLevelTextBox.TabIndex = 12;
            // 
            // ItemSetupSaveButton
            // 
            this.ItemSetupSaveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ItemSetupSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemSetupSaveButton.ForeColor = System.Drawing.Color.White;
            this.ItemSetupSaveButton.Location = new System.Drawing.Point(390, 288);
            this.ItemSetupSaveButton.Name = "ItemSetupSaveButton";
            this.ItemSetupSaveButton.Size = new System.Drawing.Size(90, 31);
            this.ItemSetupSaveButton.TabIndex = 11;
            this.ItemSetupSaveButton.Text = "Save";
            this.ItemSetupSaveButton.UseVisualStyleBackColor = false;
            this.ItemSetupSaveButton.Click += new System.EventHandler(this.ItemSetupSaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reorder Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Item Name";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(294, 168);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(186, 20);
            this.itemNameTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category";
            // 
            // categoryItemComboBox
            // 
            this.categoryItemComboBox.DataSource = this.categoriesBindingSource;
            this.categoryItemComboBox.DisplayMember = "Name";
            this.categoryItemComboBox.FormattingEnabled = true;
            this.categoryItemComboBox.Location = new System.Drawing.Point(294, 81);
            this.categoryItemComboBox.Name = "categoryItemComboBox";
            this.categoryItemComboBox.Size = new System.Drawing.Size(186, 21);
            this.categoryItemComboBox.TabIndex = 13;
            this.categoryItemComboBox.ValueMember = "Id";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.stockManagementSystemDataSet;
            // 
            // stockManagementSystemDataSet
            // 
            this.stockManagementSystemDataSet.DataSetName = "StockManagementSystemDataSet";
            this.stockManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyItemComboBox
            // 
            this.companyItemComboBox.DataSource = this.companiesBindingSource;
            this.companyItemComboBox.DisplayMember = "Name";
            this.companyItemComboBox.FormattingEnabled = true;
            this.companyItemComboBox.Location = new System.Drawing.Point(294, 125);
            this.companyItemComboBox.Name = "companyItemComboBox";
            this.companyItemComboBox.Size = new System.Drawing.Size(186, 21);
            this.companyItemComboBox.TabIndex = 14;
            this.companyItemComboBox.ValueMember = "Id";
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "Companies";
            this.companiesBindingSource.DataSource = this.stockManagementSystemDataSet1;
            // 
            // stockManagementSystemDataSet1
            // 
            this.stockManagementSystemDataSet1.DataSetName = "StockManagementSystemDataSet1";
            this.stockManagementSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // companiesTableAdapter
            // 
            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // ItemSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.companyItemComboBox);
            this.Controls.Add(this.categoryItemComboBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.reorderLevelTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemSetupSaveButton);
            this.Controls.Add(this.label1);
            this.Name = "ItemSetup";
            this.Size = new System.Drawing.Size(502, 419);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.Button ItemSetupSaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryItemComboBox;
        private System.Windows.Forms.ComboBox companyItemComboBox;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private StockManagementSystemDataSet stockManagementSystemDataSet;
        private StockManagementSystemDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private StockManagementSystemDataSet1 stockManagementSystemDataSet1;
        private StockManagementSystemDataSet1TableAdapters.CompaniesTableAdapter companiesTableAdapter;

    }
}
