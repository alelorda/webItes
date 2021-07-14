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
    public partial class Listado1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            { 
                Response.Redirect("Login.aspx");
            }
            LabelConfirmacion.Visible = false;
            ButtonConfirm.Visible = false;
            ButtonRechazar.Visible = false;
        }
        
        protected void ButtonVer_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarEditar.aspx");
        }
            
        protected void ButtonModificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void ButtonVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["dni"] = GridView1.SelectedRow.Cells[1].Text;
            Session["nombre"] = GridView1.SelectedRow.Cells[2].Text;
            Session["apellido"] = GridView1.SelectedRow.Cells[3].Text;
            Session["correo"] = GridView1.SelectedRow.Cells[4].Text;
            Session["direccion"] = GridView1.SelectedRow.Cells[5].Text;
            Session["telefono"] = GridView1.SelectedRow.Cells[6].Text;

        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            LabelConfirmacion.Visible = true;
            ButtonConfirm.Visible = true;
            ButtonRechazar.Visible = true;
        }

        protected void ButtonConfirm_Click(object sender, EventArgs e)
        {
            string dni = GridView1.SelectedRow.Cells[1].Text;
            int id_alumno = Int32.Parse(dni);
            SqlDataAdapter da = new SqlDataAdapter("delete from alumnos where id_alumno = " + id_alumno, Conexion.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            Response.Redirect("Listado.aspx");
        }
        protected void ButtonRechazar_Click(object sender, EventArgs e)
        {
            LabelConfirmacion.Visible = false;
            ButtonConfirm.Visible = false;
            ButtonRechazar.Visible = false;
        }
        protected void TextBox1_TextChanged(object sender,EventArgs e)
        {

        }
    }
}