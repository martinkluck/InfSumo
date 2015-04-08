<%@ Page Title="Registro" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registro.aspx.cs" Inherits="Registro"  EnableEventValidation="true"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenerdorVerde" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenedorRojo" Runat="Server">
    <div>
        <table align="center" style="width: 76%">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="D.N.I.:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtDNI" ErrorMessage="Solo se pueden introducir números." Font-Size="24px" ForeColor="Red" SetFocusOnError="True" ValidationExpression="([0-9]|-)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Nombre de usuario:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNomUser" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
                    
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Vuelva a escribir la clave:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtClave2" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtClave" ControlToValidate="txtClave2" ErrorMessage="Las contraseñas no coinciden." Font-Size="24px" ForeColor="Red" SetFocusOnError="True"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Nombre:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtNombre" ErrorMessage="No se pueden ingresar números." Font-Size="24px" ForeColor="Red" ValidationExpression="[a-zA-ZñÑ\s]"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label4" runat="server" Text="Apellido:"></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtApellido" ErrorMessage="No se pueden ingresar números." Font-Size="24px" ForeColor="Red" ValidationExpression="[a-zA-ZñÑ\s]"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label5" runat="server" Text="Correo Electrónico:"></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEmail" ErrorMessage="Ingrese un correo electronico valido." Font-Size="24px" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" SetFocusOnError="True"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label6" runat="server" Text="Teléfono:"></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Solo se pueden introducir números." Font-Size="24px" ForeColor="Red" SetFocusOnError="True" ValidationExpression="([0-9]|-)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label7" runat="server" Text="Dirección:"></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtDir" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="btnRegistrar" runat="server" onclick="btnRegistrar_Click" 
                        Text="Registrar" />
                </td>
            </tr>
        </table>
    </div>
    <br />
    <asp:Label ID="lblResultado" runat="server"></asp:Label>
    &nbsp; &nbsp;<br />
    <br />
    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click1" Text="Volver a Login" Visible="False" />
    <br />
    <%--<asp:HyperLink ID="lnkLogin" runat="server" NavigateUrl="~/Login.aspx">Login</asp:HyperLink>--%>
</asp:Content>

