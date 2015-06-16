<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="NuevaReserva.aspx.cs" Inherits="AgenciaViajes.NuevaReserva" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(document).ready(function () {
            ("#txtCliente").autocompletable();
            ("#txtPasajero").autocompletable();
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
               <h4> Pasajeros</h4>
            </div>
        </div>



        <div class="row">
            <div class="col-md-12"><asp:Button ID="btnAgregar" runat="server" Text="Agregar" /></div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <asp:GridView runat="server" ID="gvPasajeros" DataKeyNames="IdReserva" EmptyDataText="No hay datos para mostrar" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                    </Columns>

                </asp:GridView>
            </div>
        </div>

    </section>    
    <section id="reservaDetalleSection" runat="server"  class="container-transaccion">
        <div class="row">
            <div class="col-md-3">Pasajero: </div>
            <div class="col-md-3"><input id="txtPasajero" runat="server" type="text" /></div>
        </div>
        <div class="row">
            <div class="col-md-3">Documento Viaje:</div>
            <div class="col-md-3"><asp:DropDownList runat="server" ID="ddlDocumentoViaje"></asp:DropDownList></div>
            <div class="col-md-3">Número Documento: </div>
            <div class="col-md-3"><asp:TextBox runat="server" ID="txtNumeroDocumentoViaje"></asp:TextBox></div>
        </div>
        <div class="row">
            <div class="col-md-12">
                Servicio Translado
            </div>
            <div class="row">
                <div class="col-md-3">Origen:</div>
                <div class="col-md-3"><asp:DropDownList runat="server" ID="ddlOrigen"></asp:DropDownList></div>
                <div class="col-md-3">Destino:</div>
                <div class="col-md-3"><asp:DropDownList runat="server" ID="ddlDestino"></asp:DropDownList></div>
            </div>
            <div class="row">
                <div class="col-md-3">Fecha Salida:</div>
                <div class="col-md-3"><asp:TextBox ID="txtFechaSalida" runat="server"></asp:TextBox></div>
                <div class="col-md-3">Fecha Regreso</div>
                <div class="col-md-3"><asp:TextBox ID="txtFechaRegreso" runat="server"></asp:TextBox></div>
            </div>
            <div class="row">
                <div class="col-md-3">Fecha Vencimiento Reserva:</div>
                <div class="col-md-3"><asp:TextBox ID="txtFechaVencimientoTeserva" runat="server"></asp:TextBox></div>
                <div class="col-md-3">Compañia transporte:</div>
                <div class="col-md-3"><asp:DropDownList ID="ddlTransporte" runat="server"></asp:DropDownList></div>
            </div>
            <div class="row">
                <div class="col-md-3">Monto:</div>
                <div class="col-md-3"><asp:TextBox runat="server" ID="txtMonto"></asp:TextBox></div>
                <div class="col-md-3"></div>
                <div class="col-md-3"></div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                Alojamiento
            </div>
            <div class="row">
                <div class="col-md-3">Alojamiento:</div>
                <div class="col-md-3"><asp:DropDownList ID="ddlAlojamiento" runat="server"></asp:DropDownList></div>
                <div class="col-md-3"></div>
                <div class="col-md-3"></div>
            </div>
            <div class="row">
                <div class="col-md-3">Fecha Desde:</div>
                <div class="col-md-3"><asp:TextBox ID="txtFechaDesdeAlojamiento" runat="server"></asp:TextBox></div>
                <div class="col-md-3">Fecha Hasta: </div>
                <div class="col-md-3"><asp:TextBox ID="txtFechaHastaAlojamiento" runat="server"></asp:TextBox></div>
            </div>
            <div class="row">
                <div class="col-md-3">Fecha Vencimiento Reserva:</div>
                <div class="col-md-3"><asp:TextBox ID="txtFechaVencimientoReservaAlojamiento" runat="server"></asp:TextBox></div>
                <div class="col-md-3"></div>
                <div class="col-md-3"></div>
            </div>
            <div class="row">
                <div class="col-md-3">Monto:</div>
                <div class="col-md-3"><asp:TextBox runat="server" ID="txtMontoAlojamiento"></asp:TextBox></div>
                <div class="col-md-3"></div>
                <div class="col-md-3"></div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                Seguro Viajero
            </div>
            <div class="row">
                <div class="col-md-3">Tipo Seguro Viajero:</div>
                <div class="col-md-3"><asp:DropDownList runat="server" ID="ddlTipoSeguro"></asp:DropDownList></div>
                <div class="col-md-3">Observaciones</div>
                <div class="col-md-3"><asp:TextBox ID="txtObservaciones" runat="server"></asp:TextBox></div>
            </div>
            <div class="row">
                <div class="col-md-3">Monto:</div>
                <div class="col-md-3"><asp:TextBox runat="server" ID="txtMontoSeguro"></asp:TextBox></div>
                <div class="col-md-3"></div>
                <div class="col-md-3"></div>
            </div>
        </div>
    </section>    
</asp:Content>
