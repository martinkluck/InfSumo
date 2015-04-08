using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Windows;

public partial class Registro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        GestionUsuarios gusuario = new GestionUsuarios();
        if (gusuario.EstaRegistrado(txtDNI.Text, txtClave.Text))
        {
            lblResultado.Text = "Ya existe un usuario registrado <br/>";
            lblResultado.Text += "con esa combinacion de usuario y clave";
        }
        else
        {
            Usuario NuevoUsuario =
            new Usuario(txtDNI.Text, txtNomUser.Text,txtClave.Text,txtNombre.Text,txtApellido.Text, txtEmail.Text, txtTelefono.Text,txtDir.Text, true);
            if (!gusuario.GrabarUsuario(NuevoUsuario))
                lblResultado.Text = "Error en el registro del usuario";
            else
                lblResultado.Text = "El usuario se ha grabado Ok";
                btnLogin.Visible = true;
        }
    }

    protected void btnLogin_Click1(object sender, EventArgs e)
    {
        this.Response.Redirect("Login.aspx");
    }
}