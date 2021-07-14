using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data;
using System.Data.SqlClient;

 
namespace webItes.app
{
    public class Conexion
    {
        Conexion cn;
        private SqlConnection cone;
        private SqlDataAdapter da;
        static DataTable dt;
        private SqlCommand cmd;

        public static SqlConnection Conectar()
        {
            try {         
                SqlConnection con = new SqlConnection("SERVER=DESKTOP-8SV6UFH\\SQLEXPRESS;DATABASE=ites;integrated security=true");
                con.Open();
                return con;
            }
            catch(Exception)
            {
                throw;
            }

        }

    public void Desconectar()
        {
            cone.Close();
        }
        public void CrearComando(string consulta)
        {
            cmd = new SqlCommand(consulta, cone);
        }

        public void AsignarParametro(string param, SqlDbType tipo, object val)
        {
            cmd.Parameters.Add(param, tipo).Value = val;
        }

        public int EjecutarConsulta()
        {
            return cmd.ExecuteNonQuery();
        }

        public DataTable EjecutarDataTable()
        {
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    
    }
}