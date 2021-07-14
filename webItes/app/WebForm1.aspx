<%@ Page Title="" Language="C#" MasterPageFile="~/app/master.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webItes.app.WebForm1" %>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="sarasa">
        <center>
            <h2><b>EDITAR</b></h2>
            <div id="formLogin" runat="server">
                <asp:TextBox ID="TextBoxDNI" runat="server" placeholder="DNI" Class="textBox" Enabled="False" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:itesConnectionString %>" SelectCommand="SELECT * FROM [alumnos]"></asp:SqlDataSource>
                <br />
                <asp:TextBox ID="TextBoxNombre" runat="server" placeholder="Nombre" Class="textBox" OnTextChanged="TextBox1_TextChanged"></asp:TextBox><br />
                <asp:TextBox ID="TextBoxApellido" runat="server" placeholder="Apellido" Class="textBox" OnTextChanged="TextBox1_TextChanged"></asp:TextBox><br />
                <asp:TextBox ID="TextBoxEmail" runat="server" placeholder="Correo Electrónico" Class="textBox" TextMode="Email" OnTextChanged="TextBox1_TextChanged"></asp:TextBox><br />              
                <asp:TextBox ID="TextBoxDireccion" runat="server" placeholder="Dirección" Class="textBox" OnTextChanged="TextBox1_TextChanged"></asp:TextBox><br />              
                <asp:TextBox ID="TextBoxTelefono" runat="server" placeholder="Telefono" Class="textBox" TextMode="Phone" OnTextChanged="TextBox1_TextChanged"></asp:TextBox><br />              
                <asp:Button ID="ButtonGuardar" runat="server" Text="Guardar" class="accederbtn" OnClick="ButtonGuardar_Click" />
                <asp:Button ID="ButtonVolver" runat="server" Text="Volver"  class="cersesionbtn" OnClick="ButtonVolver_Click" />
            </div>
        </center>
    </div>
</asp:Content>
