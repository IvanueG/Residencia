using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeñalesMioelectricas
{
    public partial class AgregarPaciente : Form
    {
        //Señales_MioelectricasEntities db = new Señales_MioelectricasEntities();
        BaseDeDatosDataContext db = new BaseDeDatosDataContext();
        int idMedico;

        //Variable para actualizacion de la aplicacion con base de datos
        string UsuarioPrueba;

        public AgregarPaciente()
        {
            InitializeComponent();
            
        }

        public void LimparControles()
        {
            
            txtNombre.Text = "";
            radioFemenino.Checked = false;
            radioMasculino.Checked = false;
            cmbGestante.Text = "";
            cmbActFisica.Text = "";
            txtEdad.Text = "";
            cmbDiabetico.Text = "";
            cmbMedicamentos.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos() == true)
                {
                    int sexo;
                    if (radioMasculino.Checked)
                    {
                        sexo = 1;
                    }
                    else
                    {
                        sexo = 0;
                    }

                    DL.InsertaUsuario(
                    txtNombre.Text
                    , sexo
                    , cmbGestante.SelectedIndex
                    , cmbActFisica.SelectedIndex
                    , cmbDiabetico.SelectedIndex
                    , cmbMedicamentos.SelectedIndex
                    );

                    MessageBox.Show("Paciente registrado exitosamente");
                    LimparControles();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error al consultar, validar con IT " + x);
            }


        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Prueba de actualizacion de datos de pacientes
            Aplicacion form = new Aplicacion(UsuarioPrueba);
            form.Show();
            this.Close();
        }

        private void AgregarPaciente_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "Atencion",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtEdad.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "Atencion",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public bool ValidarCampos()
        {
            if (
             cmbActFisica.SelectedIndex == -1 ||
             cmbDiabetico.SelectedIndex == -1 ||
             cmbGestante.SelectedIndex == -1 ||
             cmbMedicamentos.SelectedIndex == -1||
             txtNombre.Text == ""||
             txtEdad.Text ==""||
             radioFemenino.Checked==false && 
             radioMasculino.Checked==false         
            )
            {
                MessageBox.Show("Favor de llenar todos los campos");
                return false;
            }
            else { 
            return true;
            }
        }
    }
}