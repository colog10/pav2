<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Personal.aspx.cs" Inherits="AgenciaViajes.Personal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        
        $(document).ready(function () {
        
            $("[id$=txtFechaAlta]").datepicker();
            $("[id$=txtFechaBaja]").datepicker();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section id="ConsultaSection" class="abm-section container-crud" runat="server">
        <div class="row">
            <div class="col-md-12">
                <h2>Empleados</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Button ID="btnNuevo" CausesValidation="false" runat="server" Text="Nuevo" CssClass="btn btn-primary" OnClick="btnNuevo_Click" /> <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                 <div class="form-group">
                      <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" AutoPostBack="True"></asp:TextBox>
                 </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="gvEmpleados" runat="server" EmptyDataText="No hay datos para mostrar" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" >
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField HeaderText="Apellido" DataField="apellido" />
                        <asp:BoundField HeaderText="Nombre" DataField="nombre" />
                        <asp:BoundField HeaderText="Legajo" DataField="legajo" />
                        <asp:BoundField HeaderText="FechaAlta" DataField="fechaAlta" />
                        <asp:BoundField HeaderText="FechaBaja" DataField="fechaBaja" />
                        <asp:CheckBoxField />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </section>
    <section id="altaModificacionSection" runat="server" class="container-crud">
        <div class="row">
            <div class="col-md-12">
                <h3>Datos del Empleado</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                             
                <div class="form-group">
                     <label>Apellido</label>
                     <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                     <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtApellido"  Text="Requerido" CssClass="danger"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                     <label>Nombre</label>
                      <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                      <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtNombre"  Text="Requerido" CssClass="danger"></asp:RequiredFieldValidator>
                </div>
             </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                     <label>Legajo</label>
                      <asp:TextBox ID="txtLegajo" runat="server" CssClass="form-control"></asp:TextBox>
                      <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtLegajo"  Text="Requerido" CssClass="danger"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                     <label>Usuario</label><br />
                      <asp:DropDownList runat="server" ID="ddlUsuario" DataTextField="nombre" DataValueField="idUsuario">
                          <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
                      </asp:DropDownList>
                      <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="ddlUsuario"  Text="Requerido" CssClass="danger"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label>Fecha Alta</label>
                    <asp:TextBox id="txtFechaAlta" runat="server" />
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtFechaAlta" Text="Requerido" CssClass="danger"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>Fecha Baja</label>
                    <asp:TextBox id="txtFechaBaja" runat="server" />
                </div>
            </div>
        </div>
        
        
        <div class="row">
            <div class="col-md-12">
                <h3>Opciones</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                     <asp:CheckBox ID="chkSupervisor" runat="server" Text=" Supervisor" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                     <asp:CheckBox ID="chkActivo" runat="server" Text=" Activo" Checked="true"/>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
                <asp:Button runat="server" ID="btnModificar" Text="Guardar" CssClass="btn btn-primary" OnClick="btnModificar_Click"/>
                <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" OnClick="btnCancelar_Click"/>
            </div>
        </div>
    </section>
</asp:Content>
