using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace SeñalesMioelectricas
{
    public partial class Aplicacion : Form
    {
        private Button currentButton;

        //Conexion a la Base de Datos
        //Señales_MioelectricasEntities db = new Señales_MioelectricasEntities();
        BaseDeDatosDataContext db = new BaseDeDatosDataContext();
        List<int> pacientes = new List<int>();
        int id;

        //Parte para la lectura
        StreamWriter sw;
        bool istniejeSW = false;
        public int xClick = 0, yClick = 0;
        string puerto;

        //Variable para actualizacion de la aplicacion con base de datos
        string UsuarioPrueba;


        public Aplicacion()
        {
            InitializeComponent();
            //Inicializa la forma vacia
            //PanelInformacion.Visible = false;
            PanelLectura.Visible = false;
            PanelPacientes.Visible = false;
        }

        public Aplicacion(string user)
        {
            InitializeComponent();
            //Inicializa la forma vacia
            //PanelInformacion.Visible = false;
            PanelLectura.Visible = false;
            PanelPacientes.Visible = false;


            //Prueba de actualizacion de datos de pacientes
            UsuarioPrueba = user;


            //Fija el Tamaño de la Ventana de Inicio de Sesion y se impide el tamaño de ventana completa.
            this.MaximizeBox = false;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.Width = 1322;

            this.Height = 743;

            Form1 form1 = new Form1();
            id = db.Usuario.Where(w => w.Usuario1 == user).Select(s => s.ID_User).FirstOrDefault();
            var usuario = db.Medico.Where(c => c.ID_User == id).FirstOrDefault();


            lblUsuario.Text = usuario.Nombre +"\r\n"+ usuario.Apellido_Paterno + " " + usuario.Apellido_Materno;
            var nombrespacientes = db.Paciente.Where(w => w.ID_Medico == usuario.ID_Medico).ToList();
            
            
            foreach(var name in nombrespacientes)
            {
                cmbPacientes.Items.Add(name.Nombre + " "+ name.Apellido_Paterno + " " + name.Apellido_Materno);
                pacientes.Add(name.ID_Paciente);
                
            }

            cmbPacientes.DropDownStyle = ComboBoxStyle.DropDownList;

            //Parte de Lectura
            this.DoubleBuffered = true;


            List<string> puertos = new List<string>();
            foreach (string s in SerialPort.GetPortNames())
            {
                puertos.Add(s);
            }

            foreach (string item in puertos)
            {
                puerto = item;
            }
            radioNone.Checked = true;
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.Transparent;
            public static Color color2 = Color.Transparent;
            public static Color color3 = Color.Transparent;
            public static Color color4 = Color.Transparent;
            public static Color color5 = Color.Transparent;
            public static Color color6 = Color.Transparent;
        }

        //Lectura
        struct DaneSerialPort
        {
            public byte[] variable;
        };

        Queue<DaneSerialPort> driver = new Queue<DaneSerialPort>();

        void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            DaneSerialPort Datos_resividos;
            byte[] buffer = new byte[serialPort1.BytesToRead];
            serialPort1.Read(buffer, 0, buffer.Length);
            Datos_resividos.variable = buffer;
            driver.Enqueue(Datos_resividos);
        }

        //Ilumina el boton correspondiente al panel que se este utilizando
        //Para que el usuario detecte que panel este utilizando actualmente.
        private void BotonActivo(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    BotonInactivo();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Transparent;
                    currentButton.ForeColor = Color.Transparent;
                    currentButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        //Regresa el boton al color original cuando se selecciona otro.
        private void BotonInactivo()
        {
            foreach(Control BotonPrevio in PanelLectura.Controls)
            {
                if(BotonPrevio.GetType()== typeof(Button))
                {
                    BotonPrevio.BackColor = Color.Transparent;
                    BotonPrevio.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        //Boton que permite la visualizacion del panel Lectura
        private void btnLectura_Click(object sender, EventArgs e)
        {
            BotonActivo(sender);
            //lblTituloEstadoActual.Text = "Lectura";
           // LogoEstadoActual.Image = Properties.Resources.Señal21;
            //PanelInformacion.Visible = true;
            PanelLectura.Visible = true;
            PanelPacientes.Visible = false;

            Image myimage = new Bitmap(@"C:\Residencia\Residencia\SeñalesMioelectricas\Resources\LECTURA.png");
            this.BackgroundImage = myimage;
            //Form1.ActiveForm.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal)+ @"\LECTURA.png");

        }

        //Boton que permite la visualizacion del panel Paciente
        private void btnPaciente_Click(object sender, EventArgs e)
        {
            BotonActivo(sender);
            //lblTituloEstadoActual.Text = "Pacientes";
            //LogoEstadoActual.Image = Properties.Resources.Pacientes1;
            //PanelInformacion.Visible = true;
            PanelLectura.Visible = false;
            PanelPacientes.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPaciente agregarPaciente = new AgregarPaciente(id, UsuarioPrueba);
            agregarPaciente.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarPaciente editarPaciente = new EditarPaciente(id, UsuarioPrueba);
            editarPaciente.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BorrarPaciente borrarPaciente = new BorrarPaciente(id, UsuarioPrueba);
            borrarPaciente.Show();
            this.Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void Aplicacion_FormClosing(object sender, FormClosingEventArgs e)
        {

            Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Codigo para abrir el puerto de Lectura
            serialPort1.PortName = puerto;
            serialPort1.BaudRate = 115200;
            try
            {
                serialPort1.Open();
                btnIniciar.Enabled = false;
        }
            catch
            {
                MessageBox.Show("No se pudo Abrir el puerto");
                btnIniciar.Enabled = true;
            }
    serialPort1.DataReceived += serialPort1_DataReceived;

            char[] buff = new char[1];
            buff[0] = 'b';
            try
            {
                serialPort1.Write(buff, 0, 1);
            }
            catch
            {
                MessageBox.Show("Error con el puerto.");
            }                        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double[] daneRys;
            while (driver.Count > 0)
            {
                DaneSerialPort data = driver.Dequeue();
                for (int g = 0; g < data.variable. Length; g++)
                {
                    daneRys = Convert.interpretBinaryStream(data.variable[g]);
                    if (daneRys != null)
                    {
                        daneRys = ValueOrZero(daneRys);
                        writeToFile(daneRys); //Esto estaba comentado
                        drawPlot(daneRys);
                    }
                }
            }
        }

        //Nuevo codigo residencia 2
        private void writeToFile(double[] daneRys)
        {
            double mnoz = (4.5 / 24 / (Math.Pow(2, 23) - 1)) * (Math.Pow(10, 6));

            for (int i = 0; i < 8; i++)
            {
                daneRys[i + 1] = daneRys[i + 1] * mnoz;
            }
            if (istniejeSW)
            {
                sw.WriteLine("{0} {1}", daneRys[0], daneRys[1]/*, daneRys[2], daneRys[3], daneRys[4], daneRys[5], daneRys[6], daneRys[7], daneRys[8], daneRys[9], daneRys[10], daneRys[11]*/);
                //Lo comentado de arriba son los puertos para la lectura, en caso de necesitar mas puertos solo descomentar los necesarios
            }
        }
        //----------------------------------------------------------------

        private void cmbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int puntero = cmbPacientes.SelectedIndex;
            int punterolista = pacientes[puntero];
            btnGuardar.Enabled = true;
            btnCaptura.Enabled = true;
            var datospacientes = db.Paciente.Where(w => w.ID_Paciente == punterolista).First();
            txtNombre.Text = datospacientes.Nombre;
            txtApellido.Text = datospacientes.Apellido_Paterno + " " + datospacientes.Apellido_Materno;
            if(datospacientes.Sexo == "Mujer")
            {
                FotoPaciente.Image = Properties.Resources.UsuarioMujer;
            }
            if(datospacientes.Sexo == "Hombre")
            {
                FotoPaciente.Image = Properties.Resources.UsuarioHombre;
            }
        }

        private void drawPlot(double[] dane)
        {
            dane = filtering(dane);

            chart1.Series[0].Points.Add(dane[1]);
           

            while (chart1.Series[0].Points.Count > 1250)
            {
                chart1.Series[0].Points.SuspendUpdates();
                chart1.Series[0].Points.Remove(chart1.Series[0].Points.First());
                chart1.Series[0].Points.ResumeUpdates();
            }
        }

        private double[] ValueOrZero(double[] dane)
        {  
                dane[2] = 0;  
           
            return dane;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            VistaAyuda ayuda = new VistaAyuda();
            ayuda.Show();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            btnIniciar.Enabled = true;
        }

        //Codigo Nuevo Residencia 2
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory(Application.StartupPath);
                sw = new StreamWriter(Path.Combine(Application.StartupPath, DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".txt"));
                istniejeSW = true;
            }
            catch
            {
                MessageBox.Show("XD");
            }
            btnEscribir.Enabled = false;
            btnDetenerEsc.Enabled = true;
        }

        private void btnDetenerEsc_Click(object sender, EventArgs e)
        {
            turnOFF_SW();
            btnEscribir.Enabled = true;
            btnDetenerEsc.Enabled = false;
        }

        private void turnOFF_SW()
        {
            if (istniejeSW)
            {
                istniejeSW = false;
                sw.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = pacientes[cmbPacientes.SelectedIndex]; //Toma el id del combobox de la lista pacientes
            Form Guardar_info = new GuardarInfo(id);
            Guardar_info.ShowDialog();            
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if(trackBar1.Value == 0)
            {
                //-1V 1V
                chart1.ChartAreas[0].AxisY.Maximum = 1000000;
                chart1.ChartAreas[0].AxisY.Minimum = -1000000;
            }
            else if(trackBar1.Value == 1)
            {
                //-100mV 100mV
                chart1.ChartAreas[0].AxisY.Maximum = 100000;
                chart1.ChartAreas[0].AxisY.Minimum = -100000;
            }
            else if(trackBar1.Value == 2)
            {
                //-10mv 10mv
                chart1.ChartAreas[0].AxisY.Maximum = 10000;
                chart1.ChartAreas[0].AxisY.Minimum = -10000;
            }
            else if(trackBar1.Value == 3)
            {
                //-1mV
                chart1.ChartAreas[0].AxisY.Maximum = 1000;
                chart1.ChartAreas[0].AxisY.Minimum = -1000;
            }
            else if(trackBar1.Value == 4)
            {
                //-100uV
                chart1.ChartAreas[0].AxisY.Maximum = 100;
                chart1.ChartAreas[0].AxisY.Minimum = -100;
            }
        }

        private void btnCaptura_Click(object sender, EventArgs e)
        {
            using (var bmp = new Bitmap(PanelLectura.Width, PanelLectura.Height))
            {
                PanelLectura.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"images/" + DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".bmp");
            }
            MessageBox.Show("Captura tomada con éxito");
        }

        private void Aplicacion_Load(object sender, EventArgs e)
        {
            PanelLectura.Visible = true;
            PanelPacientes.Visible = true;
        }

        private void PanelInformacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelLectura_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private double[] filtering(double[] dane)
        {
            int standard = 0;
            int notch = 0;

            if (radioNone.Checked)
            {
                notch = 0;
            }
            else if (radio50Hz.Checked)
            {
                notch = 1;
            }
            else if (radio60Hz.Checked)
            {
                notch = 2;
            }
            if (trackBar2.Value == 4)
            {
                standard = 0;
            }
            if (trackBar2.Value == 0)
            {
                standard = 1;
            }
            if (trackBar2.Value == 1)
            {
                standard = 2;
            }
            if (trackBar2.Value == 2)
            {
                standard = 3;
            }
            if (trackBar2.Value == 3)
            {
                standard = 4;
            }

            for (int i = 0; i < 8; i++)
            {
                dane[i + 1] = Filters.FiltersSelect(standard, notch, dane[i + 1], i);
            }

            return dane;
        }
    }
}
