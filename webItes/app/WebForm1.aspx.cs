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
    public partial class WebForm1 : System.Web.UI.Page
    {

        string documento, nombre, apellido,email,direccion,telefono;
        int estado = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }
           
            if (Session["Carga"] == null || Session["Carga"] != "1")
            {

                TextBoxDNI.Text = Convert.ToString(Session["dni"]);
                TextBoxNombre.Text = Convert.ToString(Session["nombre"]);

                /*  activo.SelectedValue = Convert.ToString(rs["i_GaleriaStatus"]);
                tipo.SelectedValue = Convert.ToString(rs["i_Tipo"]);
                categoria.SelectedValue = Convert.ToString(rs["i_Categoria"]);*/
                cargarDatos();
                Session["Carga"] = "1";
            
            }
            /*if (estado == 0)
            {
                TextBoxDNI.Text = (string)Session["dni"];
                TextBoxNombre.Text = (string)Session["nombre"];
                
                //TextBoxApellido.Text = (string)Session["apellido"];
                //TextBoxEmail.Text = (string)Session["correo"];
                //TextBoxDireccion.Text = (string)Session["direccion"];
                //TextBoxTelefono.Text = (string)Session["telefono"];
                Session.Remove("nombre");
                /*documento = (string)Session["dni"];
                nombre = (string)Session["nombre"];

                apellido = (string)Session["apellido"];
                email = (string)Session["correo"];
                direccion = (string)Session["direccion"];
                telefono = (string)Session["telefono"];
                cargarDatos();
                estado = 1;
            }*/
        }

        protected void cargarDatos()
        {
            documento = (string)Session["dni"];
            TextBoxDNI.Text = documento;
            nombre = (string)Session["nombre"];
            TextBoxNombre.Text = nombre;
            apellido = (string)Session["apellido"];
            TextBoxApellido.Text = apellido;
            email = (string)Session["correo"];
            TextBoxEmail.Text = email;
            direccion = (string)Session["direccion"];
            TextBoxDireccion.Text = direccion;
            telefono = (string)Session["telefono"];
            TextBoxTelefono.Text = telefono;
            
        }   
        
        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            int dni = Int32.Parse((string)Session["dni"]);
             
            Session["nombreEditar"] = TextBoxNombre.Text;
            SqlDataAdapter da = new SqlDataAdapter("UPDATE alumnos SET nombre='"+ TextBoxNombre.Text + "',apellido='"+ TextBoxApellido.Text + 
                "',mail='"+ TextBoxEmail.Text + "',direccion ='" + TextBoxDireccion.Text + "',telefono= '" + TextBoxTelefono.Text + "' where id_alumno=" + dni
                , Conexion.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            Session["Carga"] = null;
            Response.Redirect("Listado.aspx");
        }

        protected void ButtonVolver_Click(object sender, EventArgs e)
        {
            Session["Carga"] = null;
            Response.Redirect("Listado.aspx");
        }
       
        protected void TextBox1_TextChanged(object sender, System.EventArgs e)
        {


        }


    }
}