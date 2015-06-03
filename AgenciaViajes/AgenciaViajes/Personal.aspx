<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Personal.aspx.cs" Inherits="AgenciaViajes.Personal" UICulture="es" Culture="es-AR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $("[id$=txtFechaAlta]").datepicker();
            $("[id$=txtFechaBaja]").datepicker();
        });

        function CheckAllElementos(Checkbox) {
            var GridVwHeaderChckbox = document.getElementById("<%=gvEmpleados.ClientID %>");
            for (i = 1; i < GridVwHeaderChckbox.rows.length; i++) {
                GridVwHeaderChckbox.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = Checkbox.checked;
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="abm-section container-crud header-section">
         <div class="row">
            <div class="col-md-12">
                <h2>Empleados</h2>
            </div>
        </div>
         <div class="row">
             <div class="col-md-12">
                 <div id="SuccessMessage" runat="server"  class="alert alert-success" role="alert" visible="false"><asp:Label ID="LblSuccess" runat="server"></asp:Label></div>
                 <div id="InfoMessage" runat="server"  class="alert alert-info" role="alert" visible="false"><asp:Label ID="LblInfo" runat="server"></asp:Label></div>
                 <div id="WarningMessage" runat="server"  class="alert alert-warning" role="alert" visible="false"><asp:Label ID="LblWarning" runat="server"></asp:Label></div>
                 <div id="DangerMessage" runat="server" class="alert alert-danger" role="alert" visible="false"><asp:Label ID="LblDanger" runat="server"></asp:Label></div>
             </div>
         </div>
     </div>
     <section id="ConsultaSection" class="abm-section container-crud" runat="server">
       
        <div class="row">
            <div class="col-md-12">
                <asp:Button ID="btnNuevo" CausesValidation="false" runat="server" Text="Nuevo" CssClass="btn btn-primary" OnClick="btnNuevo_Click" /> <asp:Button ID="btnModificarSeleccionado" runat="server" Text="Modificar" OnClick="btnModificarSeleccionado_Click" /> <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />  
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                 <div class="form-group">
                      <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" AutoPostBack="True" MaxLength="60"></asp:TextBox>
                 </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="gvEmpleados" runat="server" EmptyDataText="No hay datos para mostrar" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" >
                    <Columns>
                        
                        <asp:TemplateField ItemStyle-Width="40px">
                            <HeaderTemplate>
                                <asp:CheckBox ID="chkSelectAll" runat="server" onclick="CheckAllElementos(this);" />
                            </HeaderTemplate>
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemTemplate>
                                <asp:CheckBox ID="chkElemento" runat="server"></asp:CheckBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="IdEmpleado" HeaderText="IdEmpleado" />
                        <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                        <asp:BoundField HeaderText="Legajo" DataField="Legajo" />
                        
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
                     <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" MaxLength="30"></asp:TextBox>
                     <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtApellido"  Text="Requerido"  CssClass="label label-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                     <label>Nombre</label>
                      <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" MaxLength="30"></asp:TextBox>
                      <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtNombre" Text="Requerido"  CssClass="label label-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
             </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                      <label>Legajo</label>
                      <asp:TextBox ID="txtLegajo" runat="server" CssClass="form-control" ></asp:TextBox>
                      <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtLegajo"  Text="Requerido"  CssClass="label label-danger"  Display="Dynamic"></asp:RequiredFieldValidator>
                      <asp:RangeValidator runat="server" ValidationGroup="GuardarGroup" Type="Integer" ControlToValidate="txtLegajo" MinimumValue="1" Text="Valor numérico entre 1 y 100000" MaximumValue="100000" CssClass="label label-danger" Display="Dynamic"></asp:RangeValidator>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                     <label>Usuario</label><br />
                      <asp:DropDownList runat="server" ID="ddlUsuario" DataTextField="nombre" DataValueField="idUsuario">
                          <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
                      </asp:DropDownList>
                    <br />
                      <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="ddlUsuario"  Text="Requerido"  CssClass="label label-danger"  Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label>Fecha Alta</label>
                    <asp:TextBox id="txtFechaAlta" runat="server" />
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtFechaAlta" Text="Requerido"  CssClass="label label-danger"  Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>Fecha Baja</label>
                    <asp:TextBox id="txtFechaBaja" runat="server" />
                    <asp:CompareValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtFechaBaja" ControlToCompare="txtFechaAlta" Operator="GreaterThan" CssClass="label label-danger" Text="La fecha de baja debe ser mayor a la de alta"  Display="Dynamic"></asp:CompareValidator>
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
        <input type="hidden" runat="server" id="hdIdEmpleado"  />
        <div class="row">
            <div class="col-md-12">
                <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-primary" ValidationGroup="GuardarGroup" OnClick="btnGuardar_Click" />
                <asp:Button runat="server" ID="btnModificar" Text="Modificar" CssClass="btn btn-primary" OnClick="btnModificar_Click"  ValidationGroup="GuardarGroup"/>
                <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" OnClick="btnCancelar_Click"/>
            </div>
        </div>
    </section>
</asp:Content>
