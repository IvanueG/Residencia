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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnLectura = new System.Windows.Forms.Button();
            this.PanelUsuario = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelInformacion = new System.Windows.Forms.Panel();
            this.cmbPacientes = new System.Windows.Forms.ComboBox();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.lblTituloEstadoActual = new System.Windows.Forms.Label();
            this.LogoEstadoActual = new System.Windows.Forms.PictureBox();
            this.PanelLectura = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.groupNotchFilters = new System.Windows.Forms.GroupBox();
            this.radioNone = new System.Windows.Forms.RadioButton();
            this.radio50Hz = new System.Windows.Forms.RadioButton();
            this.radio60Hz = new System.Windows.Forms.RadioButton();
            this.GrupoBasedeDatos = new System.Windows.Forms.GroupBox();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.btnDetenerEsc = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.GrupoEscala = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GrupoFiltro = new System.Windows.Forms.GroupBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GrupoLectura = new System.Windows.Forms.GroupBox();
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelMenu.SuspendLayout();
            this.PanelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoEstadoActual)).BeginInit();
            this.PanelLectura.SuspendLayout();
            this.groupNotchFilters.SuspendLayout();
            this.GrupoBasedeDatos.SuspendLayout();
            this.GrupoEscala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.GrupoFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.GrupoLectura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.PanelPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPaciente)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelAplicacionCuerpo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.PanelMenu.Controls.Add(this.btnPaciente);
            this.PanelMenu.Controls.Add(this.btnCerrarSesion);
            this.PanelMenu.Controls.Add(this.btnLectura);
            this.PanelMenu.Controls.Add(this.PanelUsuario);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(296, 932);
            this.PanelMenu.TabIndex = 0;
            // 
            // btnPaciente
            // 
            this.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.Color.White;
            this.btnPaciente.Image = global::SeñalesMioelectricas.Properties.Resources.Pacientes1;
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(0, 348);
            this.btnPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(296, 98);
            this.btnPaciente.TabIndex = 6;
            this.btnPaciente.Text = "  &Paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 858);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(296, 74);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "&Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnLectura
            // 
            this.btnLectura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLectura.FlatAppearance.BorderSize = 0;
            this.btnLectura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btnLectura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLectura.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLectura.ForeColor = System.Drawing.Color.White;
            this.btnLectura.Image = global::SeñalesMioelectricas.Properties.Resources.Señal21;
            this.btnLectura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLectura.Location = new System.Drawing.Point(0, 250);
            this.btnLectura.Margin = new System.Windows.Forms.Padding(4);
            this.btnLectura.Name = "btnLectura";
            this.btnLectura.Size = new System.Drawing.Size(296, 98);
            this.btnLectura.TabIndex = 3;
            this.btnLectura.Text = " &Lectura";
            this.btnLectura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLectura.UseVisualStyleBackColor = true;
            this.btnLectura.Click += new System.EventHandler(this.btnLectura_Click);
            // 
            // PanelUsuario
            // 
            this.PanelUsuario.Controls.Add(this.lblUsuario);
            this.PanelUsuario.Controls.Add(this.pictureBox1);
            this.PanelUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUsuario.Location = new System.Drawing.Point(0, 0);
            this.PanelUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.PanelUsuario.Name = "PanelUsuario";
            this.PanelUsuario.Size = new System.Drawing.Size(296, 250);
            this.PanelUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(4, 148);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(284, 98);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SeñalesMioelectricas.Properties.Resources.Usuario2;
            this.pictureBox1.Location = new System.Drawing.Point(67, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelInformacion
            // 
            this.PanelInformacion.AutoSize = true;
            this.PanelInformacion.Controls.Add(this.cmbPacientes);
            this.PanelInformacion.Controls.Add(this.lblSeleccion);
            this.PanelInformacion.Controls.Add(this.lblTituloEstadoActual);
            this.PanelInformacion.Controls.Add(this.LogoEstadoActual);
            this.PanelInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelInformacion.Location = new System.Drawing.Point(296, 0);
            this.PanelInformacion.Margin = new System.Windows.Forms.Padding(4);
            this.PanelInformacion.Name = "PanelInformacion";
            this.PanelInformacion.Size = new System.Drawing.Size(1628, 153);
            this.PanelInformacion.TabIndex = 1;
            this.PanelInformacion.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelInformacion_Paint);
            // 
            // cmbPacientes
            // 
            this.cmbPacientes.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPacientes.FormattingEnabled = true;
            this.cmbPacientes.Location = new System.Drawing.Point(625, 105);
            this.cmbPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPacientes.Name = "cmbPacientes";
            this.cmbPacientes.Size = new System.Drawing.Size(372, 44);
            this.cmbPacientes.TabIndex = 3;
            this.cmbPacientes.SelectedIndexChanged += new System.EventHandler(this.cmbPacientes_SelectedIndexChanged);
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.Location = new System.Drawing.Point(351, 108);
            this.lblSeleccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(250, 36);
            this.lblSeleccion.TabIndex = 2;
            this.lblSeleccion.Text = "Selecciona un Paciente:";
            // 
            // lblTituloEstadoActual
            // 
            this.lblTituloEstadoActual.AutoSize = true;
            this.lblTituloEstadoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEstadoActual.Location = new System.Drawing.Point(109, 26);
            this.lblTituloEstadoActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloEstadoActual.Name = "lblTituloEstadoActual";
            this.lblTituloEstadoActual.Size = new System.Drawing.Size(0, 39);
            this.lblTituloEstadoActual.TabIndex = 1;
            // 
            // LogoEstadoActual
            // 
            this.LogoEstadoActual.Location = new System.Drawing.Point(8, 4);
            this.LogoEstadoActual.Margin = new System.Windows.Forms.Padding(4);
            this.LogoEstadoActual.Name = "LogoEstadoActual";
            this.LogoEstadoActual.Size = new System.Drawing.Size(93, 86);
            this.LogoEstadoActual.TabIndex = 0;
            this.LogoEstadoActual.TabStop = false;
            // 
            // PanelLectura
            // 
            this.PanelLectura.Controls.Add(this.label1);
            this.PanelLectura.Controls.Add(this.btnAyuda);
            this.PanelLectura.Controls.Add(this.groupNotchFilters);
            this.PanelLectura.Controls.Add(this.GrupoBasedeDatos);
            this.PanelLectura.Controls.Add(this.GrupoEscala);
            this.PanelLectura.Controls.Add(this.GrupoFiltro);
            this.PanelLectura.Controls.Add(this.GrupoLectura);
            this.PanelLectura.Controls.Add(this.chart1);
            this.PanelLectura.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLectura.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelLectura.Location = new System.Drawing.Point(0, 0);
            this.PanelLectura.Margin = new System.Windows.Forms.Padding(4);
            this.PanelLectura.Name = "PanelLectura";
            this.PanelLectura.Size = new System.Drawing.Size(1628, 500);
            this.PanelLectura.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(971, 466);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nota: Si no sabes como posicionar los electrodos presiona el boton ayuda -->";
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.Location = new System.Drawing.Point(1447, 457);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(4);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(101, 36);
            this.btnAyuda.TabIndex = 4;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // groupNotchFilters
            // 
            this.groupNotchFilters.Controls.Add(this.radioNone);
            this.groupNotchFilters.Controls.Add(this.radio50Hz);
            this.groupNotchFilters.Controls.Add(this.radio60Hz);
            this.groupNotchFilters.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNotchFilters.Location = new System.Drawing.Point(1405, 194);
            this.groupNotchFilters.Margin = new System.Windows.Forms.Padding(4);
            this.groupNotchFilters.Name = "groupNotchFilters";
            this.groupNotchFilters.Padding = new System.Windows.Forms.Padding(4);
            this.groupNotchFilters.Size = new System.Drawing.Size(164, 240);
            this.groupNotchFilters.TabIndex = 3;
            this.groupNotchFilters.TabStop = false;
            this.groupNotchFilters.Text = "Notch Filters";
            // 
            // radioNone
            // 
            this.radioNone.AutoSize = true;
            this.radioNone.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNone.Location = new System.Drawing.Point(28, 192);
            this.radioNone.Margin = new System.Windows.Forms.Padding(4);
            this.radioNone.Name = "radioNone";
            this.radioNone.Size = new System.Drawing.Size(63, 28);
            this.radioNone.TabIndex = 5;
            this.radioNone.TabStop = true;
            this.radioNone.Text = "none";
            this.radioNone.UseVisualStyleBackColor = true;
            // 
            // radio50Hz
            // 
            this.radio50Hz.AutoSize = true;
            this.radio50Hz.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio50Hz.Location = new System.Drawing.Point(28, 49);
            this.radio50Hz.Margin = new System.Windows.Forms.Padding(4);
            this.radio50Hz.Name = "radio50Hz";
            this.radio50Hz.Size = new System.Drawing.Size(66, 28);
            this.radio50Hz.TabIndex = 3;
            this.radio50Hz.TabStop = true;
            this.radio50Hz.Text = "50 Hz";
            this.radio50Hz.UseVisualStyleBackColor = true;
            // 
            // radio60Hz
            // 
            this.radio60Hz.AutoSize = true;
            this.radio60Hz.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio60Hz.Location = new System.Drawing.Point(24, 121);
            this.radio60Hz.Margin = new System.Windows.Forms.Padding(4);
            this.radio60Hz.Name = "radio60Hz";
            this.radio60Hz.Size = new System.Drawing.Size(66, 28);
            this.radio60Hz.TabIndex = 4;
            this.radio60Hz.TabStop = true;
            this.radio60Hz.Text = "60 Hz";
            this.radio60Hz.UseVisualStyleBackColor = true;
            // 
            // GrupoBasedeDatos
            // 
            this.GrupoBasedeDatos.Controls.Add(this.btnCaptura);
            this.GrupoBasedeDatos.Controls.Add(this.btnDetenerEsc);
            this.GrupoBasedeDatos.Controls.Add(this.btnEscribir);
            this.GrupoBasedeDatos.Controls.Add(this.btnGuardar);
            this.GrupoBasedeDatos.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoBasedeDatos.Location = new System.Drawing.Point(1305, 37);
            this.GrupoBasedeDatos.Margin = new System.Windows.Forms.Padding(4);
            this.GrupoBasedeDatos.Name = "GrupoBasedeDatos";
            this.GrupoBasedeDatos.Padding = new System.Windows.Forms.Padding(4);
            this.GrupoBasedeDatos.Size = new System.Drawing.Size(267, 150);
            this.GrupoBasedeDatos.TabIndex = 2;
            this.GrupoBasedeDatos.TabStop = false;
            this.GrupoBasedeDatos.Text = "Base de Datos";
            // 
            // btnCaptura
            // 
            this.btnCaptura.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCaptura.Enabled = false;
            this.btnCaptura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaptura.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptura.Location = new System.Drawing.Point(19, 80);
            this.btnCaptura.Margin = new System.Windows.Forms.Padding(4);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(101, 63);
            this.btnCaptura.TabIndex = 6;
            this.btnCaptura.Text = "&Tomar Captura";
            this.btnCaptura.UseVisualStyleBackColor = false;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // btnDetenerEsc
            // 
            this.btnDetenerEsc.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDetenerEsc.Enabled = false;
            this.btnDetenerEsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetenerEsc.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetenerEsc.Location = new System.Drawing.Point(157, 79);
            this.btnDetenerEsc.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetenerEsc.Name = "btnDetenerEsc";
            this.btnDetenerEsc.Size = new System.Drawing.Size(101, 59);
            this.btnDetenerEsc.TabIndex = 5;
            this.btnDetenerEsc.Text = "Detener Escritura";
            this.btnDetenerEsc.UseVisualStyleBackColor = false;
            this.btnDetenerEsc.Click += new System.EventHandler(this.btnDetenerEsc_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEscribir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscribir.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscribir.Location = new System.Drawing.Point(157, 36);
            this.btnEscribir.Margin = new System.Windows.Forms.Padding(4);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(101, 36);
            this.btnEscribir.TabIndex = 4;
            this.btnEscribir.Text = "&Escribir";
            this.btnEscribir.UseVisualStyleBackColor = false;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(19, 36);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 36);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // GrupoEscala
            // 
            this.GrupoEscala.Controls.Add(this.trackBar1);
            this.GrupoEscala.Controls.Add(this.label6);
            this.GrupoEscala.Controls.Add(this.label5);
            this.GrupoEscala.Controls.Add(this.label4);
            this.GrupoEscala.Controls.Add(this.label3);
            this.GrupoEscala.Controls.Add(this.label2);
            this.GrupoEscala.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoEscala.Location = new System.Drawing.Point(915, 191);
            this.GrupoEscala.Margin = new System.Windows.Forms.Padding(4);
            this.GrupoEscala.Name = "GrupoEscala";
            this.GrupoEscala.Padding = new System.Windows.Forms.Padding(4);
            this.GrupoEscala.Size = new System.Drawing.Size(192, 240);
            this.GrupoEscala.TabIndex = 2;
            this.GrupoEscala.TabStop = false;
            this.GrupoEscala.Text = "Escala";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(16, 36);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 188);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "-100uV a 100uV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "-1mV a 1mV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "-10V a 10V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "-100V a 100V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "-1V a 1V";
            // 
            // GrupoFiltro
            // 
            this.GrupoFiltro.Controls.Add(this.trackBar2);
            this.GrupoFiltro.Controls.Add(this.label11);
            this.GrupoFiltro.Controls.Add(this.label10);
            this.GrupoFiltro.Controls.Add(this.label9);
            this.GrupoFiltro.Controls.Add(this.label8);
            this.GrupoFiltro.Controls.Add(this.label7);
            this.GrupoFiltro.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoFiltro.Location = new System.Drawing.Point(1176, 194);
            this.GrupoFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.GrupoFiltro.Name = "GrupoFiltro";
            this.GrupoFiltro.Padding = new System.Windows.Forms.Padding(4);
            this.GrupoFiltro.Size = new System.Drawing.Size(169, 240);
            this.GrupoFiltro.TabIndex = 2;
            this.GrupoFiltro.TabStop = false;
            this.GrupoFiltro.Text = "Filtro";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(8, 32);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar2.Maximum = 4;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(56, 188);
            this.trackBar2.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(61, 188);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "Ninguno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(61, 150);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "5Hz - 50Hz";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "15Hz - 50Hz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "7Hz - 13Hz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "1Hz - 50Hz";
            // 
            // GrupoLectura
            // 
            this.GrupoLectura.Controls.Add(this.btnDetener);
            this.GrupoLectura.Controls.Add(this.btnIniciar);
            this.GrupoLectura.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoLectura.Location = new System.Drawing.Point(915, 37);
            this.GrupoLectura.Margin = new System.Windows.Forms.Padding(4);
            this.GrupoLectura.Name = "GrupoLectura";
            this.GrupoLectura.Padding = new System.Windows.Forms.Padding(4);
            this.GrupoLectura.Size = new System.Drawing.Size(308, 123);
            this.GrupoLectura.TabIndex = 1;
            this.GrupoLectura.TabStop = false;
            this.GrupoLectura.Text = "Lectura";
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetener.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.Location = new System.Drawing.Point(177, 54);
            this.btnDetener.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(101, 36);
            this.btnDetener.TabIndex = 1;
            this.btnDetener.Text = "&Detener";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(32, 54);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(101, 36);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "&Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(85, 62);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(835, 369);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
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
            this.PanelPacientes.Location = new System.Drawing.Point(0, 500);
            this.PanelPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.PanelPacientes.Name = "PanelPacientes";
            this.PanelPacientes.Size = new System.Drawing.Size(1628, 501);
            this.PanelPacientes.TabIndex = 3;
            // 
            // FotoPaciente
            // 
            this.FotoPaciente.Image = global::SeñalesMioelectricas.Properties.Resources.UsuarioHombre;
            this.FotoPaciente.Location = new System.Drawing.Point(109, 15);
            this.FotoPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.FotoPaciente.Name = "FotoPaciente";
            this.FotoPaciente.Size = new System.Drawing.Size(213, 194);
            this.FotoPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoPaciente.TabIndex = 12;
            this.FotoPaciente.TabStop = false;
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas.Location = new System.Drawing.Point(471, 245);
            this.lblNotas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(62, 29);
            this.lblNotas.TabIndex = 11;
            this.lblNotas.Text = "Notas:";
            // 
            // lblLecturas
            // 
            this.lblLecturas.AutoSize = true;
            this.lblLecturas.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturas.Location = new System.Drawing.Point(104, 245);
            this.lblLecturas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLecturas.Name = "lblLecturas";
            this.lblLecturas.Size = new System.Drawing.Size(87, 29);
            this.lblLecturas.TabIndex = 10;
            this.lblLecturas.Text = "Lecturas:";
            // 
            // lblMusculo
            // 
            this.lblMusculo.AutoSize = true;
            this.lblMusculo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusculo.Location = new System.Drawing.Point(989, 53);
            this.lblMusculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusculo.Name = "lblMusculo";
            this.lblMusculo.Size = new System.Drawing.Size(79, 29);
            this.lblMusculo.TabIndex = 9;
            this.lblMusculo.Text = "Musculo";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(721, 53);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(79, 29);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(471, 53);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 29);
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
            this.panel1.Location = new System.Drawing.Point(1361, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 501);
            this.panel1.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::SeñalesMioelectricas.Properties.Resources.Eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(0, 182);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(267, 91);
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
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::SeñalesMioelectricas.Properties.Resources.Editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(0, 91);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(267, 91);
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
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::SeñalesMioelectricas.Properties.Resources.Añadir;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(267, 91);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(476, 289);
            this.txtNotas.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(648, 208);
            this.txtNotas.TabIndex = 4;
            // 
            // txtLecturas
            // 
            this.txtLecturas.Location = new System.Drawing.Point(109, 289);
            this.txtLecturas.Margin = new System.Windows.Forms.Padding(4);
            this.txtLecturas.Multiline = true;
            this.txtLecturas.Name = "txtLecturas";
            this.txtLecturas.Size = new System.Drawing.Size(257, 208);
            this.txtLecturas.TabIndex = 3;
            // 
            // txtMusculo
            // 
            this.txtMusculo.Location = new System.Drawing.Point(939, 91);
            this.txtMusculo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusculo.Name = "txtMusculo";
            this.txtMusculo.Size = new System.Drawing.Size(185, 22);
            this.txtMusculo.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(672, 91);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(185, 22);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(425, 91);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // PanelAplicacionCuerpo
            // 
            this.PanelAplicacionCuerpo.AutoSize = true;
            this.PanelAplicacionCuerpo.Controls.Add(this.PanelPacientes);
            this.PanelAplicacionCuerpo.Controls.Add(this.PanelLectura);
            this.PanelAplicacionCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAplicacionCuerpo.Location = new System.Drawing.Point(296, 153);
            this.PanelAplicacionCuerpo.Margin = new System.Windows.Forms.Padding(4);
            this.PanelAplicacionCuerpo.Name = "PanelAplicacionCuerpo";
            this.PanelAplicacionCuerpo.Size = new System.Drawing.Size(1628, 779);
            this.PanelAplicacionCuerpo.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Aplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 932);
            this.Controls.Add(this.PanelAplicacionCuerpo);
            this.Controls.Add(this.PanelInformacion);
            this.Controls.Add(this.PanelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1918, 825);
            this.Name = "Aplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion";
            this.Load += new System.EventHandler(this.Aplicacion_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelInformacion.ResumeLayout(false);
            this.PanelInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoEstadoActual)).EndInit();
            this.PanelLectura.ResumeLayout(false);
            this.PanelLectura.PerformLayout();
            this.groupNotchFilters.ResumeLayout(false);
            this.groupNotchFilters.PerformLayout();
            this.GrupoBasedeDatos.ResumeLayout(false);
            this.GrupoEscala.ResumeLayout(false);
            this.GrupoEscala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.GrupoFiltro.ResumeLayout(false);
            this.GrupoFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.GrupoLectura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.PanelPacientes.ResumeLayout(false);
            this.PanelPacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPaciente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.PanelAplicacionCuerpo.ResumeLayout(false);
            this.PanelAplicacionCuerpo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnLectura;
        private System.Windows.Forms.Panel PanelUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Panel PanelInformacion;
        private System.Windows.Forms.PictureBox LogoEstadoActual;
        private System.Windows.Forms.Label lblTituloEstadoActual;
        private System.Windows.Forms.ComboBox cmbPacientes;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Panel PanelLectura;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox GrupoBasedeDatos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox GrupoEscala;
        private System.Windows.Forms.GroupBox GrupoFiltro;
        private System.Windows.Forms.GroupBox GrupoLectura;
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
        private System.Windows.Forms.GroupBox groupNotchFilters;
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
    }
}