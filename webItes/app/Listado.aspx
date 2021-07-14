<%@ Page Title="" Language="C#" MasterPageFile="~/app/master.Master" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="webItes.app.Listado1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script language="javascript" type="text/javascript">
        function ConfiirmarBoton(mensaje) {
            return confirm(mensaje); 
        }
</script>
<div class="sarasa"><br />
    <center>
        <div id="formLogin" runat="server">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_alumno" DataSourceID="ites" AllowPaging="True" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="467px">
                 <Columns>
                        
                     <asp:CommandField ShowSelectButton="True" />
                        
                    <asp:BoundField DataField="id_alumno" HeaderText="DNI" SortExpression="id_alumno" ReadOnly="True" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="apellido" HeaderText="Apellido" SortExpression="apellido" /> 
                    <asp:BoundField DataField="mail" HeaderText="Correo" SortExpression="mail" />
                    <asp:BoundField DataField="direccion" HeaderText="Direccion" SortExpression="direccion" />
                    <asp:BoundField DataField="telefono" HeaderText="Telefono" SortExpression="telefono" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="ites" runat="server" ConnectionString="<%$ ConnectionStrings:itesConnectionString %>" SelectCommand="SELECT [id_alumno], [apellido], [nombre], [mail], [direccion], [telefono] FROM [alumnos]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="itesDataBases" runat="server"></asp:SqlDataSource>
            <asp:Label ID="LabelConfirmacion" runat="server" Text="Realmente desea eliminarlo?"></asp:Label><br />
            <asp:Button ID="ButtonConfirm" runat="server" Text="SI" class="confirmbtn" OnClick="ButtonConfirm_Click" />
            <asp:Button ID="ButtonRechazar" runat="server" Text="NO" class="rechazarbtn" OnClic="ButtonRechazar_Click"/><br />
            <asp:Button ID="ButtonVer" runat="server" Text="Agregar" class="verbtn" OnClick="ButtonVer_Click"/>
            <asp:Button ID="ButtonModificar" runat="server" Text="Editar" class="editarbtn" OnClientClick=" return ConfiirmarBoton('Quieres eliminarlo?)" OnClick="ButtonModificar_Click"/>
            <asp:Button ID="ButtonEliminar" runat="server" Text="Eliminar" class="eliminarbtn" OnClick="ButtonEliminar_Click"/>
            <asp:Button ID="ButtonVolver" runat="server" Text="Volver"  class="cersesionbtn" OnClick="ButtonVolver_Click"/>
        </div>
    </center>
</div>
</asp:Content>
