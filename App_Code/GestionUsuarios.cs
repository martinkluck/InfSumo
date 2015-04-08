using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de GestionUsuarios
/// </summary>
public class GestionUsuarios
{
    //esta clase contiene los métodos para
    //operar con la tabla de clientes

    public static String usuario;

    public String NomUser
    {
        get
        { return usuario; }
        set
        { usuario = value; }
    }
    public GestionUsuarios()
    {
    }
    public bool GrabarUsuario(Usuario usr)
    {
        AccesoDatos datos = new AccesoDatos();
        SqlConnection cn = datos.ObtenerConexion();
        if (cn != null)
        {
            SqlCommand cmd;
            String sql = "execute AgregarCliente";
            sql += "'" + usr.DNI + "',";
            sql += "'" + usr.NomUser + "',";
            sql += "'" + usr.Clave + "',";
            sql += "'" + usr.Nombre + "',";
            sql += "'" + usr.Apellido + "',";
            sql += "'" + usr.Email + "',";
            sql += "'" + usr.Telefono + "',";
            sql += "'" + usr.Direccion + "',";
            sql += usr.Estado;
            cmd = new SqlCommand(sql, cn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                cn.Close();
            }
        }
        else
            return false;
    }
    public bool EstaRegistrado(String usuario, String clave)
    {
        AccesoDatos datos = new AccesoDatos();
        SqlConnection cn = datos.ObtenerConexion();
        SqlCommand cmd;
        SqlDataReader dr;
        String sql =
        "Select * From Clientes Where NomUser='" + usuario + "' AND Clave='" + clave + "'";
        if (cn != null)
        {
            cmd = new SqlCommand(sql, cn);
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                cn.Close();
            }
        }
        else
            return false;
    }

    public String ObtenerDNI(String usuario)
    {
        AccesoDatos datos = new AccesoDatos();
        SqlConnection cn = datos.ObtenerConexion();
        SqlCommand cmd;
        SqlDataReader dr;
        String dni;
        String sql = "Select DNI_C From Clientes Where NomUser='" + usuario + "'";
        if (cn != null)
        {
            cmd = new SqlCommand(sql, cn);
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dni=dr.ToString();
                    return dni;
                }else
                    return "";
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
            finally
            {
                cn.Close();
            }
        }
        else
            return "";
    }
}