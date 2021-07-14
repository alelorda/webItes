using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

using System.Web.UI.WebControls;

namespace webItes.app
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }
        
        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Buscar.aspx");
        }

        protected void ButtonListado_Click(object sender, EventArgs e)
        {
            Response.Redirect("Listado.aspx");
        }


        protected void ButtonCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.RemoveAll();
            Response.Redirect("Login.aspx");
        }
        

    }
}