using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de AccesoDatos
/// </summary>
public class AccesoDatos
{
    String rutaBDLibreria ="Data Source=MARTIN-PC;Initial Catalog=InfSumo;Integrated Security=True";

    public AccesoDatos()
	{
		// TODO: Agregar aquí la lógica del constructor
	}

    public SqlConnection ObtenerConexion()
    {
        SqlConnection cn = new SqlConnection(rutaBDLibreria);
        try
        {
            cn.Open();
            return cn;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }
    public SqlDataAdapter ObtenerAdaptador(String consultaSql)
    {
        SqlDataAdapter adaptador;
        try
        {
            adaptador=new SqlDataAdapter(consultaSql,rutaBDLibreria);
            return adaptador;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    public String ObtenerRutaLibreria()
    {
        return rutaBDLibreria;
    }
}