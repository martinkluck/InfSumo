using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Descripción breve de GestionCompra
/// </summary>
public class GestionCompra
{
    //static DataTable Carrito;
    public String ObtenerDNIUsuario(String usuario)
    {
        AccesoDatos datos = new AccesoDatos();
        String Nombre=null;
        string sql ="SELECT DNI_C FROM Clientes where NomUser="+usuario;
        using (SqlConnection conexion = datos.ObtenerConexion())
        {
            SqlCommand cmd = new SqlCommand(sql, conexion);
            try
            {
                conexion.Open();
                Nombre = (String)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        return Nombre;
    }
    public static DataTable CrearCarrito()
    {
        DataTable dt = new DataTable();
        DataColumn dc = new DataColumn("Producto", System.Type.GetType("System.Int32"));
        dt.Columns.Add(dc);
        dc = new DataColumn("Descripción",System.Type.GetType("System.String"));
        dt.Columns.Add(dc);
        dc = new DataColumn("Precio", System.Type.GetType("System.Decimal"));
        dt.Columns.Add(dc);
        dc = new DataColumn("Cantidad", System.Type.GetType("System.Int32"));
        dt.Columns.Add(dc);
        return dt;
    }
    public void EjecutarVenta(DataTable carrito, String usuario)
    {
        AccesoDatos datos = new AccesoDatos();
        SqlConnection conexion = datos.ObtenerConexion();
        GestionUsuarios usuarios = new GestionUsuarios();
        String dni = usuarios.ObtenerDNI(usuario);
        //inserta un registro en la tabla de ventas
        //por cada elemento del DataTable cesta
        String sql = "Insert into Ventas (DNI_V,Nombre_UV,Fecha) Values('" + 35231922 + "','admin','" + DateTime.Now.ToShortDateString() + "')";
        SqlCommand cmd = new SqlCommand(sql, conexion);
        cmd.ExecuteNonQuery();
        for(int i=0;i<carrito.Rows.Count;i++)
        {
            String sql2 = "Insert into VentasxArticulos ";
            sql2 += "(NumVenta_VxA,CodArt_VxA,DNI_VxA,Cantidad_VxA) Values(6,";
            sql2 += carrito.Rows[i]["Codigo"];
            sql2 += ",'" + dni + "','";
            sql2 += 1 + "')";
            SqlCommand cmd2 = new SqlCommand(sql2, conexion);
            cmd2.ExecuteNonQuery();
        }
        conexion.Close();     
    }
    public void AgregarCarrito(DataTable Carrito,Producto lb)
    {
        if (Carrito == null)
        {
            CrearCarrito();
        }
        else
        {
            DataRow dr = Carrito.NewRow();
            dr["Producto"] = lb.Produc;
            dr["Descripcion"] = lb.Descripcion;
            dr["Precio"] = lb.Precio;
            lb.Cantidad += 1;
            dr["Cantidad"] = lb.Cantidad;
            Carrito.Rows.Add(dr);
        }
    }
    public void EliminaCarrito(DataTable Carrito, int pos)
    {
        Carrito.Rows.RemoveAt(pos);
        if (Carrito.Rows.Count == 0)
            Carrito = null;
    }

    //public DataTable getCarrito() { return Carrito;}

}