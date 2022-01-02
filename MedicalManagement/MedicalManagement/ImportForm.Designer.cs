
namespace MedicalManagement
{
    partial class ImportForm
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
            this.importDate = new System.Windows.Forms.DateTimePicker();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.importDataGridView = new System.Windows.Forms.DataGridView();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.proName = new System.Windows.Forms.TextBox();
            this.proID = new System.Windows.Forms.TextBox();
            this.importID = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.pronameLabel = new System.Windows.Forms.Label();
            this.pidLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.doneBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.importDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // importDate
            // 
            this.importDate.Location = new System.Drawing.Point(113, 202);
            this.importDate.Name = "importDate";
            this.importDate.Size = new System.Drawing.Size(170, 20);
            this.importDate.TabIndex = 35;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(208, 313);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 34;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(113, 313);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 33;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(22, 313);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 32;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // importDataGridView
            // 
            this.importDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.importDataGridView.Location = new System.Drawing.Point(369, 95);
            this.importDataGridView.Name = "importDataGridView";
            this.importDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.importDataGridView.Size = new System.Drawing.Size(419, 234);
            this.importDataGridView.TabIndex = 31;
            this.importDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.importDataGridView_CellClick);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(113, 267);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(79, 20);
            this.quantity.TabIndex = 30;
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
            this.quantityLabel.Location = new System.Drawing.Point(18, 267);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(77, 22);
            this.quantityLabel.TabIndex = 29;
            this.quantityLabel.Text = "Quantity";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(113, 236);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(170, 20);
            this.price.TabIndex = 28;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.priceLabel.Location = new System.Drawing.Point(18, 236);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(51, 22);
            this.priceLabel.TabIndex = 27;
            this.priceLabel.Text = "Price";
            // 
            // proName
            // 
            this.proName.Location = new System.Drawing.Point(113, 166);
            this.proName.Name = "proName";
            this.proName.Size = new System.Drawing.Size(170, 20);
            this.proName.TabIndex = 26;
            // 
            // proID
            // 
            this.proID.Location = new System.Drawing.Point(113, 131);
            this.proID.Name = "proID";
            this.proID.Size = new System.Drawing.Size(170, 20);
            this.proID.TabIndex = 25;
            // 
            // importID
            // 
            this.importID.Location = new System.Drawing.Point(113, 95);
            this.importID.Name = "importID";
            this.importID.Size = new System.Drawing.Size(170, 20);
            this.importID.TabIndex = 24;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.dateLabel.Location = new System.Drawing.Point(18, 201);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(48, 22);
            this.dateLabel.TabIndex = 23;
            this.dateLabel.Text = "Date";
            // 
            // pronameLabel
            // 
            this.pronameLabel.AutoSize = true;
            this.pronameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.pronameLabel.Location = new System.Drawing.Point(18, 166);
            this.pronameLabel.Name = "pronameLabel";
            this.pronameLabel.Size = new System.Drawing.Size(57, 22);
            this.pronameLabel.TabIndex = 22;
            this.pronameLabel.Text = "Name";
            // 
            // pidLabel
            // 
            this.pidLabel.AutoSize = true;
            this.pidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.pidLabel.Location = new System.Drawing.Point(18, 131);
            this.pidLabel.Name = "pidLabel";
            this.pidLabel.Size = new System.Drawing.Size(94, 22);
            this.pidLabel.TabIndex = 21;
            this.pidLabel.Text = "Product ID";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.idLabel.Location = new System.Drawing.Point(18, 95);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 22);
            this.idLabel.TabIndex = 20;
            this.idLabel.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label1.Location = new System.Drawing.Point(309, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 47);
            this.label1.TabIndex = 19;
            this.label1.Text = "Import form";
            // 
            // doneBtn
            // 
            this.doneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.doneBtn.Location = new System.Drawing.Point(369, 335);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 29);
            this.doneBtn.TabIndex = 36;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.importDate);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.importDataGridView);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.price);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.proName);
            this.Controls.Add(this.proID);
            this.Controls.Add(this.importID);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.pronameLabel);
            this.Controls.Add(this.pidLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.label1);
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.importDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker importDate;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView importDataGridView;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox proName;
        private System.Windows.Forms.TextBox proID;
        private System.Windows.Forms.TextBox importID;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label pronameLabel;
        private System.Windows.Forms.Label pidLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doneBtn;
    }
}