using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


/// <summary>
/// Clase Carrito de compras
/// </summary>
public class CarritoDeCompras
{

    public static int cont = 0;
	public CarritoDeCompras()
	{
		// TODO: Agregar aquí la lógica del constructor
	}

    public DataTable crearTablaEnCarrito()
    {
        //CREO UNA TABLA QUE VOY A ASOCIAR A UNA VARIABLE SESSION
        DataTable tabla = new DataTable();
        DataColumn columna = new DataColumn("Codigo", System.Type.GetType("System.String"));
        tabla.Columns.Add(columna);
        columna = new DataColumn("Descripcion", System.Type.GetType("System.String"));
        tabla.Columns.Add(columna);
        columna = new DataColumn("Precio", System.Type.GetType("System.String"));
        tabla.Columns.Add(columna);
        columna = new DataColumn("Cantidad", System.Type.GetType("System.String"));
        tabla.Columns.Add(columna);
        return tabla;
    }

    public void AgregarCarrito(DataTable Carrito, int cod, String desc, float precio, int cant)
    {
        //AGREGA FILA
        DataRow dr = Carrito.NewRow();
        dr["Codigo"] = cod;
        dr["Descripcion"] = desc;
        dr["Precio"] = precio;
        dr["Cantidad"] = cant;
        Carrito.Rows.Add(dr);
    }

    public void EliminaCarrito(DataTable Carrito, int pos)
    {
        Carrito.Rows.RemoveAt(pos);
        if (Carrito.Rows.Count == 0)
            Carrito = null;
    }

    public void VerificarExiste(DataTable Carrito, int cod)
    {
        
    }

}