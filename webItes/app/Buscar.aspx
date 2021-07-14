<%@ Page Title="" Language="C#" MasterPageFile="~/app/master.Master" AutoEventWireup="true" CodeBehind="Buscar.aspx.cs" Inherits="webItes.app.Buscar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="sarasa">
        <center>
            <h2><b>Buscar</b></h2>
            <div id="formLogin" runat="server">
                <asp:TextBox ID="TextBoxBuscar" runat="server" placeholder="Buscar..." Class="textBox"></asp:TextBox>


                <asp:RadioButton ID="RadioNombre" runat="server" GroupName="busqueda" Text="Nombre" /><br />
                <asp:RadioButton ID="RadioApellido" runat="server" GroupName="busqueda" Text="Apellido" /><br />
                <asp:RadioButton ID="RadioDNI" runat="server" GroupName="busqueda" Text="DNI" /><br />
           
                <asp:Button ID="Button1" runat="server" Text="Buscar"  class="buscarbtn"  OnClick="ButtonBuscar_Click"/>
                
                
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_alumno" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="id_alumno" HeaderText="ID Alumno" ReadOnly="True" SortExpression="id_alumno" />
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
                        <asp:BoundField DataField="apellido" HeaderText="Apellido" SortExpression="apellido" />
                        <asp:BoundField DataField="mail" HeaderText="Mail" SortExpression="mail" />
                        <asp:BoundField DataField="direccion" HeaderText="Direccion" SortExpression="direccion" />
                        <asp:BoundField DataField="telefono" HeaderText="Telefono" SortExpression="telefono" />
                        <asp:BoundField DataField="id_ciudad" HeaderText="ID Ciudad" SortExpression="id_ciudad" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:itesConnectionString %>" SelectCommand="SELECT * FROM [alumnos]"></asp:SqlDataSource>
                
            <asp:Button ID="Button2" runat="server" Text="Volver"  class="cersesionbtn"  OnClick="Atras"/>
        </center>
    </div>
</asp:Content>
