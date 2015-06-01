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
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass="btn btn-primary" OnClick="btnNuevo_Click" /> <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                 <div class="form-group">
                      <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" placeholder="Buscar" AutoPostBack="True"></asp:TextBox>
                 </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="gvEmpleados" runat="server" EmptyDataText="No hay datos para mostrar" >
                    <Columns>
                    
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField HeaderText="Apellido" DataField="apellido" />
                        <asp:BoundField HeaderText="Nombre" DataField="nombre" />
                        <asp:BoundField HeaderText="Legajo" DataField="legajo" />
                        <asp:BoundField HeaderText="FechaAlta" DataField="fechaAlta" />
                        <asp:BoundField HeaderText="FechaBaja" DataField="fechaBaja" />
                    </Columns>
                    
                </asp:GridView>
            </div>
        </div>
    </section>
    <section id="altaModificacionSection" runat="server" class="container">
        <div class="row">
            <div class="col-md-12">
                 <div class="form-group">
                     <label>Apellido</label>
                      <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                     <label>Nombre</label>
                      <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                     <label>Legajo</label>
                      <asp:TextBox ID="txtLegajo" runat="server" CssClass="form-control"></asp:TextBox>

                 </div>
            </div>
        </div>
    </section>
 

</asp:Content>
