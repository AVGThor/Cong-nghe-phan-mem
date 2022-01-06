
namespace MedicalManagement
{
    partial class ExportForm
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
            this.exportDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.paymentStatus = new System.Windows.Forms.ComboBox();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.deliverStatus = new System.Windows.Forms.ComboBox();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.exportDate = new System.Windows.Forms.DateTimePicker();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.proName = new System.Windows.Forms.TextBox();
            this.proID = new System.Windows.Forms.TextBox();
            this.exportID = new System.Windows.Forms.TextBox();
            this.exportDateLabel = new System.Windows.Forms.Label();
            this.proNameLabel = new System.Windows.Forms.Label();
            this.proIDLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.doneBtn = new System.Windows.Forms.Button();
            this.agentIDLabel = new System.Windows.Forms.Label();
            this.agentID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.exportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // exportDataGridView
            // 
            this.exportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exportDataGridView.Location = new System.Drawing.Point(360, 82);
            this.exportDataGridView.Name = "exportDataGridView";
            this.exportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.exportDataGridView.Size = new System.Drawing.Size(419, 234);
            this.exportDataGridView.TabIndex = 60;
            this.exportDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.exportDataGridView_CellClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(223, 393);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 59;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(131, 393);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 58;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(40, 393);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 57;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // paymentStatus
            // 
            this.paymentStatus.FormattingEnabled = true;
            this.paymentStatus.Items.AddRange(new object[] {
            "UNFINISHED",
            "PAID"});
            this.paymentStatus.Location = new System.Drawing.Point(177, 357);
            this.paymentStatus.Name = "paymentStatus";
            this.paymentStatus.Size = new System.Drawing.Size(121, 21);
            this.paymentStatus.TabIndex = 56;
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.paymentLabel.Location = new System.Drawing.Point(33, 357);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(133, 22);
            this.paymentLabel.TabIndex = 55;
            this.paymentLabel.Text = "Payment status";
            // 
            // deliverStatus
            // 
            this.deliverStatus.FormattingEnabled = true;
            this.deliverStatus.Items.AddRange(new object[] {
            "DELIVERING",
            "DELIVERED"});
            this.deliverStatus.Location = new System.Drawing.Point(177, 323);
            this.deliverStatus.Name = "deliverStatus";
            this.deliverStatus.Size = new System.Drawing.Size(121, 21);
            this.deliverStatus.TabIndex = 54;
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.deliveryLabel.Location = new System.Drawing.Point(33, 323);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(128, 22);
            this.deliveryLabel.TabIndex = 53;
            this.deliveryLabel.Text = "Delivery status";
            // 
            // exportDate
            // 
            this.exportDate.Location = new System.Drawing.Point(128, 221);
            this.exportDate.Name = "exportDate";
            this.exportDate.Size = new System.Drawing.Size(170, 20);
            this.exportDate.TabIndex = 52;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(128, 252);
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
            this.quantity.TabIndex = 51;
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
            this.quantityLabel.Location = new System.Drawing.Point(33, 252);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(77, 22);
            this.quantityLabel.TabIndex = 50;
            this.quantityLabel.Text = "Quantity";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(128, 284);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(170, 20);
            this.price.TabIndex = 49;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.priceLabel.Location = new System.Drawing.Point(33, 284);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(51, 22);
            this.priceLabel.TabIndex = 48;
            this.priceLabel.Text = "Price";
            // 
            // proName
            // 
            this.proName.Location = new System.Drawing.Point(128, 153);
            this.proName.Name = "proName";
            this.proName.Size = new System.Drawing.Size(170, 20);
            this.proName.TabIndex = 47;
            // 
            // proID
            // 
            this.proID.Location = new System.Drawing.Point(128, 118);
            this.proID.Name = "proID";
            this.proID.Size = new System.Drawing.Size(170, 20);
            this.proID.TabIndex = 46;
            // 
            // exportID
            // 
            this.exportID.Location = new System.Drawing.Point(128, 82);
            this.exportID.Name = "exportID";
            this.exportID.Size = new System.Drawing.Size(170, 20);
            this.exportID.TabIndex = 45;
            // 
            // exportDateLabel
            // 
            this.exportDateLabel.AutoSize = true;
            this.exportDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.exportDateLabel.Location = new System.Drawing.Point(33, 220);
            this.exportDateLabel.Name = "exportDateLabel";
            this.exportDateLabel.Size = new System.Drawing.Size(48, 22);
            this.exportDateLabel.TabIndex = 44;
            this.exportDateLabel.Text = "Date";
            // 
            // proNameLabel
            // 
            this.proNameLabel.AutoSize = true;
            this.proNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.proNameLabel.Location = new System.Drawing.Point(33, 153);
            this.proNameLabel.Name = "proNameLabel";
            this.proNameLabel.Size = new System.Drawing.Size(57, 22);
            this.proNameLabel.TabIndex = 43;
            this.proNameLabel.Text = "Name";
            // 
            // proIDLabel
            // 
            this.proIDLabel.AutoSize = true;
            this.proIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.proIDLabel.Location = new System.Drawing.Point(33, 118);
            this.proIDLabel.Name = "proIDLabel";
            this.proIDLabel.Size = new System.Drawing.Size(94, 22);
            this.proIDLabel.TabIndex = 42;
            this.proIDLabel.Text = "Product ID";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.idLabel.Location = new System.Drawing.Point(33, 82);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 22);
            this.idLabel.TabIndex = 41;
            this.idLabel.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label1.Location = new System.Drawing.Point(271, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 47);
            this.label1.TabIndex = 40;
            this.label1.Text = "Export form";
            // 
            // doneBtn
            // 
            this.doneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.doneBtn.Location = new System.Drawing.Point(360, 325);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 33);
            this.doneBtn.TabIndex = 61;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // agentIDLabel
            // 
            this.agentIDLabel.AutoSize = true;
            this.agentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.agentIDLabel.Location = new System.Drawing.Point(33, 186);
            this.agentIDLabel.Name = "agentIDLabel";
            this.agentIDLabel.Size = new System.Drawing.Size(79, 22);
            this.agentIDLabel.TabIndex = 62;
            this.agentIDLabel.Text = "Agent ID";
            // 
            // agentID
            // 
            this.agentID.Location = new System.Drawing.Point(128, 186);
            this.agentID.Name = "agentID";
            this.agentID.Size = new System.Drawing.Size(170, 20);
            this.agentID.TabIndex = 63;
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.agentID);
            this.Controls.Add(this.agentIDLabel);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.exportDataGridView);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.paymentStatus);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.deliverStatus);
            this.Controls.Add(this.deliveryLabel);
            this.Controls.Add(this.exportDate);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.price);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.proName);
            this.Controls.Add(this.proID);
            this.Controls.Add(this.exportID);
            this.Controls.Add(this.exportDateLabel);
            this.Controls.Add(this.proNameLabel);
            this.Controls.Add(this.proIDLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.label1);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.Load += new System.EventHandler(this.ExportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView exportDataGridView;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox paymentStatus;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.ComboBox deliverStatus;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.DateTimePicker exportDate;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox proName;
        private System.Windows.Forms.TextBox proID;
        private System.Windows.Forms.TextBox exportID;
        private System.Windows.Forms.Label exportDateLabel;
        private System.Windows.Forms.Label proNameLabel;
        private System.Windows.Forms.Label proIDLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Label agentIDLabel;
        private System.Windows.Forms.TextBox agentID;
    }
}