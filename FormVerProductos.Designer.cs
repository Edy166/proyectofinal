namespace proyecto_final_2._1
{
    partial class FormVerProductos
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
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.picVolverMenu = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolverMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(54, 39);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.RowTemplate.Height = 24;
            this.dataGridViewProductos.Size = new System.Drawing.Size(872, 284);
            this.dataGridViewProductos.TabIndex = 0;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            // 
            // picVolverMenu
            // 
            this.picVolverMenu.Image = global::proyecto_final_2._1.Properties.Resources.fire_exit_emergency_door_icon_196812;
            this.picVolverMenu.Location = new System.Drawing.Point(0, 0);
            this.picVolverMenu.Name = "picVolverMenu";
            this.picVolverMenu.Size = new System.Drawing.Size(48, 40);
            this.picVolverMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVolverMenu.TabIndex = 1;
            this.picVolverMenu.TabStop = false;
            this.picVolverMenu.Click += new System.EventHandler(this.picVolverMenu_Click);
            // 
            // FormVerProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 363);
            this.Controls.Add(this.picVolverMenu);
            this.Controls.Add(this.dataGridViewProductos);
            this.Name = "FormVerProductos";
            this.Text = "FormVerProductos";
            this.Load += new System.EventHandler(this.FormVerProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolverMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.PictureBox picVolverMenu;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}