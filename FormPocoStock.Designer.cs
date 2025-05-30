namespace proyecto_final_2._1
{
    partial class FormPocoStock
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
            this.dataGridViewPocoStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPocoStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPocoStock
            // 
            this.dataGridViewPocoStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPocoStock.Location = new System.Drawing.Point(78, 31);
            this.dataGridViewPocoStock.Name = "dataGridViewPocoStock";
            this.dataGridViewPocoStock.RowHeadersWidth = 51;
            this.dataGridViewPocoStock.RowTemplate.Height = 24;
            this.dataGridViewPocoStock.Size = new System.Drawing.Size(1016, 214);
            this.dataGridViewPocoStock.TabIndex = 0;
            // 
            // FormPocoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 330);
            this.Controls.Add(this.dataGridViewPocoStock);
            this.Name = "FormPocoStock";
            this.Text = "FormPocoStock";
            this.Load += new System.EventHandler(this.FormPocoStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPocoStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPocoStock;
    }
}