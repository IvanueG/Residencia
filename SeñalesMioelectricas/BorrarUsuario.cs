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
    public partial class BorrarPaciente : Form
    {
        Señales_MioelectricasEntities db = new Señales_MioelectricasEntities();
        List<int> pacientes = new List<int>();
        int punterolista;

        //Variable para actualizacion de la aplicacion con base de datos
        string UsuarioPrueba;

        public BorrarPaciente()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.Width = 547;

            this.Height = 512;
        }

        public BorrarPaciente(int id,string user)
        {
            //Prueba de actualizacion de datos de pacientes
            UsuarioPrueba = user;

            InitializeComponent();
            this.MaximizeBox = false;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.Width = 547;

            this.Height = 512;

            var usuario = db.Medico.Where(c => c.ID_User == id).FirstOrDefault();

            var nombrespacientes = db.Paciente.Where(w => w.ID_Medico == usuario.ID_Medico).ToList();

            pacientes.Clear();
            foreach (var name in nombrespacientes)
            {
                cmbPaciente.Items.Add(name.Nombre + " " + name.Apellido_Paterno + " " + name.Apellido_Materno);
                pacientes.Add(name.ID_Paciente);
            }

            cmbPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            var paciente = db.Paciente.Where(w => w.ID_Paciente == punterolista).First();
            db.Paciente.Remove(paciente);
            db.SaveChanges();

            MessageBox.Show("Paciente eliminado con Exito", "Eliminado");

            //Prueba para actualizacion de datos de pacientes               
            Aplicacion form = new Aplicacion(UsuarioPrueba);
            form.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Prueba para actualizacion de datos de pacientes               
            Aplicacion form = new Aplicacion(UsuarioPrueba);
            form.Show();
            this.Close();
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int puntero = cmbPaciente.SelectedIndex;
            punterolista = pacientes[puntero];
            var datospacientes = db.Paciente.Where(w => w.ID_Paciente == punterolista).First();
            txtNombre.Text = datospacientes.Nombre;
            txtApellidoPaterno.Text = datospacientes.Apellido_Paterno;
            txtApellidoMaterno.Text = datospacientes.Apellido_Materno;
            if (datospacientes.Sexo == "Mujer")
            {
                radioFemenino.Checked = true;
                radioMasculino.Checked = false;
            }
            if (datospacientes.Sexo == "Hombre")
            {
                radioMasculino.Checked = true;
                radioFemenino.Checked = false;
            }
        }
    }
}
