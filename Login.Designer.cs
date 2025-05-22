namespace proyecto_final_2._1
{
    partial class Form1login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1login));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxusuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paneldecontraseña = new System.Windows.Forms.Panel();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.blbrecuperacion = new System.Windows.Forms.Label();
            this.lblCrearCuenta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.picboxojito = new System.Windows.Forms.PictureBox();
            this.picboxempresa = new System.Windows.Forms.PictureBox();
            this.picboxcontraseña = new System.Windows.Forms.PictureBox();
            this.picboxusuario = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.paneldecontraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxojito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxempresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxcontraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(63, 27);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(660, 43);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "BIENVENIDO A SOLUCIONES S.A";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblusuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblusuario.Location = new System.Drawing.Point(515, 124);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(124, 30);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "Usuario  ";
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblcontraseña.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblcontraseña.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblcontraseña.Location = new System.Drawing.Point(515, 230);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(148, 30);
            this.lblcontraseña.TabIndex = 2;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lbltitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 93);
            this.panel1.TabIndex = 3;
            // 
            // textBoxusuario
            // 
            this.textBoxusuario.BackColor = System.Drawing.Color.White;
            this.textBoxusuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxusuario.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxusuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxusuario.Location = new System.Drawing.Point(476, 157);
            this.textBoxusuario.Name = "textBoxusuario";
            this.textBoxusuario.Size = new System.Drawing.Size(234, 34);
            this.textBoxusuario.TabIndex = 4;
            this.textBoxusuario.Tag = "";
            this.textBoxusuario.Text = "Ingrese su usuario";
            this.textBoxusuario.Enter += new System.EventHandler(this.textBoxusuario_Enter);
            this.textBoxusuario.Leave += new System.EventHandler(this.textBoxusuario_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.picboxempresa);
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 545);
            this.panel2.TabIndex = 8;
            // 
            // paneldecontraseña
            // 
            this.paneldecontraseña.Controls.Add(this.txtcontraseña);
            this.paneldecontraseña.Controls.Add(this.picboxojito);
            this.paneldecontraseña.Location = new System.Drawing.Point(476, 274);
            this.paneldecontraseña.Name = "paneldecontraseña";
            this.paneldecontraseña.Size = new System.Drawing.Size(294, 47);
            this.paneldecontraseña.TabIndex = 9;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.BackColor = System.Drawing.Color.White;
            this.txtcontraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtcontraseña.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtcontraseña.Location = new System.Drawing.Point(6, 3);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(236, 34);
            this.txtcontraseña.TabIndex = 1;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.White;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnlogin.Location = new System.Drawing.Point(501, 327);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(171, 44);
            this.btnlogin.TabIndex = 10;
            this.btnlogin.Text = "Aceptar";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // blbrecuperacion
            // 
            this.blbrecuperacion.AutoSize = true;
            this.blbrecuperacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blbrecuperacion.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbrecuperacion.Location = new System.Drawing.Point(397, 398);
            this.blbrecuperacion.Name = "blbrecuperacion";
            this.blbrecuperacion.Size = new System.Drawing.Size(373, 30);
            this.blbrecuperacion.TabIndex = 11;
            this.blbrecuperacion.Text = " ¿Has olvidado la contraseña?";
            this.blbrecuperacion.Click += new System.EventHandler(this.label2derecuperacion_Click);
            // 
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.AutoSize = true;
            this.lblCrearCuenta.BackColor = System.Drawing.Color.Transparent;
            this.lblCrearCuenta.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearCuenta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCrearCuenta.Location = new System.Drawing.Point(377, 484);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(245, 24);
            this.lblCrearCuenta.TabIndex = 12;
            this.lblCrearCuenta.Text = "¿No tienes una cuenta?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(650, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Crear cuenta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picboxojito
            // 
            this.picboxojito.BackColor = System.Drawing.Color.Transparent;
            this.picboxojito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxojito.Image = global::proyecto_final_2._1.Properties.Resources.eye_icon_217639;
            this.picboxojito.Location = new System.Drawing.Point(248, 3);
            this.picboxojito.Name = "picboxojito";
            this.picboxojito.Size = new System.Drawing.Size(43, 26);
            this.picboxojito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxojito.TabIndex = 0;
            this.picboxojito.TabStop = false;
            this.picboxojito.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // picboxempresa
            // 
            this.picboxempresa.BackColor = System.Drawing.Color.MidnightBlue;
            this.picboxempresa.Image = global::proyecto_final_2._1.Properties.Resources.imagen_ro;
            this.picboxempresa.Location = new System.Drawing.Point(-3, -18);
            this.picboxempresa.Name = "picboxempresa";
            this.picboxempresa.Size = new System.Drawing.Size(351, 544);
            this.picboxempresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxempresa.TabIndex = 0;
            this.picboxempresa.TabStop = false;
            // 
            // picboxcontraseña
            // 
            this.picboxcontraseña.Image = global::proyecto_final_2._1.Properties.Resources.secure_safety_password_protection_security_lock_padlock_icon_219355;
            this.picboxcontraseña.Location = new System.Drawing.Point(410, 277);
            this.picboxcontraseña.Name = "picboxcontraseña";
            this.picboxcontraseña.Size = new System.Drawing.Size(60, 38);
            this.picboxcontraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxcontraseña.TabIndex = 7;
            this.picboxcontraseña.TabStop = false;
            // 
            // picboxusuario
            // 
            this.picboxusuario.Image = global::proyecto_final_2._1.Properties.Resources.ic_username_97587;
            this.picboxusuario.Location = new System.Drawing.Point(404, 157);
            this.picboxusuario.Name = "picboxusuario";
            this.picboxusuario.Size = new System.Drawing.Size(60, 38);
            this.picboxusuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxusuario.TabIndex = 6;
            this.picboxusuario.TabStop = false;
            // 
            // Form1login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCrearCuenta);
            this.Controls.Add(this.blbrecuperacion);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.paneldecontraseña);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picboxcontraseña);
            this.Controls.Add(this.picboxusuario);
            this.Controls.Add(this.textBoxusuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblusuario);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.paneldecontraseña.ResumeLayout(false);
            this.paneldecontraseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxojito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxempresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxcontraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxusuario;
        private System.Windows.Forms.PictureBox picboxusuario;
        private System.Windows.Forms.PictureBox picboxcontraseña;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picboxempresa;
        private System.Windows.Forms.Panel paneldecontraseña;
        private System.Windows.Forms.PictureBox picboxojito;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label blbrecuperacion;
        private System.Windows.Forms.Label lblCrearCuenta;
        private System.Windows.Forms.Button button1;
    }
}

