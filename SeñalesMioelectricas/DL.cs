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
    public class  DL    
    {
        BaseDeDatosDataContext db = new BaseDeDatosDataContext();

        public List<ReporteV> listareporte()
        {
            List<ReporteV> list = db.ReporteVs.ToList();
            return list;
        }

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


    }
}
