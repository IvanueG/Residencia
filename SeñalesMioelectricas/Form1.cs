using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SeñalesMioelectricas
{
    public partial class Form1 : Form
    {
        //Variables
        string usuario, contraseña;
        
        public Form1()
        {
            InitializeComponent();
            //Fija el Tamaño de la Ventana de Inicio de Sesion y se impide el tamaño de ventana completa.
            this.MaximizeBox = false;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.Width = 816;

            this.Height = 489;
            usuario = "";
            contraseña = "";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Se Agrega una Especie de "PlaceHolder" a Cada Textbox
            //Agregando Acciones Cuando Ocurren Ciertos Eventos.
            txtUsuario.Text = "Ingresa un Usuario";
            txtUsuario.ForeColor = Color.DarkGray;
            txtContraseña.Text = "Contraseña";
            txtContraseña.ForeColor = Color.DarkGray;
            txtUsuario.GotFocus += new EventHandler(this.TextGotFocus);
            txtUsuario.LostFocus += new EventHandler(this.TextLostFocus);
            txtContraseña.GotFocus += new EventHandler(this.TextGotFocus);
            txtContraseña.LostFocus += new EventHandler(this.TextLostFocus);
        }

        //Evento Cuando el Textbox Esta en Foco
        public void TextGotFocus(object sender, EventArgs e)
        {
            //Si el Texto Esta en Foco y Tiene Escrito el Texto Por Defecto 
            //Entonces Limpia el Textbox.
            if(txtUsuario.ContainsFocus == true)
            {
                if (txtUsuario.Text == "Usuario")
                {
                    txtUsuario.Text = "";
                    txtUsuario.ForeColor = Color.DarkGray;
                }
            }

            if (txtContraseña.ContainsFocus == true)
            {
                if (txtContraseña.Text == "Contraseña")
                {
                    txtContraseña.Text = "";
                    txtContraseña.ForeColor = Color.DarkGray;
                }
            }

        }

        //Evento Cuando el Textbox Deja de Estar en Foco
        public void TextLostFocus(object sender, EventArgs e)
        {
            //Si el Textbox Deja de Estar en Foco y Ademas el Texto se 
            //Encuentra en Limpio, Entonces Agrega el Texto Por Defecto.
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingresa un Usuario";
                txtUsuario.ForeColor = Color.DarkGray;
            }

            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DarkGray;
            }
        }

        //Boton Iniciar Sesion
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            //usuario = txtUsuario.Text;
            //contraseña = txtContraseña.Text;

            //if (Login(usuario, contraseña) == true)
            //{
            //    Aplicacion form = new Aplicacion(usuario);
            //    form.Show();
            //    this.Hide();
            //}
            //else
            //    MessageBox.Show("Usuario y/o Contraseña Incorrectos", "Error Inicio de Sesion");

            DataTable pass = DL.Trae_UsuarioPass(txtUsuario.Text);
            string pass1 = pass.Rows[0]["Contraseña"].ToString();

            if (pass1 == txtContraseña.Text)
            {
                Aplicacion form = new Aplicacion(usuario);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrectos", "Error Inicio de Sesion");
            }


        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
        }


        //Conexion a la BD para comprobar si los datos son correctos en el Inicio de Sesion
        public bool Login(string usuario, string contraseña)
        {
            //Señales_MioelectricasEntities db = new Señales_MioelectricasEntities();
            //Señales_MioelectricasDataSet db = new Señales_MioelectricasDataSet();
            BaseDeDatosDataContext db = new BaseDeDatosDataContext();
           var usuario1 = db.Usuarios.Where(u => u.Usuario1 == usuario && u.Contraseña==contraseña).ToList();
            
            
            if ( usuario1.Count() != 0 )
            {
                return true;
            }
            else
                return false;
                
        }
    }
}
