﻿using System;
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
    
    
    public partial class Reporte : Form
    {
        DL dl = new DL();
       
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
			dataGridView1.DataSource = DL.Trae_Reporte();
        }

		private void ExportarDatos(DataGridView datalistado)
		{
			try
			{
				Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); // Instancia a la libreria de Microsoft Office
				excel.Application.Workbooks.Add(true); //Con esto añadimos una hoja en el Excel para exportar los archivos
				int IndiceColumna = 0;
				foreach (DataGridViewColumn columna in datalistado.Columns) //Aquí empezamos a leer las columnas del listado a exportar
				{
					IndiceColumna++;
					excel.Cells[1, IndiceColumna] = columna.Name;
				}
				int IndiceFila = 0;
				foreach (DataGridViewRow fila in datalistado.Rows) //Aquí leemos las filas de las columnas leídas
				{
					IndiceFila++;
					IndiceColumna = 0;
					foreach (DataGridViewColumn columna in datalistado.Columns)
					{
						IndiceColumna++;
						excel.Cells[IndiceFila + 1, IndiceColumna] = fila.Cells[columna.Name].Value;
					}
				}
				excel.Visible = true;
			}
			catch (Exception)
			{
				MessageBox.Show("No hay Registros a Exportar.");
			}
		}

		private void btnExcel_Click(object sender, EventArgs e)
        {
			ExportarDatos(dataGridView1);
		}
	}
}
