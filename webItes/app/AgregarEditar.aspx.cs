using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace webItes.app
{
    public partial class AgregarEditar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   
            if(Session["usuario"]==null)
            {
                Response.Redirect("Login.aspx");
            }
         }
    
        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            int dni = Int32.Parse(TextBoxDNI.Text);
            SqlDataAdapter da = new SqlDataAdapter("INSERT INTO alumnos(id_alumno, nombre, apellido, mail, direccion, telefono) VALUES(" + dni +", '" + TextBoxNombre.Text + "', '" +TextBoxApellido.Text + "', '" + TextBoxEmail.Text + "', '" + TextBoxDireccion.Text + "', '" + TextBoxTelefono.Text + "')", Conexion.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);

            Response.Redirect("Listado.aspx");

        }

        protected void ButtonVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Listado.aspx");
        }

    }
}