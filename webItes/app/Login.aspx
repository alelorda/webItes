<%@ Page Title="" Language="C#" MasterPageFile="~/app/master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="webItes.app.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div class="sarasa">
            
            
            <center>
                <h2><b>Iniciar sesión</b></h2>
                <div id="formLogin" runat="server">
                    <asp:TextBox ID="TextBoxUsuario" runat="server" placeholder="Usuario" Class="textBox" TextMode="Email"></asp:TextBox>
                    <asp:TextBox ID="TextBoxContrasenia" runat="server" placeholder="Contraseña" Class="textBox" TextMode="Password"></asp:TextBox>
                    <asp:Label ID="LabelIncorrecta" runat="server" Text="Usuario/Contraseña incorrecta" ForeColor="Red"></asp:Label><br />
                    <asp:Button ID="Button1" runat="server" Text="Acceder" CssClass="accederbtn" OnClick="ButtonAcceder" />
                    <asp:Button ID="Button2" runat="server" Text="Recuperar Contraseña" class="recuperarbtn"  /><br />
                 </div>
            </center>
        
        
        </div>
 
</asp:Content>

