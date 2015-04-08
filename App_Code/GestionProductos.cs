using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de GestionLibros
/// </summary>
public class GestionProductos
{
	public GestionProductos()
	{
	}
    private DataTable ObtenerTabla(String Nombre, String Sql)
    {
        DataSet ds = new DataSet();
        AccesoDatos datos = new AccesoDatos();
        SqlDataAdapter adp = datos.ObtenerAdaptador(Sql);
        adp.Fill(ds, Nombre);
        return ds.Tables[Nombre];
    }
    public DataTable ObtenerTodosLosProductos()
    {
        return ObtenerTabla("Productos", "Select * from Articulos");
    }
    public DataTable ObtenerLibrosPorCategoria(int cat)
    {
        return ObtenerTabla("Productos", "Select * from Articulos where Categoria="+cat);
    }
    public Producto ObtenerProductoPorID(String codArt)
    {
        AccesoDatos datos = new AccesoDatos();
        SqlConnection conexion = datos.ObtenerConexion();
        SqlDataReader dr;
        String consulta = "Select * from Articulos where CodArt_A=" + codArt;
        if (conexion != null)
        {
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Producto lb = new Producto();
                    lb.Produc = (int)dr["CodArt_A"];
                    lb.Categoria = (String)dr["Categoria"];
                    lb.Descripcion = (String)dr["Descripcion"];
                    lb.Precio = (decimal)dr["PrecioUnitario"];

                    // Usando el constructor, las instrucciones anteriores podrian ser
                    // una sola como la siguiente
                    // Libro lb=new Libro((int)dr["idLibro"],(int)dr["idTema"],
                    // (String)dr["titulo"],(decimal)dr["precio"],(String)dr["autor"]);
                    return lb;
                }
                else
                    return null;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }
        else
            return null;
    }
}