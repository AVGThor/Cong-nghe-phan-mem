
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
            this.button1 = new System.Windows.Forms.Button();
            this.productManagementBtn = new System.Windows.Forms.Button();
            this.agentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.label1.Location = new System.Drawing.Point(269, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 95);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accountant Page";
            // 
            // goodsReceivedBtn
            // 
            this.goodsReceivedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.goodsReceivedBtn.Image = ((System.Drawing.Image)(resources.GetObject("goodsReceivedBtn.Image")));
            this.goodsReceivedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goodsReceivedBtn.Location = new System.Drawing.Point(176, 155);
            this.goodsReceivedBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.goodsReceivedBtn.Name = "goodsReceivedBtn";
            this.goodsReceivedBtn.Size = new System.Drawing.Size(239, 59);
            this.goodsReceivedBtn.TabIndex = 2;
            this.goodsReceivedBtn.Text = "Goods Received";
            this.goodsReceivedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.goodsReceivedBtn.UseVisualStyleBackColor = true;
            this.goodsReceivedBtn.Click += new System.EventHandler(this.goodsReceivedBtn_Click);
            // 
            // goodsDeliveryBtn
            // 
            this.goodsDeliveryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.goodsDeliveryBtn.Image = ((System.Drawing.Image)(resources.GetObject("goodsDeliveryBtn.Image")));
            this.goodsDeliveryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goodsDeliveryBtn.Location = new System.Drawing.Point(176, 236);
            this.goodsDeliveryBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.goodsDeliveryBtn.Name = "goodsDeliveryBtn";
            this.goodsDeliveryBtn.Size = new System.Drawing.Size(239, 59);
            this.goodsDeliveryBtn.TabIndex = 3;
            this.goodsDeliveryBtn.Text = "Goods Delivery";
            this.goodsDeliveryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.goodsDeliveryBtn.UseVisualStyleBackColor = true;
            this.goodsDeliveryBtn.Click += new System.EventHandler(this.goodsDeliveryBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(757, 155);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "Statistics";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productManagementBtn
            // 
            this.productManagementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.productManagementBtn.Image = ((System.Drawing.Image)(resources.GetObject("productManagementBtn.Image")));
            this.productManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productManagementBtn.Location = new System.Drawing.Point(176, 319);
            this.productManagementBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productManagementBtn.Name = "productManagementBtn";
            this.productManagementBtn.Size = new System.Drawing.Size(291, 59);
            this.productManagementBtn.TabIndex = 5;
            this.productManagementBtn.Text = "Product Management";
            this.productManagementBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.productManagementBtn.UseVisualStyleBackColor = true;
            this.productManagementBtn.Click += new System.EventHandler(this.productManagementBtn_Click);
            // 
            // agentBtn
            // 
            this.agentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.agentBtn.Image = ((System.Drawing.Image)(resources.GetObject("agentBtn.Image")));
            this.agentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agentBtn.Location = new System.Drawing.Point(757, 236);
            this.agentBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.agentBtn.Name = "agentBtn";
            this.agentBtn.Size = new System.Drawing.Size(180, 59);
            this.agentBtn.TabIndex = 6;
            this.agentBtn.Text = "Agents List";
            this.agentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agentBtn.UseVisualStyleBackColor = true;
            this.agentBtn.Click += new System.EventHandler(this.agentBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 692);
            this.Controls.Add(this.agentBtn);
            this.Controls.Add(this.productManagementBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.goodsDeliveryBtn);
            this.Controls.Add(this.goodsReceivedBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.Text = "Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goodsReceivedBtn;
        private System.Windows.Forms.Button goodsDeliveryBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button productManagementBtn;
        private System.Windows.Forms.Button agentBtn;
    }
}