namespace SeñalesMioelectricas
{
    partial class VistaAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaAyuda));
            this.PanelPlaca = new System.Windows.Forms.Panel();
            this.btnSalir1 = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ImagenPlaca = new System.Windows.Forms.PictureBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.PanelElectrodos = new System.Windows.Forms.Panel();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelPlaca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPlaca)).BeginInit();
            this.PanelElectrodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPlaca
            // 
            this.PanelPlaca.BackColor = System.Drawing.Color.White;
            this.PanelPlaca.Controls.Add(this.btnSalir1);
            this.PanelPlaca.Controls.Add(this.btnSiguiente);
            this.PanelPlaca.Controls.Add(this.label2);
            this.PanelPlaca.Controls.Add(this.ImagenPlaca);
            this.PanelPlaca.Controls.Add(this.lblPlaca);
            this.PanelPlaca.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPlaca.Location = new System.Drawing.Point(0, 0);
            this.PanelPlaca.Name = "PanelPlaca";
            this.PanelPlaca.Size = new System.Drawing.Size(1149, 396);
            this.PanelPlaca.TabIndex = 0;
            // 
            // btnSalir1
            // 
            this.btnSalir1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir1.Location = new System.Drawing.Point(988, 359);
            this.btnSalir1.Name = "btnSalir1";
            this.btnSalir1.Size = new System.Drawing.Size(79, 31);
            this.btnSalir1.TabIndex = 7;
            this.btnSalir1.Text = "Salir";
            this.btnSalir1.UseVisualStyleBackColor = false;
            this.btnSalir1.Click += new System.EventHandler(this.btnSalir1_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(903, 359);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(79, 31);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(691, 57);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // ImagenPlaca
            // 
            this.ImagenPlaca.Image = global::SeñalesMioelectricas.Properties.Resources.EMG_Cyton_Setup;
            this.ImagenPlaca.Location = new System.Drawing.Point(330, 54);
            this.ImagenPlaca.Name = "ImagenPlaca";
            this.ImagenPlaca.Size = new System.Drawing.Size(382, 205);
            this.ImagenPlaca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenPlaca.TabIndex = 3;
            this.ImagenPlaca.TabStop = false;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(278, 9);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(504, 32);
            this.lblPlaca.TabIndex = 2;
            this.lblPlaca.Text = "Conexion de los Electrodos a la Placa";
            // 
            // PanelElectrodos
            // 
            this.PanelElectrodos.BackColor = System.Drawing.Color.White;
            this.PanelElectrodos.Controls.Add(this.btnAnterior);
            this.PanelElectrodos.Controls.Add(this.label3);
            this.PanelElectrodos.Controls.Add(this.btnSalir);
            this.PanelElectrodos.Controls.Add(this.pictureBox1);
            this.PanelElectrodos.Controls.Add(this.label1);
            this.PanelElectrodos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelElectrodos.Location = new System.Drawing.Point(0, 396);
            this.PanelElectrodos.Name = "PanelElectrodos";
            this.PanelElectrodos.Size = new System.Drawing.Size(1149, 427);
            this.PanelElectrodos.TabIndex = 1;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(903, 393);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(79, 31);
            this.btnAnterior.TabIndex = 7;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1131, 95);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1003, 393);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 31);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SeñalesMioelectricas.Properties.Resources.EMG_Electrode_Placement;
            this.pictureBox1.Location = new System.Drawing.Point(330, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conexion de los Electrodos al Musculo";
            // 
            // VistaAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1149, 450);
            this.Controls.Add(this.PanelElectrodos);
            this.Controls.Add(this.PanelPlaca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaAyuda";
            this.Text = "Ayuda";
            this.PanelPlaca.ResumeLayout(false);
            this.PanelPlaca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPlaca)).EndInit();
            this.PanelElectrodos.ResumeLayout(false);
            this.PanelElectrodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPlaca;
        private System.Windows.Forms.Panel PanelElectrodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ImagenPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSalir1;
        private System.Windows.Forms.Button btnAnterior;
    }
}