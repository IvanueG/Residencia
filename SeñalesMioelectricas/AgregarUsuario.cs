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
            catch(Exception x)
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
    }
}
