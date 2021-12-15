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
    public partial class VistaAyuda : Form
    {
        public VistaAyuda()
        {
            InitializeComponent();
            PanelPlaca.Visible = true;
            PanelElectrodos.Visible = false;
            //Fija el Tamaño de la Ventana de Inicio de Sesion y se impide el tamaño de ventana completa.
            this.MaximizeBox = false;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.Width = 1165;

            this.Height = 489;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            PanelPlaca.Visible = false;
            PanelElectrodos.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            PanelElectrodos.Visible = false;
            PanelPlaca.Visible = true;
        }

        private void VistaAyuda_Load(object sender, EventArgs e)
        {

        }
    }
}
