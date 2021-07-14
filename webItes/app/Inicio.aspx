<%@ Page Title="" Language="C#" MasterPageFile="~/app/master.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="webItes.app.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="sarasa">
        <center>
            <h2><b>Bienvenido Administrador</b></h2>
            <asp:Image ID="ImageLogo" runat="server" ImageUrl="img/logo_ites.png" AlternateText="kyocode" />
            <div id="formLogin" runat="server">            
                <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar"  class="buscarbtn"  OnClick="ButtonBuscar_Click"/>
                <asp:Button ID="ButtonAgregar" runat="server" Text="Listado"  class="accederbtn" OnClick="ButtonListado_Click"/>
                <asp:Button ID="ButtonCerrarSesion" runat="server" Text="Cerrar sesión" class="cersesionbtn" OnClick="ButtonCerrarSesion_Click"/>
            </div>
        </center>
    </div>
</asp:Content>
