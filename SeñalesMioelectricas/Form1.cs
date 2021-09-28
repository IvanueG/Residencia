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
            txtUsuario.Text = "Usuario";
            txtUsuario.ForeColor = Color.LightGray;
            txtContraseña.Text = "Contraseña";
            txtContraseña.ForeColor = Color.LightGray;
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
                    txtUsuario.ForeColor = Color.Black;
                }
            }

            if (txtContraseña.ContainsFocus == true)
            {
                if (txtContraseña.Text == "Contraseña")
                {
                    txtContraseña.Text = "";
                    txtContraseña.ForeColor = Color.Black;
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
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.LightGray;
            }

            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.LightGray;
            }
        }

        //Boton Iniciar Sesion
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            
            usuario = txtUsuario.Text;
            contraseña = txtContraseña.Text;

            if (Login(usuario, contraseña) == true)
            {
                Aplicacion form = new Aplicacion(usuario);
                form.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Usuario y/o Contraseña Incorrectos", "Error Inicio de Sesion");
            
        }

        //Conexion a la BD para comprobar si los datos son correctos en el Inicio de Sesion
        public bool Login(string usuario, string contraseña)
        {
           Señales_MioelectricasEntities db = new Señales_MioelectricasEntities();
           var usuario1 = db.Usuario.Where(u => u.Usuario1 == usuario && u.Contraseña==contraseña).ToList();
            
            
            if ( usuario1.Count() != 0 )
            {
                return true;
            }
            else
                return false;
                
        }
    }
}
