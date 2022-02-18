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

        public static DataTable Trae_DatosPorPaciente(int id)
        {
            string Query = "[dbo].[Trae_DatosPorPaciente]";
            DataTable password;
            SqlParameter[] Par = new SqlParameter[1];
            Par[0] = new SqlParameter("@id", SqlDbType.Int);
            Par[0].Value = id;


            return password = SqlHelper.ExecuteDataset(conex, CommandType.StoredProcedure, Query, Par).Tables[0];


        }

        public static void Eliminar_Paciente(int id)
        {
            string Query = "[dbo].[Eliminar_Paciente]";
           
            SqlParameter[] Par = new SqlParameter[1];
            Par[0] = new SqlParameter("@id", SqlDbType.Int);
            Par[0].Value = id;


            SqlHelper.ExecuteDataset(conex, CommandType.StoredProcedure, Query, Par);

        }

        public static void InsertaUsuario(string Nombre
        ,int Sexo
        ,int Gestante
        ,int Actividad_fisica
        ,int Diabetico
        ,int Medicamento
        ,int Edad)
        {
            string Query = "dbo.InsertaPaciente";
            SqlParameter[] Par = new SqlParameter[10];
            Par[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
            Par[0].Value = Nombre;
            Par[1] = new SqlParameter("@Sexo", SqlDbType.Int);
            Par[1].Value = Sexo;
            Par[2] = new SqlParameter("@Gestante", SqlDbType.Int);
            Par[2].Value = Gestante;
            Par[3] = new SqlParameter("@Actividad_fisica", SqlDbType.Int);
            Par[3].Value = Actividad_fisica;
            Par[4] = new SqlParameter("@Diabetico", SqlDbType.Int);
            Par[4].Value = Diabetico;
            Par[5] = new SqlParameter("@Medicamento", SqlDbType.Int);
            Par[5].Value = Medicamento;
            Par[6] = new SqlParameter("@Edad", SqlDbType.Int);
            Par[6].Value = Edad;


            SqlHelper.ExecuteDataset(conex, CommandType.StoredProcedure, Query, Par);

        }

        public static void EditarUsuario(int id , string Nombre
        , int Sexo
        , int Gestante
        , int Actividad_fisica
        , int Edad
        , int Diabetico
        , int Medicamento
        , string Notas)
        {
            string Query = "dbo.Editar_Paciente";
            SqlParameter[] Par = new SqlParameter[10];
            Par[0] = new SqlParameter("@IDPaciente", SqlDbType.Int);
            Par[0].Value = id;
            Par[1] = new SqlParameter("@Nombre", SqlDbType.VarChar);
            Par[1].Value = Nombre;
            Par[2] = new SqlParameter("@Sexo", SqlDbType.Int);
            Par[2].Value = Sexo;
            Par[3] = new SqlParameter("@Gestante", SqlDbType.Int);
            Par[3].Value = Gestante;
            Par[4] = new SqlParameter("@Actividad", SqlDbType.Int);
            Par[4].Value = Actividad_fisica;
            Par[5] = new SqlParameter("@Edad", SqlDbType.Int);
            Par[5].Value = Edad;
            Par[6] = new SqlParameter("@Diabetico", SqlDbType.Int);
            Par[6].Value = Diabetico;
            Par[7] = new SqlParameter("@Medicamento", SqlDbType.Int);
            Par[7].Value = Medicamento;
            Par[8] = new SqlParameter("@Notas", SqlDbType.Int);
            Par[8].Value = Notas;

            SqlHelper.ExecuteDataset(conex, CommandType.StoredProcedure, Query, Par);

        }




        public static void InsertaHistorial(int IdPaciente
            ,string promedio, int Dolor_Percibido)
        {
            string Query = "dbo.Insertar_Historial";
            SqlParameter[] Par = new SqlParameter[10];
            Par[0] = new SqlParameter("@IdPaciente", SqlDbType.Int);
            Par[0].Value = IdPaciente;
            Par[1] = new SqlParameter("@Promedio", SqlDbType.VarChar);
            Par[1].Value = promedio;
            Par[2] = new SqlParameter("@Dolor_Percibido", SqlDbType.Int);
            Par[2].Value = Dolor_Percibido;


            SqlHelper.ExecuteDataset(conex, CommandType.StoredProcedure, Query, Par);

        }

        public static DataTable Trae_Reporte()
        {

            DataTable dtReporte;
            string Query = "[dbo].[ReporteGeneralPacientes]";
            return dtReporte = SqlHelper.ExecuteDataset(conex, CommandType.StoredProcedure, Query).Tables[0];

        }
    }
}                   