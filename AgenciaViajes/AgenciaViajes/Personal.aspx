<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Personal.aspx.cs" Inherits="AgenciaViajes.Personal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                     <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtApellido"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                     <label>Nombre</label>
                      <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                      <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
                </div>
             </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                     <label>Legajo</label>
                      <asp:TextBox ID="txtLegajo" runat="server" CssClass="form-control"></asp:TextBox>
                      <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtLegajo"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label>Fecha Alta</label>
                    <asp:Calendar runat="server" ID="cldFechaAlta"></asp:Calendar>
                    
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>Fecha Baja</label>
                    <asp:Calendar  runat="server" ID="cldFechaBaja"></asp:Calendar>
                </div>
            </div>
        </div>
        
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                     <label>Usuario</label>
                      <asp:DropDownList runat="server" ID="ddlUsuario"></asp:DropDownList>
                      <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="ddlUsuario"></asp:RequiredFieldValidator>
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
                <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" OnClick="btnCancelar_Click"/>
            </div>
        </div>
    </section>
</asp:Content>
