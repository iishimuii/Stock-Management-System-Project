namespace StockManagementSystemSpyCoder
{
    partial class SearchAndView
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
            this.searchAndViewDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReorderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyComboBoxSearch = new System.Windows.Forms.ComboBox();
            this.categoryComboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchAndViewButton = new System.Windows.Forms.Button();
            this.stockManagementSystemDataSet4 = new StockManagementSystemSpyCoder.StockManagementSystemDataSet4();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companiesTableAdapter = new StockManagementSystemSpyCoder.StockManagementSystemDataSet4TableAdapters.CompaniesTableAdapter();
            this.stockManagementSystemDataSet5 = new StockManagementSystemSpyCoder.StockManagementSystemDataSet5();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new StockManagementSystemSpyCoder.StockManagementSystemDataSet5TableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.searchAndViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchAndViewDataGridView
            // 
            this.searchAndViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchAndViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Company,
            this.Column2,
            this.AvailableQuantity,
            this.ReorderLevel});
            this.searchAndViewDataGridView.GridColor = System.Drawing.Color.White;
            this.searchAndViewDataGridView.Location = new System.Drawing.Point(69, 261);
            this.searchAndViewDataGridView.Name = "searchAndViewDataGridView";
            this.searchAndViewDataGridView.RowHeadersWidth = 31;
            this.searchAndViewDataGridView.Size = new System.Drawing.Size(562, 158);
            this.searchAndViewDataGridView.TabIndex = 62;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 200F;
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            this.Company.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // AvailableQuantity
            // 
            this.AvailableQuantity.HeaderText = "Available Quantity";
            this.AvailableQuantity.Name = "AvailableQuantity";
            // 
            // ReorderLevel
            // 
            this.ReorderLevel.HeaderText = "Reorder Level";
            this.ReorderLevel.Name = "ReorderLevel";
            // 
            // companyComboBoxSearch
            // 
            this.companyComboBoxSearch.DataSource = this.companiesBindingSource;
            this.companyComboBoxSearch.DisplayMember = "Name";
            this.companyComboBoxSearch.FormattingEnabled = true;
            this.companyComboBoxSearch.Location = new System.Drawing.Point(263, 70);
            this.companyComboBoxSearch.Name = "companyComboBoxSearch";
            this.companyComboBoxSearch.Size = new System.Drawing.Size(186, 21);
            this.companyComboBoxSearch.TabIndex = 61;
            this.companyComboBoxSearch.ValueMember = "Id";
            // 
            // categoryComboBoxSearch
            // 
            this.categoryComboBoxSearch.DataSource = this.categoriesBindingSource;
            this.categoryComboBoxSearch.DisplayMember = "Name";
            this.categoryComboBoxSearch.FormattingEnabled = true;
            this.categoryComboBoxSearch.Location = new System.Drawing.Point(263, 114);
            this.categoryComboBoxSearch.Name = "categoryComboBoxSearch";
            this.categoryComboBoxSearch.Size = new System.Drawing.Size(186, 21);
            this.categoryComboBoxSearch.TabIndex = 60;
            this.categoryComboBoxSearch.ValueMember = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Company";
            // 
            // SearchAndViewButton
            // 
            this.SearchAndViewButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SearchAndViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchAndViewButton.ForeColor = System.Drawing.Color.White;
            this.SearchAndViewButton.Location = new System.Drawing.Point(360, 183);
            this.SearchAndViewButton.Name = "SearchAndViewButton";
            this.SearchAndViewButton.Size = new System.Drawing.Size(89, 31);
            this.SearchAndViewButton.TabIndex = 56;
            this.SearchAndViewButton.Text = "Search";
            this.SearchAndViewButton.UseVisualStyleBackColor = false;
            this.SearchAndViewButton.Click += new System.EventHandler(this.SearchAndViewButton_Click);
            // 
            // stockManagementSystemDataSet4
            // 
            this.stockManagementSystemDataSet4.DataSetName = "StockManagementSystemDataSet4";
            this.stockManagementSystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "Companies";
            this.companiesBindingSource.DataSource = this.stockManagementSystemDataSet4;
            // 
            // companiesTableAdapter
            // 
            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // stockManagementSystemDataSet5
            // 
            this.stockManagementSystemDataSet5.DataSetName = "StockManagementSystemDataSet5";
            this.stockManagementSystemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.stockManagementSystemDataSet5;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // SearchAndView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchAndViewDataGridView);
            this.Controls.Add(this.companyComboBoxSearch);
            this.Controls.Add(this.categoryComboBoxSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchAndViewButton);
            this.Name = "SearchAndView";
            this.Size = new System.Drawing.Size(644, 442);
            ((System.ComponentModel.ISupportInitialize)(this.searchAndViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView searchAndViewDataGridView;
        private System.Windows.Forms.ComboBox companyComboBoxSearch;
        private System.Windows.Forms.ComboBox categoryComboBoxSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchAndViewButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReorderLevel;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private StockManagementSystemDataSet4 stockManagementSystemDataSet4;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private StockManagementSystemDataSet5 stockManagementSystemDataSet5;
        private StockManagementSystemDataSet4TableAdapters.CompaniesTableAdapter companiesTableAdapter;
        private StockManagementSystemDataSet5TableAdapters.CategoriesTableAdapter categoriesTableAdapter;
    }
}
