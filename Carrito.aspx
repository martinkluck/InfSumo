<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Carrito.aspx.cs" Inherits="Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenerdorVerde" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="" Font-Size="36px" ForeColor="Red"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenedorRojo" Runat="Server">
            <asp:GridView CssClass="Tablas" ID="grdCarrito" runat="server" OnSelectedIndexChanged="grdCarrito_SelectedIndexChanged" Width="90%" CellPadding="4" GridLines="Horizontal" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" SelectText="Eliminar" >
                    <ControlStyle CssClass="BotonesTablas" />
                    <ItemStyle CssClass="Indice" />
                    </asp:CommandField>
                </Columns>
                <EditRowStyle CssClass="Tablas" />
                <FooterStyle CssClass="Tablas" BackColor="White" ForeColor="#333333" />
                <HeaderStyle CssClass="Tablas"   Font-Size="36px" ForeColor="White" Font-Bold="True"/>
                <PagerStyle CssClass="Tablas" BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle CssClass="Tablas" BackColor="White" ForeColor="#333333"/>
                <%--<SelectedRowStyle CssClass="Tablas" BackColor="#339966" Font-Bold="True" ForeColor="White" />--%>
                <SortedAscendingCellStyle CssClass="Tablas" BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle CssClass="Tablas" BackColor="#487575" />
                <SortedDescendingCellStyle CssClass="Tablas" BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle CssClass="Tablas" BackColor="#275353" />
            </asp:GridView>
            <br />
            <asp:LinkButton ID="lnkEjecutarCompra" runat="server" Visible="False" OnClick="lnkEjecutarCompra_Click">Ejecutar compra</asp:LinkButton>
</asp:Content>

