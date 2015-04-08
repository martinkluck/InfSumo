using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

public partial class Carrito : System.Web.UI.Page
{
    GestionCompra compra = new GestionCompra();
    String usuario;
    HttpCookie cookie;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (this.Session["carrito"] == null || ((DataTable)this.Session["carrito"]).Rows.Count == 0)
        {
            lnkEjecutarCompra.Visible = false;
        }
        else
        {
            lnkEjecutarCompra.Visible = true;

        }
        grdCarrito.DataSource = (DataTable)this.Session["carrito"];
        grdCarrito.DataBind();
    }

    private void ActualizaCarrito()
    {
        //vincula el GridView al DataTable de la cesta
        if (this.Session["carrito"] == null || ((DataTable)this.Session["carrito"]).Rows.Count == 0)
        {
            lnkEjecutarCompra.Visible = false;
        }
        else
        {
            lnkEjecutarCompra.Visible = true;

        }
        grdCarrito.DataSource = (DataTable)this.Session["carrito"];
        grdCarrito.DataBind();

    }
    protected void lnkEjecutarCompra_Click(object sender, EventArgs e)
    {
        if ((cookie = this.Request.Cookies["usuario"]) != null)
        {
            usuario = cookie.Value;
            compra.EjecutarVenta((DataTable)this.Session["carrito"], usuario);
        }
        else
        {
            Label1.Text = "Usted no esta logeado.";
        }

    }
    protected void grdCarrito_SelectedIndexChanged(object sender, EventArgs e)
    {
        int f = grdCarrito.SelectedIndex;
        GestionCompra gc = new GestionCompra();
        gc.EliminaCarrito((DataTable)this.Session["carrito"], f);
        CarritoDeCompras.cont--;
        ActualizaCarrito();
    }

    int total = 0;
    float imp = 0;

    private void cargar()
    {
        foreach (GridViewRow item in grdCarrito.Rows)
        {
            if (item.Cells[0].Text != null)
            {
                Single precio = Convert.ToSingle(item.Cells[3].Text);
                int Cantidad = Convert.ToInt32(item.Cells[4].Text);
                total += Convert.ToInt32(item.Cells[4].Text);
                imp += (precio * Cantidad);
            }
        }
    }
    //protected void lnkEjecutarCompra_Click(object sender, EventArgs e)
    //{
    //    AccesoDatos datos = new AccesoDatos();
    //    SqlConnection conn = datos.ObtenerConexion();
    //    Boolean OperacionExitosa = true;
    //    int NumVenta = 0;
    //    GestionUsuarios usuarios = new GestionUsuarios();

    //    //Grabar en la Cabecera

    //    //if ((cookie = this.Request.Cookies["usuario"]) != null)
    //    //{
    //    //    usuario = cookie.Value;
    //    //}
    //    //else
    //    //{
    //    //    Label1.Text = "Usted no esta logeado.";
    //    //}
    //    cookie = this.Request.Cookies["usuario"];
    //    usuario=cookie.Value;
    //    String CodCLi = usuarios.ObtenerDNI(usuario);

    //    SqlCommand CmdVenta = new SqlCommand("AgregarVenta", conn);
    //    CmdVenta.CommandType = CommandType.StoredProcedure;

    //    cargar();

    //    CmdVenta.Parameters.AddWithValue("DNI_V", CodCLi);
    //    CmdVenta.Parameters.AddWithValue("Nombre_UV", usuario);
    //    CmdVenta.Parameters.AddWithValue("Total", total);
    //    CmdVenta.Parameters.AddWithValue("Importe", imp);
    //    CmdVenta.Parameters.AddWithValue("Fecha", DateTime.Now.ToShortDateString());
    //    CmdVenta.Parameters.AddWithValue("NumVenta", 0);
    //    CmdVenta.Parameters["NumVenta"].Direction = ParameterDirection.Output;

    //    int Filas = 0;

    //    try
    //    {
    //        conn.Open();
    //        SqlTransaction tx = conn.BeginTransaction();
    //        CmdVenta.Transaction = tx;
    //        Filas = CmdVenta.ExecuteNonQuery();

    //        if (Filas != 0)
    //        {
    //            NumVenta = Convert.ToInt32(CmdVenta.Parameters["NumVenta"].Value);
    //            SqlCommand CmdVxA = new SqlCommand("AgregarVentaxArt", conn);
    //            CmdVxA.CommandType = CommandType.StoredProcedure;
    //            CmdVxA.Transaction = tx;

    //            CmdVxA.Parameters.Add(new SqlParameter("NumVenta_VxA", SqlDbType.Int, 4));
    //            CmdVxA.Parameters.Add(new SqlParameter("CodArt_VxA", SqlDbType.Int, 4));
    //            CmdVxA.Parameters.Add(new SqlParameter("Cantidad_VxA", SqlDbType.Int, 4));
    //            CmdVxA.Parameters.Add(new SqlParameter("DNI_VxA", SqlDbType.Char, 8));

    //            //SqlCommand CmdActualizar=new SqlCommand("")

    //            //Grabar en el Detalle
    //            foreach (GridViewRow item in grdCarrito.Rows)
    //            {
    //                if (item.Cells[0].Text != null)
    //                {
    //                    //total += Convert.ToInt32(item.Cells[3].Value);
    //                    int CodProd = Convert.ToInt32(item.Cells[1].Text);
    //                    Single Precio = Convert.ToSingle(item.Cells[3].Text);
    //                    int Cantidad = Convert.ToInt32(item.Cells[4].Text);
    //                    //imp += (Precio * Cantidad);

    //                    CmdVxA.Parameters["NumVenta_VxA"].Value = NumVenta;
    //                    CmdVxA.Parameters["DNI_VxA"].Value = CodCLi;
    //                    CmdVxA.Parameters["CodArt_VxA"].Value = CodProd;
    //                    CmdVxA.Parameters["Cantidad_VxA"].Value = Cantidad;


    //                    Filas = CmdVxA.ExecuteNonQuery();

    //                    if (Filas != 0)
    //                    {

    //                    }
    //                    else
    //                    {
    //                        OperacionExitosa = false;
    //                        return;
    //                    }
    //                }

    //            }
    //        }

    //        if (OperacionExitosa)
    //        {
    //            tx.Commit();
    //            Label1.Text = CmdVenta.Parameters["NumVenta"].Value.ToString();
    //        }
    //        else
    //        {
    //            tx.Rollback();
    //        }

    //    }
    //    catch (Exception ex)
    //    {
    //        Label1.Text=ex.Message;
    //    }
    //    finally
    //    {
    //        if (conn.State != ConnectionState.Closed)
    //        {
    //            conn.Close();
    //        }
    //    }
    //}
}