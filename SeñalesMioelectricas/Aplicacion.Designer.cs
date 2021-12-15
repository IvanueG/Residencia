namespace SeñalesMioelectricas
{
    partial class Aplicacion
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aplicacion));
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnLectura = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.radioNone = new System.Windows.Forms.RadioButton();
            this.radio50Hz = new System.Windows.Forms.RadioButton();
            this.radio60Hz = new System.Windows.Forms.RadioButton();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.btnDetenerEsc = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelPacientes = new System.Windows.Forms.Panel();
            this.FotoPaciente = new System.Windows.Forms.PictureBox();
            this.lblNotas = new System.Windows.Forms.Label();
            this.lblLecturas = new System.Windows.Forms.Label();
            this.lblMusculo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.txtLecturas = new System.Windows.Forms.TextBox();
            this.txtMusculo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.PanelAplicacionCuerpo = new System.Windows.Forms.Panel();
            this.PanelLectura = new System.Windows.Forms.Panel();
            this.cmbDolorPercibido = new System.Windows.Forms.ComboBox();
            this.cmbPacientes = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.PanelPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPaciente)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelAplicacionCuerpo.SuspendLayout();
            this.PanelLectura.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPaciente
            // 
            this.btnPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPaciente.BackColor = System.Drawing.Color.Transparent;
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.Color.Transparent;
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(172, 721);
            this.btnPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(238, 69);
            this.btnPaciente.TabIndex = 6;
            this.btnPaciente.UseVisualStyleBackColor = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Location = new System.Drawing.Point(48, 958);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(399, 59);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnLectura
            // 
            this.btnLectura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLectura.BackColor = System.Drawing.Color.Transparent;
            this.btnLectura.FlatAppearance.BorderSize = 0;
            this.btnLectura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLectura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLectura.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLectura.ForeColor = System.Drawing.Color.Transparent;
            this.btnLectura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLectura.Location = new System.Drawing.Point(172, 614);
            this.btnLectura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLectura.Name = "btnLectura";
            this.btnLectura.Size = new System.Drawing.Size(238, 69);
            this.btnLectura.TabIndex = 3;
            this.btnLectura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLectura.UseVisualStyleBackColor = false;
            this.btnLectura.Click += new System.EventHandler(this.btnLectura_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.lblUsuario.Location = new System.Drawing.Point(91, 325);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(320, 122);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1222, 958);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nota: Si no sabes como posicionar los electrodos presiona el boton ayuda -->";
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.Location = new System.Drawing.Point(1743, 945);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(114, 45);
            this.btnAyuda.TabIndex = 4;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // radioNone
            // 
            this.radioNone.AutoSize = true;
            this.radioNone.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNone.Location = new System.Drawing.Point(1618, 359);
            this.radioNone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioNone.Name = "radioNone";
            this.radioNone.Size = new System.Drawing.Size(76, 33);
            this.radioNone.TabIndex = 5;
            this.radioNone.TabStop = true;
            this.radioNone.Text = "none";
            this.radioNone.UseVisualStyleBackColor = true;
            // 
            // radio50Hz
            // 
            this.radio50Hz.AutoSize = true;
            this.radio50Hz.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio50Hz.Location = new System.Drawing.Point(1618, 180);
            this.radio50Hz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radio50Hz.Name = "radio50Hz";
            this.radio50Hz.Size = new System.Drawing.Size(81, 33);
            this.radio50Hz.TabIndex = 3;
            this.radio50Hz.TabStop = true;
            this.radio50Hz.Text = "50 Hz";
            this.radio50Hz.UseVisualStyleBackColor = true;
            // 
            // radio60Hz
            // 
            this.radio60Hz.AutoSize = true;
            this.radio60Hz.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio60Hz.Location = new System.Drawing.Point(1618, 269);
            this.radio60Hz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radio60Hz.Name = "radio60Hz";
            this.radio60Hz.Size = new System.Drawing.Size(80, 33);
            this.radio60Hz.TabIndex = 4;
            this.radio60Hz.TabStop = true;
            this.radio60Hz.Text = "60 Hz";
            this.radio60Hz.UseVisualStyleBackColor = true;
            // 
            // btnCaptura
            // 
            this.btnCaptura.BackColor = System.Drawing.Color.Transparent;
            this.btnCaptura.Enabled = false;
            this.btnCaptura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaptura.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            this.btnCaptura.Location = new System.Drawing.Point(591, 812);
            this.btnCaptura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(123, 102);
            this.btnCaptura.TabIndex = 6;
            this.btnCaptura.UseVisualStyleBackColor = false;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // btnDetenerEsc
            // 
            this.btnDetenerEsc.BackColor = System.Drawing.Color.Transparent;
            this.btnDetenerEsc.Enabled = false;
            this.btnDetenerEsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetenerEsc.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetenerEsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            this.btnDetenerEsc.Location = new System.Drawing.Point(755, 812);
            this.btnDetenerEsc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDetenerEsc.Name = "btnDetenerEsc";
            this.btnDetenerEsc.Size = new System.Drawing.Size(116, 102);
            this.btnDetenerEsc.TabIndex = 5;
            this.btnDetenerEsc.UseVisualStyleBackColor = false;
            this.btnDetenerEsc.Click += new System.EventHandler(this.btnDetenerEsc_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.BackColor = System.Drawing.Color.Transparent;
            this.btnEscribir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscribir.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscribir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            this.btnEscribir.Location = new System.Drawing.Point(757, 728);
            this.btnEscribir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(112, 54);
            this.btnEscribir.TabIndex = 4;
            this.btnEscribir.UseVisualStyleBackColor = false;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            this.btnGuardar.Location = new System.Drawing.Point(602, 729);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 51);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1043, 178);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar1.Maximum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(69, 235);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1092, 372);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "-100uV a 100uV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1092, 325);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "-1mV a 1mV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1092, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "-10V a 10V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1092, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "-100V a 100V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1092, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "-1V a 1V";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(1312, 179);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar2.Maximum = 4;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(69, 235);
            this.trackBar2.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1371, 374);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 29);
            this.label11.TabIndex = 20;
            this.label11.Text = "Ninguno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1371, 326);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "5Hz - 50Hz";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1371, 279);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "15Hz - 50Hz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1371, 231);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "7Hz - 13Hz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1371, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "1Hz - 50Hz";
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.Transparent;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetener.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            this.btnDetener.Location = new System.Drawing.Point(757, 520);
            this.btnDetener.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(112, 61);
            this.btnDetener.TabIndex = 1;
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.Location = new System.Drawing.Point(603, 520);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(102, 61);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(968, 471);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(909, 465);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // PanelPacientes
            // 
            this.PanelPacientes.AutoSize = true;
            this.PanelPacientes.Controls.Add(this.FotoPaciente);
            this.PanelPacientes.Controls.Add(this.lblNotas);
            this.PanelPacientes.Controls.Add(this.lblLecturas);
            this.PanelPacientes.Controls.Add(this.lblMusculo);
            this.PanelPacientes.Controls.Add(this.lblApellido);
            this.PanelPacientes.Controls.Add(this.lblNombre);
            this.PanelPacientes.Controls.Add(this.panel1);
            this.PanelPacientes.Controls.Add(this.txtNotas);
            this.PanelPacientes.Controls.Add(this.txtLecturas);
            this.PanelPacientes.Controls.Add(this.txtMusculo);
            this.PanelPacientes.Controls.Add(this.txtApellido);
            this.PanelPacientes.Controls.Add(this.txtNombre);
            this.PanelPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPacientes.Location = new System.Drawing.Point(0, 1059);
            this.PanelPacientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelPacientes.Name = "PanelPacientes";
            this.PanelPacientes.Size = new System.Drawing.Size(1926, 625);
            this.PanelPacientes.TabIndex = 3;
            // 
            // FotoPaciente
            // 
            this.FotoPaciente.Image = global::SeñalesMioelectricas.Properties.Resources.UsuarioHombre;
            this.FotoPaciente.Location = new System.Drawing.Point(123, 19);
            this.FotoPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FotoPaciente.Name = "FotoPaciente";
            this.FotoPaciente.Size = new System.Drawing.Size(240, 242);
            this.FotoPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoPaciente.TabIndex = 12;
            this.FotoPaciente.TabStop = false;
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas.Location = new System.Drawing.Point(530, 306);
            this.lblNotas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(74, 35);
            this.lblNotas.TabIndex = 11;
            this.lblNotas.Text = "Notas:";
            // 
            // lblLecturas
            // 
            this.lblLecturas.AutoSize = true;
            this.lblLecturas.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturas.Location = new System.Drawing.Point(117, 306);
            this.lblLecturas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLecturas.Name = "lblLecturas";
            this.lblLecturas.Size = new System.Drawing.Size(104, 35);
            this.lblLecturas.TabIndex = 10;
            this.lblLecturas.Text = "Lecturas:";
            // 
            // lblMusculo
            // 
            this.lblMusculo.AutoSize = true;
            this.lblMusculo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusculo.Location = new System.Drawing.Point(1113, 66);
            this.lblMusculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusculo.Name = "lblMusculo";
            this.lblMusculo.Size = new System.Drawing.Size(94, 35);
            this.lblMusculo.TabIndex = 9;
            this.lblMusculo.Text = "Musculo";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(811, 66);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(94, 35);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(530, 66);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 35);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1626, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 625);
            this.panel1.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::SeñalesMioelectricas.Properties.Resources.Eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(0, 228);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(300, 114);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::SeñalesMioelectricas.Properties.Resources.Editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(0, 114);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(300, 114);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::SeñalesMioelectricas.Properties.Resources.Añadir;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(300, 114);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(536, 361);
            this.txtNotas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(728, 259);
            this.txtNotas.TabIndex = 4;
            // 
            // txtLecturas
            // 
            this.txtLecturas.Location = new System.Drawing.Point(123, 361);
            this.txtLecturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLecturas.Multiline = true;
            this.txtLecturas.Name = "txtLecturas";
            this.txtLecturas.Size = new System.Drawing.Size(289, 259);
            this.txtLecturas.TabIndex = 3;
            // 
            // txtMusculo
            // 
            this.txtMusculo.Location = new System.Drawing.Point(1056, 114);
            this.txtMusculo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMusculo.Name = "txtMusculo";
            this.txtMusculo.Size = new System.Drawing.Size(208, 26);
            this.txtMusculo.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(756, 114);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(208, 26);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(478, 114);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // PanelAplicacionCuerpo
            // 
            this.PanelAplicacionCuerpo.AutoSize = true;
            this.PanelAplicacionCuerpo.Controls.Add(this.PanelPacientes);
            this.PanelAplicacionCuerpo.Controls.Add(this.PanelLectura);
            this.PanelAplicacionCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAplicacionCuerpo.Location = new System.Drawing.Point(0, 0);
            this.PanelAplicacionCuerpo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelAplicacionCuerpo.Name = "PanelAplicacionCuerpo";
            this.PanelAplicacionCuerpo.Size = new System.Drawing.Size(1926, 1079);
            this.PanelAplicacionCuerpo.TabIndex = 2;
            // 
            // PanelLectura
            // 
            this.PanelLectura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelLectura.BackgroundImage")));
            this.PanelLectura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelLectura.Controls.Add(this.flowLayoutPanel1);
            this.PanelLectura.Controls.Add(this.panel2);
            this.PanelLectura.Controls.Add(this.cmbDolorPercibido);
            this.PanelLectura.Controls.Add(this.btnDetenerEsc);
            this.PanelLectura.Controls.Add(this.btnCaptura);
            this.PanelLectura.Controls.Add(this.btnEscribir);
            this.PanelLectura.Controls.Add(this.radioNone);
            this.PanelLectura.Controls.Add(this.trackBar2);
            this.PanelLectura.Controls.Add(this.radio50Hz);
            this.PanelLectura.Controls.Add(this.btnGuardar);
            this.PanelLectura.Controls.Add(this.radio60Hz);
            this.PanelLectura.Controls.Add(this.label11);
            this.PanelLectura.Controls.Add(this.btnDetener);
            this.PanelLectura.Controls.Add(this.label10);
            this.PanelLectura.Controls.Add(this.trackBar1);
            this.PanelLectura.Controls.Add(this.label9);
            this.PanelLectura.Controls.Add(this.btnIniciar);
            this.PanelLectura.Controls.Add(this.label8);
            this.PanelLectura.Controls.Add(this.label6);
            this.PanelLectura.Controls.Add(this.label7);
            this.PanelLectura.Controls.Add(this.btnCerrarSesion);
            this.PanelLectura.Controls.Add(this.label5);
            this.PanelLectura.Controls.Add(this.lblUsuario);
            this.PanelLectura.Controls.Add(this.label4);
            this.PanelLectura.Controls.Add(this.btnPaciente);
            this.PanelLectura.Controls.Add(this.label3);
            this.PanelLectura.Controls.Add(this.btnLectura);
            this.PanelLectura.Controls.Add(this.label2);
            this.PanelLectura.Controls.Add(this.cmbPacientes);
            this.PanelLectura.Controls.Add(this.label1);
            this.PanelLectura.Controls.Add(this.btnAyuda);
            this.PanelLectura.Controls.Add(this.chart1);
            this.PanelLectura.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLectura.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelLectura.Location = new System.Drawing.Point(0, 0);
            this.PanelLectura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelLectura.Name = "PanelLectura";
            this.PanelLectura.Size = new System.Drawing.Size(1926, 1059);
            this.PanelLectura.TabIndex = 2;
            this.PanelLectura.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLectura_Paint);
            // 
            // cmbDolorPercibido
            // 
            this.cmbDolorPercibido.BackColor = System.Drawing.Color.White;
            this.cmbDolorPercibido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDolorPercibido.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDolorPercibido.ForeColor = System.Drawing.Color.Black;
            this.cmbDolorPercibido.FormattingEnabled = true;
            this.cmbDolorPercibido.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbDolorPercibido.Location = new System.Drawing.Point(532, 394);
            this.cmbDolorPercibido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDolorPercibido.Name = "cmbDolorPercibido";
            this.cmbDolorPercibido.Size = new System.Drawing.Size(399, 44);
            this.cmbDolorPercibido.TabIndex = 21;
            this.cmbDolorPercibido.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbPacientes
            // 
            this.cmbPacientes.BackColor = System.Drawing.Color.White;
            this.cmbPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPacientes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPacientes.ForeColor = System.Drawing.Color.Black;
            this.cmbPacientes.FormattingEnabled = true;
            this.cmbPacientes.Location = new System.Drawing.Point(532, 281);
            this.cmbPacientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPacientes.Name = "cmbPacientes";
            this.cmbPacientes.Size = new System.Drawing.Size(399, 44);
            this.cmbPacientes.TabIndex = 3;
            this.cmbPacientes.SelectedIndexChanged += new System.EventHandler(this.cmbPacientes_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(-33, -67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 22;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(549, 662);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(382, 304);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // Aplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1926, 1079);
            this.Controls.Add(this.PanelAplicacionCuerpo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1722, 1002);
            this.Name = "Aplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion";
            this.Load += new System.EventHandler(this.Aplicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.PanelPacientes.ResumeLayout(false);
            this.PanelPacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPaciente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.PanelAplicacionCuerpo.ResumeLayout(false);
            this.PanelAplicacionCuerpo.PerformLayout();
            this.PanelLectura.ResumeLayout(false);
            this.PanelLectura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnLectura;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Panel PanelPacientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.TextBox txtLecturas;
        private System.Windows.Forms.TextBox txtMusculo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox FotoPaciente;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.Label lblLecturas;
        private System.Windows.Forms.Label lblMusculo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel PanelAplicacionCuerpo;
        private System.Windows.Forms.RadioButton radioNone;
        private System.Windows.Forms.RadioButton radio50Hz;
        private System.Windows.Forms.RadioButton radio60Hz;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnDetenerEsc;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCaptura;
        private System.Windows.Forms.ComboBox cmbPacientes;
        private System.Windows.Forms.Panel PanelLectura;
        private System.Windows.Forms.ComboBox cmbDolorPercibido;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
    }
}