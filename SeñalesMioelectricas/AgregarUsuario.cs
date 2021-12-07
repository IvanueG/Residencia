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

        public AgregarPaciente(int id,string user)
        {
            //Prueba de actualizacion de datos de pacientes
            UsuarioPrueba = user;

            InitializeComponent();
            this.MaximizeBox = false;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.Width = 547;

            this.Height = 489;

            idMedico = db.Medico.Where(w => w.ID_User == id).Select(s => s.ID_Medico).FirstOrDefault();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DL.InsertaUsuario(
                txtNombre.Text
                , cmbSexo.SelectedIndex
                , cmbGestante.SelectedIndex
                , cmbActFisica.SelectedIndex
                , cmbDiabetico.SelectedIndex
                , cmbMedicamentos.SelectedIndex
                );

                MessageBox.Show("Paciente registrado exitosamente");
            }
            catch(Exception)
            {
                MessageBox.Show("Error al consultar, validar con IT");
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
