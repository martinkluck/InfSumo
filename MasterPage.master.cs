using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    HttpCookie cookie;
    String usuario;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Menu2_MenuItemClick(object sender, MenuEventArgs e)
    {

    }
    protected void btnComputadoras_Click(object sender, EventArgs e)
    {
        Response.Redirect("Productos.aspx");
    }
    protected void lbCarrito_Load(object sender, EventArgs e)
    {

        //lbCarrito.Text = CarritoDeCompras.cont.ToString();
        //if ((cookie = this.Request.Cookies["car"]) != null)
        //{
        //    lbCarrito.Visible = true;
        //    lbCarrito.Text = cookie.Value;
        //    lbCarrito.Text = CarritoDeCompras.cont.ToString();
        //}
    }
    protected void lbCarrito_PreRender(object sender, EventArgs e)
    {
        lbCarrito.Text = "Carrito: " + CarritoDeCompras.cont.ToString();
    }
    protected void lbCLiente_PreRender(object sender, EventArgs e)
    {
        if ((cookie = this.Request.Cookies["usuario"]) != null)
        {
            usuario = cookie.Value;
            lbCliente.Visible = true;
            lbCliente.Text = "Usted esta logueado como: " + usuario;
            if (usuario == "admin")
            {
                lkAdmin.Visible = true;
                lbCarrito.Visible = false;
                Carrito.Visible = false;
            }
        }
    }
    protected void Carrito_Click(object sender, ImageClickEventArgs e)
    {
        this.Response.Redirect("Carrito.aspx");
    }
    protected void lkAdmin_Click(object sender, EventArgs e)
    {
        this.Response.Redirect("Admin.aspx");
    }
}
