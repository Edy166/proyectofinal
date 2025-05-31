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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerProductos));
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.picVolverMenu = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.text_buscar = new System.Windows.Forms.TextBox();
            this.ver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolverMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ver)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(48, 113);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.RowTemplate.Height = 24;
            this.dataGridViewProductos.Size = new System.Drawing.Size(1005, 284);
            this.dataGridViewProductos.TabIndex = 0;
            // 
            // picVolverMenu
            // 
            this.picVolverMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVolverMenu.Image = global::proyecto_final_2._1.Properties.Resources.fire_exit_emergency_door_icon_196812;
            this.picVolverMenu.Location = new System.Drawing.Point(0, 0);
            this.picVolverMenu.Name = "picVolverMenu";
            this.picVolverMenu.Size = new System.Drawing.Size(115, 71);
            this.picVolverMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVolverMenu.TabIndex = 1;
            this.picVolverMenu.TabStop = false;
            this.picVolverMenu.Click += new System.EventHandler(this.picVolverMenu_Click);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(468, 24);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(156, 25);
            this.lbl_buscar.TabIndex = 2;
            this.lbl_buscar.Text = "Buscar por ID";
            // 
            // text_buscar
            // 
            this.text_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.text_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.text_buscar.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.text_buscar.Location = new System.Drawing.Point(460, 52);
            this.text_buscar.Name = "text_buscar";
            this.text_buscar.Size = new System.Drawing.Size(185, 39);
            this.text_buscar.TabIndex = 3;
            // 
            // ver
            // 
            this.ver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ver.Image = global::proyecto_final_2._1.Properties.Resources.magnifier_1_icon_icons_com_56924;
            this.ver.Location = new System.Drawing.Point(651, 52);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(57, 39);
            this.ver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ver.TabIndex = 4;
            this.ver.TabStop = false;
            this.ver.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormVerProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1114, 499);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.text_buscar);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.picVolverMenu);
            this.Controls.Add(this.dataGridViewProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormVerProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver producto";
            this.Load += new System.EventHandler(this.FormVerProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolverMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.PictureBox picVolverMenu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox text_buscar;
        private System.Windows.Forms.PictureBox ver;
    }
}