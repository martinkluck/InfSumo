using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Usuario
/// </summary>
public class Usuario
{
    //esta clase encapsula los datos de un usuario
    private String s_DNI;
    private String s_NomUser;
    private String s_Clave;
    private String s_Nombre;
    private String s_Apellido;
    private String s_Email;
    private String s_Telefono;
    private String s_Direccion;
    private Boolean s_Estado;
	public Usuario()
	{
	}
    public Usuario(String s_DNI, String s_NomUser, String s_Clave, String s_Nombre, String s_Apellido, String s_Email, String s_Telefono, String s_Direccion, Boolean s_Estado)
    {
        this.s_DNI = s_DNI;
        this.s_NomUser = s_NomUser;
        this.s_Clave = s_Clave;
        this.s_Nombre = s_Nombre;
        this.s_Apellido = s_Apellido;
        this.s_Email = s_Email;
        this.s_Telefono = s_Telefono;
        this.s_Direccion = s_Direccion;
        this.s_Estado = s_Estado;
    }
    public String DNI
    {
        get 
            { return s_DNI; }
        set 
            { s_DNI = value; }
    }

    public String NomUser
    {
        get
        { return s_NomUser; }
        set
        { s_NomUser = value; }
    }
    public String Clave
    {
        get 
            { return s_Clave; }
        set 
            { s_Clave = value; }
    }

    public String Nombre
    {
        get
        { return s_Nombre; }
        set
        { s_Nombre = value; }
    }

    public String Apellido
    {
        get
        { return s_Apellido; }
        set
        { s_Apellido = value; }
    }
    public String Email
    {
        get
            { return s_Email; }
        set 
            { s_Email = value; }
    }
    public String Telefono
    {
        get 
            { return s_Telefono; }
        set 
            { s_Telefono = value; }
    }

    public String Direccion
    {
        get
        { return s_Direccion; }
        set
        { s_Direccion = value; }
    }

    public Boolean Estado
    {
        get
        { return s_Estado; }
        set
        { s_Estado = value; }
    }

}