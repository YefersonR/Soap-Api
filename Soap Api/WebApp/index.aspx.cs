using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceUsuario.Service1Client user = new ServiceUsuario.Service1Client();

            var usuario = user.GetUsuario(1, "Mauricio Hernandez", "Calle AC", "8095117978");
                
            Lid.Text = usuario.id.ToString();
            Lnombre.Text = usuario.Nombre;
            Ldireccion.Text = usuario.Direccion;
            Ltelefono.Text = usuario.Telefono;

        }
    }
}