using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Libro
/// </summary>
public class Producto
{
    private int i_Producto;
    private String s_Categoria;
    private String s_Descripcion;
    private decimal d_Precio;
    private int i_Cantidad;
	public Producto()
	{
    }
    public Producto (int i_Producto,String s_Categoria,String s_Descripcion, decimal d_Precio, int i_Cantidad)
    {
        this.i_Producto=i_Producto;
        this.s_Categoria=s_Categoria;
        this.s_Descripcion=s_Descripcion;
        this.d_Precio = d_Precio;
    }
    public int Produc
    { 
        get {return i_Producto;}
        set {i_Producto=value;}
    }
    public String Categoria
    {
        get { return s_Categoria; }
        set { s_Categoria = value; }
    }
    public String Descripcion
    {
        get { return s_Descripcion; }
        set { s_Descripcion = value; }
    }
    public decimal Precio
    {
        get { return d_Precio; }
        set { d_Precio = value; }
    }

    public int Cantidad
    {
        get { return i_Cantidad; }
        set { i_Cantidad = value; }
    }
}