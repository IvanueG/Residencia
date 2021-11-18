using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Librerias;

namespace SeñalesMioelectricas
{
    public class DL
    {
        BaseDeDatosDataContext db = new BaseDeDatosDataContext();

        public static string conex = Conecciones();
        public static string Conecciones()
        {
            string cs = "Data Source=localhost;Initial Catalog=Señales_Mioelectricas;User Id=SA;Password=Aaya98020415;";
            return cs;
        }

        public static DataTable Trae_UsuarioPass(string Usuario)
        {
            string Query = "dbo.Trae_Reporte";
            DataTable password;
            SqlParameter[] Par = new SqlParameter[1];

            Par[0] = new SqlParameter("@usuario", SqlDbType.NVarChar);
            Par[0].Value = Usuario;

           
            return password = SqlHelper.ExecuteDataset(conex, CommandType.StoredProcedure, Query, Par).Tables[0];


        }

        public static void InsertaUsuario(string Nombre
        ,string Apellido_Paterno
        ,string Apellido_Materno
        ,int Sexo
        ,int Gestante
        ,int Actividad_fisica
        ,int Diabetico
        ,int Medicamento)
        {
            string Query = "dbo.InsertaPaciente";
            SqlParameter[] Par = new SqlParameter[10];
            Par[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
            Par[0].Value = Nombre;
            Par[1] = new SqlParameter("@Apellido_Paterno", SqlDbType.VarChar);
            Par[1].Value = Apellido_Paterno;
            Par[2] = new SqlParameter("@Apellido_Materno", SqlDbType.VarChar);
            Par[2].Value = Apellido_Materno;
            Par[3] = new SqlParameter("@Sexo", SqlDbType.Int);
            Par[3].Value = Sexo;
            Par[4] = new SqlParameter("@Gestante", SqlDbType.Int);
            Par[4].Value = Gestante;
            Par[5] = new SqlParameter("@Actividad_fisica", SqlDbType.Int);
            Par[5].Value = Actividad_fisica;
            Par[6] = new SqlParameter("@Diabetico", SqlDbType.Int);
            Par[6].Value = Diabetico;
            Par[7] = new SqlParameter("@Medicamento", SqlDbType.Int);
            Par[7].Value = Medicamento;

            SqlHelper.ExecuteDataset(conex, CommandType.StoredProcedure, Query, Par);


        }

        public static DataTable Trae_Reporte()
        {

            DataTable dtReporte;
            string Query = "dbo.ReporteGeneralPacientes";
            return dtReporte = SqlHelper.ExecuteDataset(conex, CommandType.StoredProcedure, Query).Tables[0];

        }


    }
}
