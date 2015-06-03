<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Pasajeros.aspx.cs" Inherits="AgenciaViajes.Pasajero" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="Consulta" class="abm-section container-crud" runat="server">
        <div class="row">
            <div class="col-md-12">
                <h2>Pasajeros</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Button ID="btnNuevo" CausesValidation="false" runat="server" Text="Nuevo" CssClass="btn btn-primary" OnClick="btnNuevo_Click" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
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
                <asp:GridView ID="gvPasajero" runat="server" EmptyDataText="No hay datos para mostrar" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField HeaderText="Apellido" DataField="apellido" />
                        <asp:BoundField HeaderText="Nombre" DataField="nombre" />
                        <asp:BoundField HeaderText="Tipo Documento" DataField="idTipoDocumento" />
                        <asp:BoundField HeaderText="Numero Documento" DataField="numero documento" />
                        <asp:BoundField HeaderText="CUIL" DataField="cuilcuit1-cuilcuit2-cuilcuit3" />
                        <asp:BoundField HeaderText="Estado Civil" DataField="idEstadoCivil" />
                        <asp:BoundField HeaderText="Fecha Nacimiento" DataField="fechaNacimiento" />
                        <asp:BoundField HeaderText="Nacionalidad" DataField="idNacionalidad" />
                        <asp:BoundField HeaderText="Profesion" DataField="profesion" />
                        <asp:BoundField HeaderText="Domicilio" DataField="domicilio" />
                        <asp:BoundField HeaderText="Teléfono" DataField="telefono" />
                        <asp:BoundField HeaderText="Movil" DataField="movil" />
                        <asp:BoundField HeaderText="Email" DataField="email" />

                        <asp:CheckBoxField />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </section>
    <section id="alta" runat="server" class="container-crud">
        <div class="row">
            <div class="col-md-12">
                <h3>Datos de los Pasajeros</h3>
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
                    <label>CUIL/CUIT</label>
                    <asp:TextBox ID="txtCuil" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtLegajo"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label>Tipo Documento</label>
                    <asp:DropDownList runat="server" ID="ddlTipoDoc"></asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="ddlTipoDoc"></asp:RequiredFieldValidator>
                </div>
            </div>

        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <label>Numero Documento</label>
                    <asp:TextBox ID="txtNumeroDocumento" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtNumeroDocumento"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
         <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label>Estado Civil</label>
                    <asp:DropDownList runat="server" ID="ddlEstadoCivil"></asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="ddlEstadoCivil"></asp:RequiredFieldValidator>
                </div>
            </div>

        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label>Nacionalidad</label>
                    <asp:DropDownList runat="server" ID="ddlNacionalidad"></asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="ddlNacionalidad"></asp:RequiredFieldValidator>
                </div>
            </div>

        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <label>Profesion</label>
                    <asp:TextBox ID="txtProfesion" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtProfesion"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <label>Domicilio</label>
                    <asp:TextBox ID="txtDomicilio" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtDomicilio"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
         <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <label>Telefono</label>
                    <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtTelefono"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <label>Movil</label>
                    <asp:TextBox ID="txtMovil" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtMovil"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <label>Email</label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label>Fecha nacimiento</label>
                    <asp:Calendar runat="server" ID="cldFechaAlta"></asp:Calendar>

                </div>
            </div>           
        </div>

        <%--<div class="row">
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
        </div>--%>
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <asp:CheckBox ID="chkActivo" runat="server" Text=" Activo" Checked="true" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
                <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" OnClick="btnCancelar_Click" />
            </div>
        </div>
    </section>
</asp:Content>
