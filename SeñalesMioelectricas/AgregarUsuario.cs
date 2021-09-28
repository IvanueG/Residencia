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
        Señales_MioelectricasEntities db = new Señales_MioelectricasEntities();
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
            string NombrePaciente, Apellido_paterno, Apellido_materno, sexo;
            
            if (txtNombre.Text != "" && txtApellidoMaterno.Text != "" && txtApellidoPaterno.Text != "" && (radioMasculino.Checked == true || radioFemenino.Checked == true))
            {
                NombrePaciente = txtNombre.Text;
                Apellido_paterno = txtApellidoPaterno.Text;
                Apellido_materno = txtApellidoMaterno.Text;
                sexo = "";
                if (radioMasculino.Checked == true)
                {
                    sexo = "Hombre";
                }
                if (radioFemenino.Checked == true)
                {
                    sexo = "Mujer";
                }

                db.Paciente.Add(new Paciente {Nombre = NombrePaciente, Apellido_Paterno = Apellido_paterno, Apellido_Materno = Apellido_materno, Sexo = sexo, ID_Medico = idMedico });
                db.SaveChanges();


                MessageBox.Show("Paciente Agregado con Exito", "Exito");

                //Prueba de actualizacion de datos de pacientes
                Aplicacion form = new Aplicacion(UsuarioPrueba);
                form.Show();

                this.Close();


            } else
                MessageBox.Show("Favor de LLenar todos los campos solicitados y no dejar ninguno en blanco", "Error Espacios en Blanco");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Prueba de actualizacion de datos de pacientes
            Aplicacion form = new Aplicacion(UsuarioPrueba);
            form.Show();
            this.Close();
        }
    }
}
