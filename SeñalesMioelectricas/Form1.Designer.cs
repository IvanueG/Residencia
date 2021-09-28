namespace SeñalesMioelectricas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.LogoContraseña = new System.Windows.Forms.PictureBox();
            this.LogoUsuario = new System.Windows.Forms.PictureBox();
            this.ImagenInicioSesion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenInicioSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(309, 178);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(233, 40);
            this.txtUsuario.TabIndex = 10;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(309, 237);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(233, 40);
            this.txtContraseña.TabIndex = 11;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.btnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Image = global::SeñalesMioelectricas.Properties.Resources.Siguiente1;
            this.btnIniciarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarSesion.Location = new System.Drawing.Point(263, 292);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(279, 63);
            this.btnIniciarSesion.TabIndex = 3;
            this.btnIniciarSesion.Text = "&Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // LogoContraseña
            // 
            this.LogoContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.LogoContraseña.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LogoContraseña.Image = global::SeñalesMioelectricas.Properties.Resources.LogoContraseña;
            this.LogoContraseña.Location = new System.Drawing.Point(263, 237);
            this.LogoContraseña.Name = "LogoContraseña";
            this.LogoContraseña.Size = new System.Drawing.Size(40, 40);
            this.LogoContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoContraseña.TabIndex = 2;
            this.LogoContraseña.TabStop = false;
            // 
            // LogoUsuario
            // 
            this.LogoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.LogoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LogoUsuario.Image = global::SeñalesMioelectricas.Properties.Resources.LogoUsuario;
            this.LogoUsuario.Location = new System.Drawing.Point(263, 176);
            this.LogoUsuario.Name = "LogoUsuario";
            this.LogoUsuario.Size = new System.Drawing.Size(40, 40);
            this.LogoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoUsuario.TabIndex = 1;
            this.LogoUsuario.TabStop = false;
            // 
            // ImagenInicioSesion
            // 
            this.ImagenInicioSesion.Image = global::SeñalesMioelectricas.Properties.Resources.Usuario;
            this.ImagenInicioSesion.Location = new System.Drawing.Point(336, 24);
            this.ImagenInicioSesion.Name = "ImagenInicioSesion";
            this.ImagenInicioSesion.Size = new System.Drawing.Size(144, 138);
            this.ImagenInicioSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenInicioSesion.TabIndex = 0;
            this.ImagenInicioSesion.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.LogoContraseña);
            this.Controls.Add(this.LogoUsuario);
            this.Controls.Add(this.ImagenInicioSesion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenInicioSesion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagenInicioSesion;
        private System.Windows.Forms.PictureBox LogoUsuario;
        private System.Windows.Forms.PictureBox LogoContraseña;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIniciarSesion;
    }
}

