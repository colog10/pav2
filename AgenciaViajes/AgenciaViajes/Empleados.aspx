<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="AgenciaViajes.Empleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="ConsultaSection" class="abm-section container" runat="server">
        <div class="row">
            <div class="col-md-12">
                <h2>Empleados</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass="btn btn-primary" /> <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                 <div class="form-group">
                      <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" placeholder="Buscar"></asp:TextBox>
                 </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="GridView1" runat="server" EmptyDataText="No hay datos para mostrar"></asp:GridView>
            </div>
        </div>
    </section>
</asp:Content>
