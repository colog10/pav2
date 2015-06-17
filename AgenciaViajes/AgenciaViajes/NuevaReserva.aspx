<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="NuevaReserva.aspx.cs" Inherits="AgenciaViajes.NuevaReserva" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(document).ready(function () {
            $("[id$=txtFechaSalida]").datepicker();
            $("[id$=txtFechaRegreso]").datepicker();
            $("[id$=txtFechaVencimientoReserva]").datepicker();
            $("[id$=txtFechaHastaAlojamiento]").datepicker();
            $("[id$=txtFechaDesdeAlojamiento]").datepicker();
            $("[id$=txtFechaVencimientoReservaAlojamiento]").datepicker();     
            
        });

        
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="reservaSection" runat="server" class="container-transaccion">

        <div class="row">
            <div class="col-md-12">
               <h3>Nueva Reserva</h3>
            </div>
        </div>

        <div class="row">
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Número</label>
                    <asp:TextBox ID="txtNumero" runat="server" CssClass="form-control" MaxLength="30"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div  class="form-group">
                    <label>Cliente</label>
                    <asp:TextBox type="text" id="txtCliente" runat="server" maxlength="50" class="form-control" />
                    <asp:Button runat="server" ID="btnBuscarCliente" OnClick="btnBuscarCliente_Click" Text="Buscar" />
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="gvClientes" runat="server" DataKeyNames="idClienteDTO" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="razonSocialDTO" HeaderText="Razon Social" />
                        <asp:CommandField HeaderText="Acción" ShowSelectButton="True" />
                    </Columns>
                    <SelectedRowStyle BackColor="Salmon" ForeColor="Black" />
                </asp:GridView>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
               <h4>Detalle Reserva</h4>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12"> 
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar"  OnClick="btnAgregar_Click" />
                <br />
                <br />
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <asp:GridView runat="server" ID="gvDetalleReserva" DataKeyNames="IdReserva" EmptyDataText="Haz click en agregar para ingresar los datos del viaje" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="NombrePasajero" HeaderText="Nombre" />
                        <asp:BoundField DataField="ApellidoPasajero" HeaderText="Apellido" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Button Text="Guardar"  OnClick="btnGuardar_Click" ID="btnGuardar" runat="server" />
            </div>
        </div>
    </section>    
    <section id="reservaDetalleSection" runat="server"  class="container-transaccion">
        <div class="row">
            <div class="col-md-12">
                <h2>Detalle Pasajero</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div  class="form-group">
                    <label>Pasajero</label>
                    <asp:TextBox type="text" id="txtPasajero" runat="server" maxlength="50" class="form-control" />
                    <asp:Button runat="server" ID="btnBuscarPasajero" OnClick="btnBuscarPasajero_Click" Text="Buscar" />
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="gvPasajeros" runat="server" DataKeyNames="IdPasajero" AutoGenerateColumns="False"   EmptyDataText="No se encontraron pasajeros con el parámetro de búsqueda" ShowHeaderWhenEmpty="True">
                    <Columns>
                        <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:CommandField HeaderText="Acción" ShowSelectButton="True" />
                    </Columns>
                    <SelectedRowStyle BackColor="Salmon" ForeColor="Black" />
                </asp:GridView>
            </div>
        </div>

        <div class="row">
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Documento Viaje:</label>
                    <br />
                    <asp:DropDownList runat="server" ID="ddlDocumentoViaje"></asp:DropDownList>
                </div>
            </div>
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Número documento:</label>
                    <asp:TextBox runat="server" ID="txtNumeroDocumentoViaje" MaxLength="8"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <h2>Servicio Translado</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Pais Origen:</label><br />
                    <asp:DropDownList runat="server" ID="ddlPaisOrigen" AutoPostBack="true" OnSelectedIndexChanged="ddlPaisOrigen_SelectedIndexChanged"></asp:DropDownList>
                </div>
            </div>
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Ciudad Destino:</label><br />
                    <asp:DropDownList runat="server" ID="ddlOrigen"></asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Pais Destino:</label><br />
                    <asp:DropDownList runat="server" ID="ddlPaisDestino" OnSelectedIndexChanged="ddlPaisDestino_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                 </div>
            </div>
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Ciudad Destino:</label><br />
                    <asp:DropDownList runat="server" ID="ddlDestino"></asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Fecha Salida:</label>
                    <asp:TextBox id="txtFechaSalida" runat="server"/>
                </div>
            </div>
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Fecha Regreso:</label>
                    <asp:TextBox ID="txtFechaRegreso" runat="server"/>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Fecha Vencimiento Reserva:</label>
                    <asp:TextBox ID="txtFechaVencimientoReserva" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Compañia Aerea:</label><br />
                    <asp:DropDownList ID="ddlTransporte" runat="server"></asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Monto:</label><br />
                    <asp:TextBox runat="server" ID="txtMonto"></asp:TextBox>
                </div>
            </div>
        </div>                 
        
        <div class="row">
            <div class="col-md-12">
                <h2>Alojamiento</h2>
            </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div  class="form-group">
                        <label>Alojamiento:</label><br />
                        <asp:DropDownList ID="ddlAlojamiento" runat="server"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div  class="form-group">
                        <label>Fecha Desde:</label><br />
                        <asp:TextBox ID="txtFechaDesdeAlojamiento" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6">
                    <div  class="form-group">
                        <label>Fecha Hasta:</label><br />
                        <asp:TextBox ID="txtFechaHastaAlojamiento" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">

                <div class="col-md-6">
                    <div  class="form-group">
                        <label>Fecha Vencimiento Reserva:</label><br />
                        <asp:TextBox ID="txtFechaVencimientoReservaAlojamiento" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
        
            <div class="row">
                <div class="col-md-6">
                    <div  class="form-group">
                        <label>Monto:</label>
                        <asp:TextBox runat="server" ID="txtMontoAlojamiento"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <h2> Seguro Viajero</h2>
                </div>
            </div>
            <div class="row">
               <div class="col-md-6">
                    <div  class="form-group">
                        <label>Tipo Seguro Viajero:</label><br />
                        <asp:DropDownList runat="server" ID="ddlTipoSeguro"></asp:DropDownList>
                    </div>
                </div>
                <div class="col-md-6">
                    <div  class="form-group">
                        <label>Observaciones</label>
                        <asp:TextBox ID="txtObservaciones" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div  class="form-group">
                        <label>Monto:</label>
                        <asp:TextBox runat="server" ID="txtMontoSeguro"></asp:TextBox>
                    </div>
                </div>
            </div>
        
        <div class="row">
            <div class="col-md-12">
                <asp:Button runat="server" ID="btnAceptar" OnClick="btnAceptar_Click1" Text="Aceptar"/><asp:Button runat="server" ID="btnCancelar" OnClick="btnCancelar_Click" Text="Cancelar" />
            </div>
        </div>
    </section>    
</asp:Content>
