namespace proyecto_final_2._1
{
    partial class Editar_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Productos));
            this.lblnombreprod = new System.Windows.Forms.Label();
            this.lblcodprod = new System.Windows.Forms.Label();
            this.lblexistencias = new System.Windows.Forms.Label();
            this.lblprecioventa = new System.Windows.Forms.Label();
            this.lblpreciocosto = new System.Windows.Forms.Label();
            this.txtnombreprod = new System.Windows.Forms.TextBox();
            this.txtcodprod = new System.Windows.Forms.TextBox();
            this.txtpreciocosto = new System.Windows.Forms.TextBox();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.txtexistencias = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dvgproductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblbuscarid = new System.Windows.Forms.Label();
            this.txtbuscarid = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgproductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombreprod
            // 
            this.lblnombreprod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnombreprod.AutoSize = true;
            this.lblnombreprod.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblnombreprod.Location = new System.Drawing.Point(189, 18);
            this.lblnombreprod.Name = "lblnombreprod";
            this.lblnombreprod.Size = new System.Drawing.Size(258, 25);
            this.lblnombreprod.TabIndex = 0;
            this.lblnombreprod.Text = "NOMBRE PRODUCTO";
            this.lblnombreprod.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblnombreprod.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblcodprod
            // 
            this.lblcodprod.AutoSize = true;
            this.lblcodprod.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblcodprod.Location = new System.Drawing.Point(6, 85);
            this.lblcodprod.Name = "lblcodprod";
            this.lblcodprod.Size = new System.Drawing.Size(249, 25);
            this.lblcodprod.TabIndex = 1;
            this.lblcodprod.Text = "CÓDIGO PRODUCTO";
            this.lblcodprod.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblexistencias
            // 
            this.lblexistencias.AutoSize = true;
            this.lblexistencias.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblexistencias.Location = new System.Drawing.Point(432, 145);
            this.lblexistencias.Name = "lblexistencias";
            this.lblexistencias.Size = new System.Drawing.Size(166, 25);
            this.lblexistencias.TabIndex = 2;
            this.lblexistencias.Text = "EXISTENCIAS";
            this.lblexistencias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblprecioventa
            // 
            this.lblprecioventa.AutoSize = true;
            this.lblprecioventa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblprecioventa.Location = new System.Drawing.Point(405, 85);
            this.lblprecioventa.Name = "lblprecioventa";
            this.lblprecioventa.Size = new System.Drawing.Size(231, 25);
            this.lblprecioventa.TabIndex = 3;
            this.lblprecioventa.Text = "PRECIO VENTA (Q.)";
            this.lblprecioventa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblpreciocosto
            // 
            this.lblpreciocosto.AutoSize = true;
            this.lblpreciocosto.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblpreciocosto.Location = new System.Drawing.Point(13, 141);
            this.lblpreciocosto.Name = "lblpreciocosto";
            this.lblpreciocosto.Size = new System.Drawing.Size(236, 25);
            this.lblpreciocosto.TabIndex = 4;
            this.lblpreciocosto.Text = "PRECIO COSTO (Q.)";
            this.lblpreciocosto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtnombreprod
            // 
            this.txtnombreprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.txtnombreprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtnombreprod.Location = new System.Drawing.Point(216, 48);
            this.txtnombreprod.Name = "txtnombreprod";
            this.txtnombreprod.Size = new System.Drawing.Size(212, 22);
            this.txtnombreprod.TabIndex = 5;
            // 
            // txtcodprod
            // 
            this.txtcodprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.txtcodprod.Location = new System.Drawing.Point(18, 113);
            this.txtcodprod.Name = "txtcodprod";
            this.txtcodprod.Size = new System.Drawing.Size(201, 22);
            this.txtcodprod.TabIndex = 6;
            // 
            // txtpreciocosto
            // 
            this.txtpreciocosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.txtpreciocosto.Location = new System.Drawing.Point(18, 173);
            this.txtpreciocosto.Name = "txtpreciocosto";
            this.txtpreciocosto.Size = new System.Drawing.Size(201, 22);
            this.txtpreciocosto.TabIndex = 7;
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.txtprecioventa.Location = new System.Drawing.Point(419, 113);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(195, 22);
            this.txtprecioventa.TabIndex = 8;
            // 
            // txtexistencias
            // 
            this.txtexistencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.txtexistencias.Location = new System.Drawing.Point(431, 173);
            this.txtexistencias.Name = "txtexistencias";
            this.txtexistencias.Size = new System.Drawing.Size(167, 22);
            this.txtexistencias.TabIndex = 9;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(262, 202);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(115, 46);
            this.btnguardar.TabIndex = 10;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click_1);
            // 
            // dvgproductos
            // 
            this.dvgproductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.dvgproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgproductos.Location = new System.Drawing.Point(52, 407);
            this.dvgproductos.Name = "dvgproductos";
            this.dvgproductos.RowHeadersWidth = 51;
            this.dvgproductos.RowTemplate.Height = 24;
            this.dvgproductos.Size = new System.Drawing.Size(1007, 184);
            this.dvgproductos.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.txtexistencias);
            this.groupBox1.Controls.Add(this.txtcodprod);
            this.groupBox1.Controls.Add(this.txtpreciocosto);
            this.groupBox1.Controls.Add(this.lblcodprod);
            this.groupBox1.Controls.Add(this.txtnombreprod);
            this.groupBox1.Controls.Add(this.lblnombreprod);
            this.groupBox1.Controls.Add(this.txtprecioventa);
            this.groupBox1.Controls.Add(this.lblpreciocosto);
            this.groupBox1.Controls.Add(this.lblexistencias);
            this.groupBox1.Controls.Add(this.lblprecioventa);
            this.groupBox1.Location = new System.Drawing.Point(226, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 254);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "MENÚ EDITAR PRODUCTOS";
            // 
            // lblbuscarid
            // 
            this.lblbuscarid.AutoSize = true;
            this.lblbuscarid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblbuscarid.Location = new System.Drawing.Point(309, 119);
            this.lblbuscarid.Name = "lblbuscarid";
            this.lblbuscarid.Size = new System.Drawing.Size(196, 25);
            this.lblbuscarid.TabIndex = 17;
            this.lblbuscarid.Text = "BUSCAR POR ID";
            // 
            // txtbuscarid
            // 
            this.txtbuscarid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.txtbuscarid.Location = new System.Drawing.Point(523, 122);
            this.txtbuscarid.Name = "txtbuscarid";
            this.txtbuscarid.Size = new System.Drawing.Size(166, 22);
            this.txtbuscarid.TabIndex = 18;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImage = global::proyecto_final_2._1.Properties.Resources.magnifier_1_icon_icons_com_56924;
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.Location = new System.Drawing.Point(695, 118);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(34, 31);
            this.btnbuscar.TabIndex = 19;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::proyecto_final_2._1.Properties.Resources.fire_exit_emergency_door_icon_196812;
            this.pictureBox1.Location = new System.Drawing.Point(3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Editar_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1134, 603);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbuscarid);
            this.Controls.Add(this.lblbuscarid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dvgproductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editar_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar productos";
            ((System.ComponentModel.ISupportInitialize)(this.dvgproductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombreprod;
        private System.Windows.Forms.Label lblcodprod;
        private System.Windows.Forms.Label lblexistencias;
        private System.Windows.Forms.Label lblprecioventa;
        private System.Windows.Forms.Label lblpreciocosto;
        private System.Windows.Forms.TextBox txtnombreprod;
        private System.Windows.Forms.TextBox txtcodprod;
        private System.Windows.Forms.TextBox txtpreciocosto;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.TextBox txtexistencias;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dvgproductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblbuscarid;
        private System.Windows.Forms.TextBox txtbuscarid;
        private System.Windows.Forms.Button btnbuscar;
    }
}