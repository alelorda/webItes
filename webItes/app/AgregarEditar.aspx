<%@ Page Title="" Language="C#" MasterPageFile="~/app/master.Master" AutoEventWireup="true" CodeBehind="AgregarEditar.aspx.cs" Inherits="webItes.app.AgregarEditar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="sarasa">
        <center>
            <h2><b>Agregar</b></h2>
            <div id="formLogin" runat="server">
                <asp:TextBox ID="TextBoxDNI" runat="server" placeholder="DNI" Class="textBox" ></asp:TextBox><br />
                <asp:TextBox ID="TextBoxNombre" runat="server" placeholder="Nombre" Class="textBox" ></asp:TextBox><br />
                <asp:TextBox ID="TextBoxApellido" runat="server" placeholder="Apellido" Class="textBox"></asp:TextBox><br />
                <asp:TextBox ID="TextBoxEmail" runat="server" placeholder="Correo Electrónico" Class="textBox" TextMode="Email"></asp:TextBox><br />              
                <asp:TextBox ID="TextBoxDireccion" runat="server" placeholder="Dirección" Class="textBox"></asp:TextBox><br />              
                <asp:TextBox ID="TextBoxTelefono" runat="server" placeholder="Telefono" Class="textBox" TextMode="Phone"></asp:TextBox><br />              
                <asp:Button ID="ButtonAgregar" runat="server" Text="Guardar" class="accederbtn" OnClick="ButtonAgregar_Click" />
                <asp:Button ID="ButtonVolver" runat="server" Text="Volver"  class="cersesionbtn" OnClick="ButtonVolver_Click" />
            </div>
        </center>
    </div>
</asp:Content>
