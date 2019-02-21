namespace StockManagementSystemSpyCoder
{
    partial class StockIn
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
            this.companyStockInComboBox = new System.Windows.Forms.ComboBox();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockManagementSystemDataSet2 = new StockManagementSystemSpyCoder.StockManagementSystemDataSet2();
            this.itemStockInComboBox = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockManagementSystemDataSet3 = new StockManagementSystemSpyCoder.StockManagementSystemDataSet3();
            this.stockInQuantityTextBox = new System.Windows.Forms.TextBox();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StockInSaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.avalibleQuantityTextBox = new System.Windows.Forms.TextBox();
            this.companiesTableAdapter = new StockManagementSystemSpyCoder.StockManagementSystemDataSet2TableAdapters.CompaniesTableAdapter();
            this.itemsTableAdapter = new StockManagementSystemSpyCoder.StockManagementSystemDataSet3TableAdapters.ItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // companyStockInComboBox
            // 
            this.companyStockInComboBox.DataSource = this.companiesBindingSource;
            this.companyStockInComboBox.DisplayMember = "Name";
            this.companyStockInComboBox.FormattingEnabled = true;
            this.companyStockInComboBox.Location = new System.Drawing.Point(290, 74);
            this.companyStockInComboBox.Name = "companyStockInComboBox";
            this.companyStockInComboBox.Size = new System.Drawing.Size(186, 21);
            this.companyStockInComboBox.TabIndex = 27;
            this.companyStockInComboBox.ValueMember = "Id";
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "Companies";
            this.companiesBindingSource.DataSource = this.stockManagementSystemDataSet2;
            // 
            // stockManagementSystemDataSet2
            // 
            this.stockManagementSystemDataSet2.DataSetName = "StockManagementSystemDataSet2";
            this.stockManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemStockInComboBox
            // 
            this.itemStockInComboBox.DataSource = this.itemsBindingSource;
            this.itemStockInComboBox.DisplayMember = "Name";
            this.itemStockInComboBox.FormattingEnabled = true;
            this.itemStockInComboBox.Location = new System.Drawing.Point(290, 118);
            this.itemStockInComboBox.Name = "itemStockInComboBox";
            this.itemStockInComboBox.Size = new System.Drawing.Size(186, 21);
            this.itemStockInComboBox.TabIndex = 26;
            this.itemStockInComboBox.ValueMember = "Id";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.stockManagementSystemDataSet3;
            // 
            // stockManagementSystemDataSet3
            // 
            this.stockManagementSystemDataSet3.DataSetName = "StockManagementSystemDataSet3";
            this.stockManagementSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockInQuantityTextBox
            // 
            this.stockInQuantityTextBox.Location = new System.Drawing.Point(290, 242);
            this.stockInQuantityTextBox.Name = "stockInQuantityTextBox";
            this.stockInQuantityTextBox.Size = new System.Drawing.Size(186, 20);
            this.stockInQuantityTextBox.TabIndex = 24;
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Location = new System.Drawing.Point(290, 163);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(186, 20);
            this.reorderLevelTextBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Stock In Quantity";
            // 
            // StockInSaveButton
            // 
            this.StockInSaveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.StockInSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockInSaveButton.ForeColor = System.Drawing.Color.White;
            this.StockInSaveButton.Location = new System.Drawing.Point(382, 320);
            this.StockInSaveButton.Name = "StockInSaveButton";
            this.StockInSaveButton.Size = new System.Drawing.Size(94, 32);
            this.StockInSaveButton.TabIndex = 23;
            this.StockInSaveButton.Text = "Save";
            this.StockInSaveButton.UseVisualStyleBackColor = false;
            this.StockInSaveButton.Click += new System.EventHandler(this.StockInSaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Reorder Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Avalible Quantity";
            // 
            // avalibleQuantityTextBox
            // 
            this.avalibleQuantityTextBox.Location = new System.Drawing.Point(290, 204);
            this.avalibleQuantityTextBox.Name = "avalibleQuantityTextBox";
            this.avalibleQuantityTextBox.Size = new System.Drawing.Size(186, 20);
            this.avalibleQuantityTextBox.TabIndex = 24;
            // 
            // companiesTableAdapter
            // 
            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // StockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.companyStockInComboBox);
            this.Controls.Add(this.itemStockInComboBox);
            this.Controls.Add(this.avalibleQuantityTextBox);
            this.Controls.Add(this.stockInQuantityTextBox);
            this.Controls.Add(this.reorderLevelTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StockInSaveButton);
            this.Controls.Add(this.label1);
            this.Name = "StockIn";
            this.Size = new System.Drawing.Size(500, 405);
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox companyStockInComboBox;
        private System.Windows.Forms.ComboBox itemStockInComboBox;
        private System.Windows.Forms.TextBox stockInQuantityTextBox;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StockInSaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox avalibleQuantityTextBox;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private StockManagementSystemDataSet2 stockManagementSystemDataSet2;
        private StockManagementSystemDataSet2TableAdapters.CompaniesTableAdapter companiesTableAdapter;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private StockManagementSystemDataSet3 stockManagementSystemDataSet3;
        private StockManagementSystemDataSet3TableAdapters.ItemsTableAdapter itemsTableAdapter;
    }
}
