<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Pasajeros.aspx.cs" Inherits="AgenciaViajes.Pasajero" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $("[id$=txtNacimiento]").datepicker();

        });

        function CheckAllElementos(Checkbox) {
            var GridVwHeaderChckbox = document.getElementById("<%=gvPasajero.ClientID %>");
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
                <h2>Pasajeros</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div id="SuccessMessage" runat="server" class="alert alert-success" role="alert" visible="false">
                    <asp:Label ID="LblSuccess" runat="server"></asp:Label></div>
                <div id="InfoMessage" runat="server" class="alert alert-info" role="alert" visible="false">
                    <asp:Label ID="LblInfo" runat="server"></asp:Label></div>
                <div id="WarningMessage" runat="server" class="alert alert-warning" role="alert" visible="false">
                    <asp:Label ID="LblWarning" runat="server"></asp:Label></div>
                <div id="DangerMessage" runat="server" class="alert alert-danger" role="alert" visible="false">
                    <asp:Label ID="LblDanger" runat="server"></asp:Label></div>
            </div>
        </div>
    </div>
    <section id="Consulta" class="abm-section container-crud" runat="server">

        <div class="row">
            <div class="col-md-12">
                <asp:Button ID="btnNuevo" CausesValidation="false" runat="server" Text="Nuevo" CssClass="btn btn-primary" OnClick="btnNuevo_Click" />
             <%--   <asp:Button ID="btnModificarSeleccionado"
                    runat="server" Text="Modificar" OnClick="btnModificarSeleccionado_Click" />--%>
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
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
                <asp:GridView ID="gvPasajero" runat="server" EmptyDataText="No hay datos para mostrar" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False">
                    <Columns>

                        <asp:TemplateField ItemStyle-Width="40px">
                            <HeaderTemplate>
                                <asp:CheckBox ID="chkSelectAll" runat="server" onclick="CheckAllElementos(this);" />
                            </HeaderTemplate>
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemTemplate>
                                <asp:CheckBox ID="chkPasajero" runat="server"></asp:CheckBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="Apellido" DataField="apellido" />
                        <asp:BoundField HeaderText="Nombre" DataField="nombre" />
                        <asp:BoundField HeaderText="Tipo Documento" DataField="idTipoDocumento" />
                        <asp:BoundField HeaderText="Numero Documento" DataField="numeroDocumento" />
                        <asp:BoundField HeaderText="CUIL" DataField="cuilcuit1" />
                        <asp:BoundField HeaderText="Estado Civil" DataField="idEstadoCivil" />
                        <asp:BoundField HeaderText="Fecha Nacimiento" DataField="fechaNacimiento" />
                        <asp:BoundField HeaderText="Nacionalidad" DataField="idNacionalidad" />
                        <asp:BoundField HeaderText="Profesion" DataField="profesion" />
                        <asp:BoundField HeaderText="Domicilio" DataField="domicilio" />
                        <asp:BoundField HeaderText="Teléfono" DataField="telefono" />
                        <asp:BoundField HeaderText="Movil" DataField="movil" />
                        <asp:BoundField HeaderText="Email" DataField="email" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </section>
    <section id="alta" runat="server" class="container-crud">
        <div class="row">
            <div class="col-md-12">
                <h3>Datos del Pasajero</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">

                <div class="form-group">
                    <label>Apellido</label>
                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" MaxLength="30"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtApellido" Text="Requerido" CssClass="label label-danger"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>Nombre</label>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" MaxLength="30"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtNombre" Text="Requerido" CssClass="label label-danger"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label>Fecha Nacimiento</label>
                    <asp:TextBox ID="txtNacimiento" runat="server" />
                    <asp:CompareValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtNacimiento" Operator="GreaterThan" CssClass="label label-danger"
                        Text="La fecha de baja debe ser mayor a la de alta" Display="Dynamic"></asp:CompareValidator>
                </div>
            </div>  

        <div class="col-md-6">
            <div class="form-group">
                <label>CUIL/CUIT</label>
                <asp:TextBox ID="txtCuil" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtCuil" Text="Requerido" CssClass="label label-danger"
                    Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RangeValidator runat="server" ValidationGroup="GuardarGroup" Type="Integer" ControlToValidate="txtCuil" MinimumValue="1" Text="Valor numérico entre 1 y 100000"
                    MaximumValue="100000" CssClass="label label-danger" Display="Dynamic"></asp:RangeValidator>
            </div>
        </div>

        </div>
            <div class="row">
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Tipo Documento</label><br />
                        <asp:DropDownList runat="server" ID="ddlTipoDoc" DataTextField="descripcionDTO" DataValueField="idTipoDocumentoDTO">
                            <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="ddlTipoDoc" Text="Requerido" CssClass="label label-danger"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Numero documento</label>
                        <asp:TextBox ID="txtNumero" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtNumero" Text="Requerido" CssClass="label label-danger"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator runat="server" ValidationGroup="GuardarGroup" Type="Integer" ControlToValidate="txtNumero" MinimumValue="1" Text="Valor numérico entre 1 y 100000"
                            MaximumValue="100000" CssClass="label label-danger" Display="Dynamic"></asp:RangeValidator>
                    </div>
                </div>
            </div>

               <div class="row">
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Nacionalidad</label><br />
                        <asp:DropDownList runat="server" ID="ddlNacionalidad" DataTextField="PaisNombre" DataValueField="PaisCodigo">
                            <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="ddlNacionalidad" Text="Requerido" CssClass="label label-danger"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Domicilio</label>
                        <asp:TextBox ID="txtDomicilio" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtDomicilio" Text="Requerido" CssClass="label label-danger"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                       
                    </div>
                </div>
            </div>

        <div class="row">
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Estado Civil</label><br />
                        <asp:DropDownList runat="server" ID="ddlEstadoCivil" DataTextField="Descripcion" DataValueField="IdEstadoCivil">
                            <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="ddlEstadoCivil" Text="Requerido" CssClass="label label-danger"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Profesion</label>
                        <asp:TextBox ID="txtProfesion" runat="server" CssClass="form-control"></asp:TextBox>
                        
                      
                    </div>
                </div>
            </div>

        <div class="row">
            <div class="col-md-6">

                <div class="form-group">
                    <label>Telefono</label>
                    <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" MaxLength="30"></asp:TextBox>
                    
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>Movil</label>
                    <asp:TextBox ID="txtMovil" runat="server" CssClass="form-control" MaxLength="30"></asp:TextBox>
                    
                </div>
            </div>
        </div>

            
            <div class="row">
                
                <div class="form-group">
                    <label>Email</label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" MaxLength="30"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtEmail" Text="Requerido" CssClass="label label-danger"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
               
                <div class="col-md-12">
                    <div class="form-group">
                        <asp:CheckBox ID="chkActivo" runat="server" Text=" Activo" Checked="true" />
                    </div>
                </div>
            
                </div>
                <div class="row">
                <div class="col-md-12">
                    <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-primary" ValidationGroup="GuardarGroup" OnClick="btnGuardar_Click" />
                    <asp:Button runat="server" ID="btnModificar" Text="Modificar" CssClass="btn btn-primary" OnClick="btnModificar_Click" ValidationGroup="GuardarGroup" />
                    <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" OnClick="btnCancelar_Click" />
                </div>
            </div>
    </section>
</asp:Content>