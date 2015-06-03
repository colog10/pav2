<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OperadoresTuristicos.aspx.cs" Inherits="AgenciaViajes.OperadoresTuristicos" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="ConsultaSection" class="abm-section container" runat="server">
        <div class="row">
            <div class="col-md-12">
                <h2>Operadores Turísticos</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass="btn btn-primary" OnClick="btnNuevo_Click"/> 
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"/>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                 <div class="form-group">
                      <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" placeholder="Buscar" AutoPostBack="True">

                      </asp:TextBox>
                 </div>
            </div>
        </div>
        <div class="row" >
            <div class="col-md-12">
                <asp:GridView ID="gvOperadoresTuristicos" runat="server" EmptyDataText="No hay datos para mostrar">
                    <Columns>
                        <asp:CommandField ShowSelectButton="true" />
                        <asp:BoundField HeaderText="Nombre" DataField="Descripcion" />
                        <asp:BoundField HeaderText="Domicilio" DataField="Direccion" />
                        <asp:BoundField HeaderText="eMail de Contacto" DataField="Email" />
                        <asp:BoundField HeaderText="Nombre de Contacto" DataField="Nombre" />
                        <asp:BoundField HeaderText="Página web" DataField="PaginaWEB" />
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













