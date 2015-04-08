using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLoguearse_Click(object sender, EventArgs e)
    {
        GestionUsuarios usuarios=new GestionUsuarios();
        String usuario = txtUsuario.Text;
        int cont = 0;
        if (usuarios.EstaRegistrado(txtUsuario.Text, txtContraseña.Text))
        {
            HttpCookie cookie = new HttpCookie("usuario",usuario);
            cookie.Expires = DateTime.Now.AddMinutes(5);
            this.Response.Cookies.Add(cookie);
            usuarios.NomUser = usuario;
            HttpCookie cookie2 = new HttpCookie("car", cont.ToString());
            cookie2.Expires = DateTime.Now.AddMinutes(5);
            this.Response.Cookies.Add(cookie2);
            Label1.Visible = false;
            if (txtUsuario.Text == "admin" && txtContraseña.Text == "admin")
            {

                this.Response.Redirect("Admin.aspx");
            }
            else
            {

                this.Response.Redirect("Principal.aspx");
            }
        }
        else
        {
            Label1.Visible = true;
        }
    }
    protected void btnRegistrarse_Click(object sender, EventArgs e)
    {
        this.Response.Redirect("Registro.aspx");
    }
}