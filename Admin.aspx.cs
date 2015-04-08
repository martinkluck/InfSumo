using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Admin : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void GridView1_PreRender(object sender, EventArgs e)
    {
        switch (Convert.ToInt32(DropDownList1.SelectedValue))
        {
            case 2:
                SqlDataSource1.SelectCommand = "SELECT [DNI_C] as Documento, [NomUser] as Usuario, [Nombre], [Apellido], [Mail], [Tel] as Telefono, [Direccion] FROM [Clientes]";
                break;
            case 1:
                SqlDataSource1.SelectCommand = "SELECT [CodArt_A] as Codigo, [Descripcion], [PrecioUnitario], [Stock], [Categoria] FROM [Articulos]";
                break;
            case 3:
                SqlDataSource1.SelectCommand = "select [NumVenta] as Venta, [NomUser] as Usuario, [Total], [Fecha],[Importe]  from [Ventas] inner join [Clientes] on DNI_V=DNI_C";
                break;
        }
    }
}