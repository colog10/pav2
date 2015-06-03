<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OperadoresTuristicos.aspx.cs" Inherits="AgenciaViajes.OperadoresTuristicos" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $("[id$=txtFechaAlta]").datepicker();
        });
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="SectionConsulta" class="abm-section container-crud" runat="server">
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
                      <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" AutoPostBack="True">
                      </asp:TextBox>
                 </div>
            </div>
        </div>

        <div class="row" >
            <div class="col-md-12">
                <asp:GridView ID="gvOperadoresTuristicos" runat="server" ShowHeaderWhenEmpty="true" EmptyDataText="No hay datos para mostrar" AutoGenerateColumns="false">
                    <Columns>
                        <asp:CommandField ShowSelectButton="true" />
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
               </div>
            </div>
            <div class="col-md-6">
               <div class="form-group">
                   <label>Domicilio del Operador Turístico</label>
                   <asp:TextBox ID="txtDomicilioOperador" runat="server" CssClass="form-control"></asp:TextBox>
                   
               </div>
           </div>
        </div>

        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label>Tipo de Destino</label><br />
                    <asp:DropDownList ID="ddlTipoDestino" runat="server" DataValueField="idTipoDestino" DataTextField="descripcion">
                        <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>Calificacion</label><br />
                    <asp:DropDownList ID="ddlCalificacion" runat="server">
                        <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

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
                    <asp:CheckBox ID="chkActivo" runat="server" text=" Activo" />
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>Fecha de Alta</label>
                    <asp:TextBox ID="txtFechaAlta" runat="server" CssClass="form-control" ></asp:TextBox>
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
        </div>



         <div class="row">
            <div class="col-md-12">
                <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
                <asp:Button runat="server" ID="btnModificar" Text="Modificar" CssClass="btn btn-primary" OnClick="btnModificar_Click"/>
                <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" OnClick="btnCancelar_Click"/>
            </div>
        </div>
    </section>


</asp:Content>
                            














