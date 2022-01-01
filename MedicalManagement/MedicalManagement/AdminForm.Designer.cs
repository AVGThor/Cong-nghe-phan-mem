
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_manageAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(993, 95);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To Admin Page";
            // 
            // btn_manageAccount
            // 
            this.btn_manageAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_manageAccount.Location = new System.Drawing.Point(88, 144);
            this.btn_manageAccount.Name = "btn_manageAccount";
            this.btn_manageAccount.Size = new System.Drawing.Size(339, 53);
            this.btn_manageAccount.TabIndex = 10;
            this.btn_manageAccount.Text = "Manage Accounts";
            this.btn_manageAccount.UseVisualStyleBackColor = true;
            this.btn_manageAccount.Click += new System.EventHandler(this.btn_manageAccount_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 692);
            this.Controls.Add(this.btn_manageAccount);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_manageAccount;
    }
}