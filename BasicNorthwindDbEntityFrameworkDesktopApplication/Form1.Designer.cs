namespace BasicNorthwindDbEntityFrameworkDesktopApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategoryName = new System.Windows.Forms.ComboBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSerachProductName = new System.Windows.Forms.TextBox();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.btnListAllProducts = new System.Windows.Forms.Button();
            this.gbxCategory.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategoryName);
            this.gbxCategory.Controls.Add(this.lblCategoryName);
            this.gbxCategory.Location = new System.Drawing.Point(16, 10);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(422, 79);
            this.gbxCategory.TabIndex = 0;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "List To Category";
            // 
            // cbxCategoryName
            // 
            this.cbxCategoryName.FormattingEnabled = true;
            this.cbxCategoryName.Location = new System.Drawing.Point(103, 29);
            this.cbxCategoryName.Name = "cbxCategoryName";
            this.cbxCategoryName.Size = new System.Drawing.Size(313, 23);
            this.cbxCategoryName.TabIndex = 1;
            this.cbxCategoryName.SelectedIndexChanged += new System.EventHandler(this.cbxCategoryName_SelectedIndexChanged);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(14, 32);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(58, 15);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "Category:";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSerachProductName);
            this.gbxSearch.Location = new System.Drawing.Point(524, 10);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(380, 79);
            this.gbxSearch.TabIndex = 1;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search Of Product Name";
            // 
            // tbxSerachProductName
            // 
            this.tbxSerachProductName.Location = new System.Drawing.Point(151, 30);
            this.tbxSerachProductName.Name = "tbxSerachProductName";
            this.tbxSerachProductName.Size = new System.Drawing.Size(223, 23);
            this.tbxSerachProductName.TabIndex = 3;
            this.tbxSerachProductName.TextChanged += new System.EventHandler(this.tbxSerachProductName_TextChanged);
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(15, 100);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowTemplate.Height = 25;
            this.dgwProducts.Size = new System.Drawing.Size(889, 262);
            this.dgwProducts.TabIndex = 2;
            this.dgwProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellContentClick);
            // 
            // btnListAllProducts
            // 
            this.btnListAllProducts.Location = new System.Drawing.Point(443, 42);
            this.btnListAllProducts.Name = "btnListAllProducts";
            this.btnListAllProducts.Size = new System.Drawing.Size(75, 47);
            this.btnListAllProducts.TabIndex = 3;
            this.btnListAllProducts.Text = "List All Products";
            this.btnListAllProducts.UseVisualStyleBackColor = true;
            this.btnListAllProducts.Click += new System.EventHandler(this.btnListAllProducts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 500);
            this.Controls.Add(this.btnListAllProducts);
            this.Controls.Add(this.dgwProducts);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxCategory);
            this.Name = "Form1";
            this.Text = "Northwind Entity Framework Basic Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbxCategory;
        private ComboBox cbxCategoryName;
        private Label lblCategoryName;
        private GroupBox gbxSearch;
        private TextBox tbxSerachProductName;
        private DataGridView dgwProducts;
        private Button btnListAllProducts;
    }
}