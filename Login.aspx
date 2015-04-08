<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenerdorVerde" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenedorRojo" Runat="Server">
    <table class="Login" align="center">
            <tr>
                <td colspan="2" align="center"></td>
            </tr>
            <tr>
                <td style="text-align:right">Usuario: </td>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="Login"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">Contraseña:</td>
                <td>
                    <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" CssClass="Login"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnLoguearse" runat="server" Text="Entrar" OnClick="btnLoguearse_Click" CssClass="BotonesLogin" Font-Size="36px"/>
                &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Usuario o Contraseña incorrectos. Vuelva a intentar." Visible="False"></asp:Label>
                &nbsp;<asp:Button ID="btnRegistrarse" runat="server" Text="Registrarse" OnClick="btnRegistrarse_Click" CssClass="BotonesLogin" Font-Size="36px"/>
                </td>
            </tr>
        </table>
</asp:Content>

