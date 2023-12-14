namespace Inventory
{
    partial class frmAddProducts
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtProductName = new TextBox();
            cbCategory = new ComboBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            txtQuantity = new TextBox();
            txtSellPrice = new TextBox();
            Description = new Label();
            gridViewProductList = new DataGridView();
            btnAddProduct = new Button();
            richTxtDescription = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 40);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 183);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 3;
            label4.Text = "Mfg. Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 233);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 4;
            label5.Text = "Exp. Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 284);
            label6.Name = "label6";
            label6.Size = new Size(45, 25);
            label6.TabIndex = 5;
            label6.Text = "Qty.";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(17, 335);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 6;
            label7.Text = "Sell Price";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductName.Location = new Point(145, 85);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(311, 33);
            txtProductName.TabIndex = 7;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(145, 131);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(311, 33);
            cbCategory.TabIndex = 8;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtPickerMfgDate.Location = new Point(145, 183);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(311, 33);
            dtPickerMfgDate.TabIndex = 9;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtPickerExpDate.Location = new Point(145, 233);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(311, 33);
            dtPickerExpDate.TabIndex = 10;
            dtPickerExpDate.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(145, 281);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(311, 33);
            txtQuantity.TabIndex = 11;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSellPrice.Location = new Point(145, 332);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(311, 33);
            txtSellPrice.TabIndex = 12;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Description.Location = new Point(492, 88);
            Description.Name = "Description";
            Description.Size = new Size(108, 25);
            Description.TabIndex = 13;
            Description.Text = "Description";
            // 
            // gridViewProductList
            // 
            gridViewProductList.BackgroundColor = SystemColors.Control;
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.GridColor = SystemColors.ActiveBorder;
            gridViewProductList.Location = new Point(17, 388);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.RowTemplate.Height = 25;
            gridViewProductList.Size = new Size(825, 254);
            gridViewProductList.TabIndex = 14;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddProduct.Location = new Point(719, 335);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(123, 47);
            btnAddProduct.TabIndex = 15;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += button1_Click;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(492, 116);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(350, 213);
            richTxtDescription.TabIndex = 16;
            richTxtDescription.Text = "";
            // 
            // frmAddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 654);
            Controls.Add(richTxtDescription);
            Controls.Add(btnAddProduct);
            Controls.Add(gridViewProductList);
            Controls.Add(Description);
            Controls.Add(txtSellPrice);
            Controls.Add(txtQuantity);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(cbCategory);
            Controls.Add(txtProductName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddProducts";
            Text = "Form1";
            Load += frmAddProducts_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtProductName;
        private ComboBox cbCategory;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private TextBox txtQuantity;
        private TextBox txtSellPrice;
        private Label Description;
        private DataGridView gridViewProductList;
        private Button btnAddProduct;
        private RichTextBox richTxtDescription;
    }
}