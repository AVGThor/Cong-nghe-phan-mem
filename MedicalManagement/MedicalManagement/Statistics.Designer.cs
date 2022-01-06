
namespace MedicalManagement
{
    partial class Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.label1 = new System.Windows.Forms.Label();
            this.importBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.outputBtn = new System.Windows.Forms.Button();
            this.revenueBtn = new System.Windows.Forms.Button();
            this.month = new System.Windows.Forms.NumericUpDown();
            this.monthLabel = new System.Windows.Forms.Label();
            this.doneBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.month)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label1.Location = new System.Drawing.Point(384, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 59);
            this.label1.TabIndex = 20;
            this.label1.Text = "Statistics";
            // 
            // importBtn
            // 
            this.importBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.importBtn.Image = ((System.Drawing.Image)(resources.GetObject("importBtn.Image")));
            this.importBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importBtn.Location = new System.Drawing.Point(211, 382);
            this.importBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(219, 59);
            this.importBtn.TabIndex = 21;
            this.importBtn.Text = "Import history";
            this.importBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(211, 86);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(825, 288);
            this.dataGridView.TabIndex = 32;
            // 
            // outputBtn
            // 
            this.outputBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.outputBtn.Image = ((System.Drawing.Image)(resources.GetObject("outputBtn.Image")));
            this.outputBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.outputBtn.Location = new System.Drawing.Point(453, 382);
            this.outputBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputBtn.Name = "outputBtn";
            this.outputBtn.Size = new System.Drawing.Size(219, 59);
            this.outputBtn.TabIndex = 33;
            this.outputBtn.Text = "Export history";
            this.outputBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.outputBtn.UseVisualStyleBackColor = true;
            this.outputBtn.Click += new System.EventHandler(this.outputBtn_Click);
            // 
            // revenueBtn
            // 
            this.revenueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.revenueBtn.Image = ((System.Drawing.Image)(resources.GetObject("revenueBtn.Image")));
            this.revenueBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.revenueBtn.Location = new System.Drawing.Point(695, 382);
            this.revenueBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.revenueBtn.Name = "revenueBtn";
            this.revenueBtn.Size = new System.Drawing.Size(156, 59);
            this.revenueBtn.TabIndex = 34;
            this.revenueBtn.Text = "Revenue";
            this.revenueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.revenueBtn.UseVisualStyleBackColor = true;
            this.revenueBtn.Click += new System.EventHandler(this.revenueBtn_Click);
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(104, 404);
            this.month.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.month.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(71, 22);
            this.month.TabIndex = 35;
            this.month.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.month.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.monthLabel.Location = new System.Drawing.Point(16, 401);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(79, 29);
            this.monthLabel.TabIndex = 36;
            this.monthLabel.Text = "Month";
            // 
            // doneBtn
            // 
            this.doneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.doneBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doneBtn.Location = new System.Drawing.Point(915, 382);
            this.doneBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(121, 59);
            this.doneBtn.TabIndex = 37;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.month);
            this.Controls.Add(this.revenueBtn);
            this.Controls.Add(this.outputBtn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.month)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button outputBtn;
        private System.Windows.Forms.Button revenueBtn;
        private System.Windows.Forms.NumericUpDown month;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Button doneBtn;
    }
}