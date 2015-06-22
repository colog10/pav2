<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OperadoresTuristicos.aspx.cs" Inherits="AgenciaViajes.OperadoresTuristicos" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $("[id$=txtFechaAlta]").datepicker();
        });

        function CheckAllElementos(Checkbox) {
            var GridVwHeaderChckbox = document.getElementById("<%=gvOperadoresTuristicos.ClientID %>");
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
                <div id="SuccessMessage" runat="server" class="alert alert-success" role="alert" visible="false">
                    <asp:Label ID="LblSuccess" runat="server"></asp:Label>
                </div>
                <div id="InfoMessage" runat="server" class="alert alert-info" role="alert" visible="false">
                    <asp:Label ID="LblInfo" runat="server"></asp:Label>
                </div>
                <div id="WarningMessage" runat="server" class="alert alert-warning" role="alert" visible="false">
                    <asp:Label ID="LblWarning" runat="server"></asp:Label>
                </div>
                <div id="DangerMessage" runat="server" class="alert alert-danger" role="alert" visible="false">
                    <asp:Label ID="LblDanger" runat="server"></asp:Label>
                </div>
            </div>
        </div>
    </div>
    <section id="SectionConsulta" class="abm-section container-crud" runat="server">
        <div class="row">
            <div class="col-md-12">
                <h2>Operadores Turísticos</h2>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <asp:Button ID="btnNuevo" CausesValidation="false" runat="server" Text="Nuevo" CssClass="btn btn-primary" OnClick="btnNuevo_Click" />
                <asp:Button ID="btnModificarSeleccionado" runat="server" Text="Modificar" OnClick="btnModificarSeleccionado_Click" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />

            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" AutoPostBack="True">
                    </asp:TextBox>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="gvOperadoresTuristicos" DataKeyNames="IdOperadorTuristico" runat="server" ShowHeaderWhenEmpty="true" EmptyDataText="No hay datos para mostrar" AutoGenerateColumns="false" AllowPaging="true" OnPageIndexChanging="gvOperadoresTuristicos_PageIndexChanging" PageSize="5">
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
                        <asp:BoundField HeaderText="Nombre" DataField="Descripcion" />
                        <asp:BoundField HeaderText="Domicilio" DataField="Direccion" />
                        <asp:BoundField HeaderText="Nombre de Contacto" DataField="Nombre" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>

    </section>

    <section id="SectionAltaModificacion" runat="server" class="abm-section container-crud">
        <div class="row">
            <div class="col-md-12">
                <div>
                    <h3>Datos del Operador Turístico</h3>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label>Nombre del Operador Turístico</label>
                    <asp:TextBox ID="txtNombreOperadorTuristico" runat="server" CssClass="form-control"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtNombreOperadorTuristico" Text="Requerido" CssClass="label label-danger" Display="Dynamic"></asp:RequiredFieldValidator>

                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>Domicilio del Operador Turístico</label>
                    <asp:TextBox ID="txtDomicilioOperador" runat="server" CssClass="form-control"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtDomicilioOperador" Text="Requerido" CssClass="label label-danger" Display="Dynamic"></asp:RequiredFieldValidator>


                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label>Calificacion</label>
                    <asp:TextBox ID="txtCalificacion" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="txtCalificacion" Text="Requerido" CssClass="label label-danger" Display="Dynamic"></asp:RequiredFieldValidator>

                </div>

            </div>
        </div>

        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label>Tipo de Destino</label><br />
                    <asp:DropDownList ID="ddlTipoDestino" runat="server" DataValueField="idTipoDestinoDTO" DataTextField="descripcionDTO">
                        <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:RequiredFieldValidator runat="server" ValidationGroup="GuardarGroup" ControlToValidate="ddlTipoDestino" Text="Requerido" CssClass="label label-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <%--<div class="col-md-6">
                <div class="form-group">
                    <label>Calificacion</label><br />
                    <asp:DropDownList ID="ddlCalificacion" runat="server">
                        <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>--%>
        </div>

        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label>Página Web</label>
                    <asp:TextBox ID="eMail" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>Teléfono</label>
                    <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <asp:CheckBox ID="chkActivo" runat="server" Text=" Activo" />

                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>Fecha de Alta</label>
                    <asp:TextBox ID="txtFechaAlta" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

        </div>

        <div class="row">
            <div class="col-md-12">
                <h3>Datos de Contacto</h3>
            </div>
        </div>

        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label>Nombre del Contacto</label>
                    <asp:TextBox ID="txtNombreContacto" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>eMail de Contacto</label>
                    <asp:TextBox ID="TextMailContacto" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <input type="hidden" runat="server" id="hdId" />
        </div>



        <div class="row">
            <div class="col-md-12">
                <asp:Button runat="server" ID="btnGuardar" Text="Guardar" ValidationGroup="GuardarGroup" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
                <asp:Button runat="server" ID="btnModificar" Text="Modificar" ValidationGroup="GuardarGroup" CssClass="btn btn-primary" OnClick="btnModificar_Click" />
                <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" OnClick="btnCancelar_Click" />
            </div>

        </div>
    </section>


</asp:Content>















