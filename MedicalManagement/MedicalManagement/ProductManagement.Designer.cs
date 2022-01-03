
namespace MedicalManagement
{
    partial class ProductManagement
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.proName = new System.Windows.Forms.TextBox();
            this.proID = new System.Windows.Forms.TextBox();
            this.pronameLabel = new System.Windows.Forms.Label();
            this.pidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label1.Location = new System.Drawing.Point(196, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 47);
            this.label1.TabIndex = 21;
            this.label1.Text = "Product Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(223, 266);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 51;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(128, 266);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 50;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(37, 266);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 49;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(362, 91);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(423, 234);
            this.productDataGridView.TabIndex = 48;
            this.productDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellClick);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(128, 227);
            this.quantity.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(79, 20);
            this.quantity.TabIndex = 47;
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.quantityLabel.Location = new System.Drawing.Point(33, 227);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(77, 22);
            this.quantityLabel.TabIndex = 46;
            this.quantityLabel.Text = "Quantity";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(128, 196);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(170, 20);
            this.price.TabIndex = 45;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.priceLabel.Location = new System.Drawing.Point(33, 196);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(51, 22);
            this.priceLabel.TabIndex = 44;
            this.priceLabel.Text = "Price";
            // 
            // proName
            // 
            this.proName.Location = new System.Drawing.Point(128, 160);
            this.proName.Name = "proName";
            this.proName.Size = new System.Drawing.Size(170, 20);
            this.proName.TabIndex = 43;
            // 
            // proID
            // 
            this.proID.Location = new System.Drawing.Point(128, 125);
            this.proID.Name = "proID";
            this.proID.Size = new System.Drawing.Size(170, 20);
            this.proID.TabIndex = 42;
            // 
            // pronameLabel
            // 
            this.pronameLabel.AutoSize = true;
            this.pronameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.pronameLabel.Location = new System.Drawing.Point(33, 160);
            this.pronameLabel.Name = "pronameLabel";
            this.pronameLabel.Size = new System.Drawing.Size(57, 22);
            this.pronameLabel.TabIndex = 39;
            this.pronameLabel.Text = "Name";
            // 
            // pidLabel
            // 
            this.pidLabel.AutoSize = true;
            this.pidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.pidLabel.Location = new System.Drawing.Point(33, 125);
            this.pidLabel.Name = "pidLabel";
            this.pidLabel.Size = new System.Drawing.Size(94, 22);
            this.pidLabel.TabIndex = 38;
            this.pidLabel.Text = "Product ID";
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.price);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.proName);
            this.Controls.Add(this.proID);
            this.Controls.Add(this.pronameLabel);
            this.Controls.Add(this.pidLabel);
            this.Controls.Add(this.label1);
            this.Name = "ProductManagement";
            this.Text = "ProductManagement";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox proName;
        private System.Windows.Forms.TextBox proID;
        private System.Windows.Forms.Label pronameLabel;
        private System.Windows.Forms.Label pidLabel;
    }
}