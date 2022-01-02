
namespace MedicalManagement
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.label1 = new System.Windows.Forms.Label();
            this.goodsReceivedBtn = new System.Windows.Forms.Button();
            this.goodsDeliveryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accountant Page";
            // 
            // goodsReceivedBtn
            // 
            this.goodsReceivedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.goodsReceivedBtn.Image = ((System.Drawing.Image)(resources.GetObject("goodsReceivedBtn.Image")));
            this.goodsReceivedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goodsReceivedBtn.Location = new System.Drawing.Point(67, 126);
            this.goodsReceivedBtn.Name = "goodsReceivedBtn";
            this.goodsReceivedBtn.Size = new System.Drawing.Size(164, 48);
            this.goodsReceivedBtn.TabIndex = 2;
            this.goodsReceivedBtn.Text = "Good Received";
            this.goodsReceivedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.goodsReceivedBtn.UseVisualStyleBackColor = true;
            this.goodsReceivedBtn.Click += new System.EventHandler(this.goodsReceivedBtn_Click);
            // 
            // goodsDeliveryBtn
            // 
            this.goodsDeliveryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.goodsDeliveryBtn.Image = ((System.Drawing.Image)(resources.GetObject("goodsDeliveryBtn.Image")));
            this.goodsDeliveryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goodsDeliveryBtn.Location = new System.Drawing.Point(67, 196);
            this.goodsDeliveryBtn.Name = "goodsDeliveryBtn";
            this.goodsDeliveryBtn.Size = new System.Drawing.Size(164, 48);
            this.goodsDeliveryBtn.TabIndex = 3;
            this.goodsDeliveryBtn.Text = "Good Delivery";
            this.goodsDeliveryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.goodsDeliveryBtn.UseVisualStyleBackColor = true;
            this.goodsDeliveryBtn.Click += new System.EventHandler(this.goodsDeliveryBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 562);
            this.Controls.Add(this.goodsDeliveryBtn);
            this.Controls.Add(this.goodsReceivedBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goodsReceivedBtn;
        private System.Windows.Forms.Button goodsDeliveryBtn;
    }
}