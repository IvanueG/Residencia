using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeñalesMioelectricas
{
    public partial class EditarPaciente : Form
    {
        //Señales_MioelectricasEntities db = new Señales_MioelectricasEntities();
        BaseDeDatosDataContext db = new BaseDeDatosDataContext();
        List<int> pacientes = new List<int>();
        int punterolista;

        //Variable para actualizacion de la aplicacion con base de datos
        string UsuarioPrueba; 

        public EditarPaciente()
        {
            InitializeComponent();

        }

        public EditarPaciente(int id,string user)
        {
            ////Prueba de actualizacion de datos de pacientes
            //UsuarioPrueba = user;

            //InitializeComponent();
            //this.MaximizeBox = false;

            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            //this.Width = 547;

            //this.Height = 544;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {



        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Prueba de actualizacion de datos de pacientes
            Aplicacion form = new Aplicacion(UsuarioPrueba);
            form.Show();
            this.Close();
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditarPaciente_Load(object sender, EventArgs e)
        {
            DataTable CargaCombo = DL.Trae_Reporte();


            DataRow ren = CargaCombo.NewRow();
            ren["ID_Paciente"] = 0;
            ren["Nombre"] = "-Seleccione";
            cmbUsuarios.DataSource = CargaCombo;
            cmbUsuarios.DisplayMember = "Nombre";
            cmbUsuarios.ValueMember = "ID_Paciente";
            cmbUsuarios.SelectedValue = 0;
        }

        private void cmbUsuarios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable CargaCombo = DL.Trae_DatosPorPaciente(int.Parse(cmbUsuarios.SelectedValue.ToString()));

            txtNombre.Text = CargaCombo.Rows[0]["Nombre"].ToString();
            cmbMedicamentos.SelectedIndex = int.Parse(CargaCombo.Rows[0]["Medicamento"].ToString());
            cmbDiabetico.SelectedIndex = int.Parse(CargaCombo.Rows[0]["Diabetico"].ToString());
            cmbGestante.SelectedIndex = int.Parse(CargaCombo.Rows[0]["Gestante"].ToString());
            cmbActFisica.SelectedIndex = int.Parse(CargaCombo.Rows[0]["Actividad_Fisica"].ToString());
            txtEdad.Text = CargaCombo.Rows[0]["Edad"].ToString();

            int sexo = int.Parse(CargaCombo.Rows[0]["Sexo"].ToString());

            if (sexo == 0) { radioFemenino.Checked = true;}
            else {radioMasculino.Checked = true;}
        }

        public void LimparControles()
        {
            cmbUsuarios.Text = "Seleccione";
            txtNombre.Text = "";
            radioFemenino.Checked = false;
            radioMasculino.Checked = false;
            cmbGestante.Text = "";
            cmbActFisica.Text = "";
            txtEdad.Text = "";
            cmbDiabetico.Text = "";
            cmbMedicamentos.Text = "";
        }

        public bool ValidarCampos()
        {
            if (
             cmbActFisica.SelectedIndex == -1 ||
             cmbDiabetico.SelectedIndex == -1 ||
             cmbGestante.SelectedIndex == -1 ||
             cmbMedicamentos.SelectedIndex == -1 ||
             txtNombre.Text == "" ||
             txtEdad.Text == "" ||
             radioFemenino.Checked == false &&
             radioMasculino.Checked == false
            )
            {
                MessageBox.Show("Favor de llenar todos los campos");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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


                    DL.EditarUsuario(
                        int.Parse(cmbUsuarios.SelectedValue.ToString())
                        , txtNombre.Text
                        , sexo
                        , cmbGestante.SelectedIndex
                        , cmbActFisica.SelectedIndex
                        , int.Parse(txtEdad.Text)
                        , cmbDiabetico.SelectedIndex
                        , cmbMedicamentos.SelectedIndex
                    );

                    MessageBox.Show("Paciente Editado correctamente");
                    LimparControles();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error" + x); ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditarPaciente E = new EditarPaciente();
            E.Close();
            Aplicacion a = new Aplicacion();
            a.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Eliminar", "Seguro que desea eliminar usuario?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    DL.Eliminar_Paciente(int.Parse(cmbUsuarios.SelectedValue.ToString()));
                }
                else if (MessageBox.Show("Eliminar", "Seguro que desea eliminar usuario?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error al borrar usuario ya que cuenta con un historial favor de comunicarse con IT si requiere borrar usuario" + x);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                MessageBox.Show("Solo se admiten datos numéricos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
    
}
