using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace webItes.app
{
    
    public partial class Login : System.Web.UI.Page
    {
        public string correo;
        Conexion bd = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelIncorrecta.Visible = false;
            Conexion.Conectar();
        }

        protected void ButtonAcceder(object sender, EventArgs e)
        {
            Conexion.Conectar();
            
            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*)FROM USUARIO WHERE usuario ='"+ TextBoxUsuario.Text + "'AND clave= '"+ TextBoxContrasenia.Text+"'",Conexion.Conectar() );
            DataTable dt = new DataTable();
            

            da.Fill(dt);

            if(dt.Rows [0][0].ToString() == "1")
            {

                SqlDataAdapter dato = new SqlDataAdapter("SELECT tipo_usuario FROM USUARIO WHERE usuario ='" + TextBoxUsuario.Text + "'AND clave= '" + TextBoxContrasenia.Text + "'", Conexion.Conectar());
                DataTable dto = new DataTable();


                dato.Fill(dto);
                Session["usuario"] = TextBoxUsuario.Text;
                Session["permisos"] = dto;
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                LabelIncorrecta.Visible = true;
            }
            
        }
    }
}