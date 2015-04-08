using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Accesorios : System.Web.UI.Page
{
    CarritoDeCompras carrito = new CarritoDeCompras();
    HttpCookie cookie;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void grdProductos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int pos = int.Parse(e.CommandArgument.ToString());
            int cant = 1;
            //SI LA VARIABLE SESSION NO CONTIENE UN ELEMENTO QUE SE LLAME CARRITO ENTONCES CREA LA TABLA
            if (this.Session["carrito"] == null)
            {
                // CARGO LA VARIABLE SESSION CON LA TABLA CREADA
                this.Session["carrito"] = carrito.crearTablaEnCarrito();
            }
            //ENVIO LA TABLA A LA FUNCION AGREGAR CARRITO, AGREGAR CARRITO RECIBE LA TABLA Y LE AGREGA UNA FILA
            //if (((DataTable)(this.Session["carrito"])).Rows[]
            if ((cookie = this.Request.Cookies["usuario"]) != null)
            {
                CarritoDeCompras.cont++;
                carrito.AgregarCarrito((DataTable)(this.Session["carrito"]), Convert.ToInt32(grdProductos.Rows[pos].Cells[0].Text), grdProductos.Rows[pos].Cells[1].Text, float.Parse(grdProductos.Rows[pos].Cells[2].Text), cant);
            }
            else
            {
                Response.Write("<script language=javascript>alert('Tiene que estar logeado para comprar.');</script>");
            }

        }
        //if (e.CommandName == "Select")
        //{
        //    int pos = int.Parse(e.CommandArgument.ToString());
        //    GestionCompra gc = new GestionCompra();
        //    GestionProductos gl = new GestionProductos();
        //    //crea el objeto libro a partir del idLibro, el
        //    //cuál aparece en la segunda columna del GridView
        //    Producto lb = gl.ObtenerProductoPorID(grdProductos.Rows[pos].Cells[0].Text);
        //    gc.AgregarCarrito((DataTable)this.Session["carrito"], lb);
        //}
    }
}