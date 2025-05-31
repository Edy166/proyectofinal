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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPocoStock));
            this.dataGridViewPocoStock = new System.Windows.Forms.DataGridView();
            this.picVolverMenu = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPocoStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolverMenu)).BeginInit();
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
            // picVolverMenu
            // 
            this.picVolverMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picVolverMenu.Image = global::proyecto_final_2._1.Properties.Resources.fire_exit_emergency_door_icon_196812;
            this.picVolverMenu.Location = new System.Drawing.Point(12, 12);
            this.picVolverMenu.Name = "picVolverMenu";
            this.picVolverMenu.Size = new System.Drawing.Size(49, 42);
            this.picVolverMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVolverMenu.TabIndex = 1;
            this.picVolverMenu.TabStop = false;
            this.picVolverMenu.Click += new System.EventHandler(this.picVolverMenu_Click);
            // 
            // FormPocoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 457);
            this.Controls.Add(this.picVolverMenu);
            this.Controls.Add(this.dataGridViewPocoStock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPocoStock";
            this.Text = "Poco stock";
            this.Load += new System.EventHandler(this.FormPocoStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPocoStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolverMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPocoStock;
        private System.Windows.Forms.PictureBox picVolverMenu;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}