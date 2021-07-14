using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webItes.app
{
    public partial class Buscar : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            MostrarOcultarTabla(false);
            Conexion.Conectar();
        }
   
        protected void MostrarOcultarTabla(bool visibilidad){
            bool estado = visibilidad;
            
            for(int i = 0; i < 7; i++)
            {
                
                this.GridView1.Columns[i].Visible = estado;
            }
        }
        
        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            MostrarOcultarTabla(true);

            if (RadioApellido.Checked == true)
                {
                   //string palabra = "apellido";
                SqlDataSource1.SelectCommand = "SELECT * FROM alumnos WHERE apellido LIKE '%" + TextBoxBuscar.Text + "%'";
                SqlDataSource1.DataBind();
                RadioApellido.Checked = false;
            }
            else if (RadioNombre.Checked == true)
            {
                //string palabra = "nombre";
                SqlDataSource1.SelectCommand = "SELECT * FROM alumnos WHERE nombre LIKE '%" + TextBoxBuscar.Text + "%'";
                SqlDataSource1.DataBind();
                RadioNombre.Checked = false;
            }else{
                SqlDataSource1.SelectCommand = "SELECT * FROM alumnos ";
                SqlDataSource1.DataBind();
            }

        }

        protected void Atras(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }


    }
}