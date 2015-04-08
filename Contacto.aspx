<%@ Page Title="Contacto" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contacto.aspx.cs" Inherits="Contacto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenerdorVerde" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenedorRojo" Runat="Server">
    <div class="col c240 info_cont">
      	<h5>Información de contacto</h5>
            <div class="telefono">
                <p><strong>Telefono / Fax</strong></p>
                <p>(+5411) 5237-2237 </p>
            </div>
            <div class="email_web">
                <p><strong>Email / Web </strong></p>
                <p>info@infsumo.com.ar<br/>www.infsumo.com.ar</p>
            </div>
      </div>
    <div id="Contacto">
        <%--<script type="text/javascript" src="http://form.jotformz.com/jsform/50526737080656"></script>--%>
        <form action="contacto.php" method="post" class="form">
            <label for="nombre" class="lable">Nombre:</label>
            <input id="nombre" type="text" name="nombre" placeholder="Nombre y Apellido" required="" class="input"/>
            <label for="email" class="lable">Email:</label>
            <input id="email" type="email" name="email" placeholder="ejemplo@correo.com" required="" class="input"/>
            <label for="mensaje" class="lable">Mensaje:</label>
            <textarea id="mensaje" name="mensaje" placeholder="Mensaje" required="" class="textarea"></textarea>
            <input id="submit" type="submit" name="submit" value="Enviar" class="input" style="margin: 0 0 0 1px"/>
        </form>
        <?php
            $nombre = $_POST['nombre'];
            $email = $_POST['email'];
            $mensaje = $_POST['mensaje'];
            $para = 'martinkluck@outlook.com';
            $titulo = 'Mensajes de InfSumo';
            $header = 'From: ' . $email;
            $msjCorreo = "Nombre: $nombre\n E-Mail: $email\n Mensaje:\n $mensaje";
            if ($_POST['submit']) {
                if (mail($para, $titulo, $msjCorreo, $header)) {
                    //echo "<script language=javascript> alert('Mensaje enviado, muchas gracias.');window.location.href = 'http://www.infsumo.com';</script>";
                } else {
                    echo 'Falló el envio';
                }
            }
        ?>
    </div>
</asp:Content>

