using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeñalesMioelectricas
{
    public partial class GuardarInfo : Form
    {
        int id;
        public GuardarInfo(int id) //Toma el valor de id de la forma Aplicacion.cs
        {
            this.id = id;
            InitializeComponent();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtArchivo.Text = openFileDialog1.FileName;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreDoc.Text.Trim().Equals("") || txtArchivo.Text.Trim().Equals(""))
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }


            byte[] file = null;
            Stream myStream = openFileDialog1.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            }

            using (BaseDeDatosDataContext db = new BaseDeDatosDataContext())
            {
                documentos oDocument = new documentos();
                oDocument.Nombre_Documento = txtNombreDoc.Text.Trim();
                oDocument.Doc = file;
                oDocument.Nombre_Real = openFileDialog1.SafeFileName;
                oDocument.ID_Paciente = id; //Pone el valor de id tomado
                db.documentos.InsertOnSubmit(oDocument);
                db.SubmitChanges();
            }

            Refrescar();
        }

        private void Refrescar()
        {
            using (BaseDeDatosDataContext db = new BaseDeDatosDataContext())
            {
                var lst = from d in db.documentos
                          where id == d.ID_Paciente //Muestra los documentos especificos de la persona especifica
                          select new { d.ID_Documento,d.Nombre_Documento, d.Nombre_Real };
                dataGridView1.DataSource = lst.ToList();
            }
        }

        private void GuardarInfo_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
            Refrescar();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count>0)
            {
                int ID_Documento = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());

                using (BaseDeDatosDataContext db = new BaseDeDatosDataContext())
                {

                    //var oDocument = db.documentos.Find (ID_Documento);

                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    string folder = path + "/temp/";
                    //string fullFilePath = folder + oDocument.Nombre_Real;

                    //Validad si el folder temp existe si no lo crea
                    //if (!Directory.Exists(folder))
                    //    Directory.CreateDirectory(folder);

                    //Valida si el archivo ya existe lo abre
                    //if (File.Exists(fullFilePath))
                    //    Directory.GetAccessControl(fullFilePath);

                    //Abre el archivo con la herramienta que se encuentre instalada
                    //File.WriteAllBytes(fullFilePath, oDocument.Doc);

                    //Process.Start(fullFilePath);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}