<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenerdorVerde" Runat="Server">
    <asp:DropDownList ID="DropDownList1" runat="server" Font-Size="36px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
        <asp:ListItem Value="1">Productos</asp:ListItem>
        <asp:ListItem Value="2">Clientes</asp:ListItem>
        <asp:ListItem Value="3">Compras</asp:ListItem>
    </asp:DropDownList>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenedorRojo" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" DataSourceID="SqlDataSource1" CssClass="Tablas" OnPreRender="GridView1_PreRender">
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:InfSumoConnectionString %>" SelectCommand=""></asp:SqlDataSource>
</asp:Content>

