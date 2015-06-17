<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="NuevaVenta.aspx.cs" Inherits="AgenciaViajes.NuevaVenta" %>

<%@ Register Src="~/Modules/ConstructionPage.ascx" TagPrefix="uc1" TagName="ConstructionPage" %>

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
    <section id="VentaSection" runat="server" class="container-transaccion">

        <div class="row">
            <div class="col-md-12">
                <h3>Nueva Venta</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <label>Nombre del Cliente</label>
                    <asp:TextBox type="text" ID="txtCliente" runat="server" MaxLength="50" class="form-control" />
                    <asp:Button runat="server" ID="btnBuscarCliente" OnClick="btnBuscarCliente_Click" Text="Buscar" />
                </div>
            </div>
        </div>       

        <div class="row">
            <div class="col-md-12">
                <asp:GridView runat="server" ID="gvDetalleVenta" DataKeyNames="IdVenta" EmptyDataText="Haz click en agregar para ingresar los datos del viaje" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="NombrePasajero" HeaderText="Nombre" />
                        <asp:BoundField DataField="ApellidoPasajero" HeaderText="Apellido" />
                        <asp:BoundField DataField="SeguroViajero" HeaderText="seguro" />
                        <asp:BoundField DataField="ServicioDeAlojamiento" HeaderText="Servicio De Alojamiento" />
                        <asp:BoundField DataField="ServicioDeTraslado" HeaderText="Servicio De Traslado" />
                        <asp:BoundField DataField="Comprada" HeaderText="Comprada" />
                        <asp:BoundField DataField="Vendido" HeaderText="Vendido" />
                        
                    </Columns>
                    <SelectedRowStyle BackColor="Salmon" ForeColor="Black" />
                </asp:GridView>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Button Text="Registrar Venta" OnClick="btnGuardar_Click" ID="btnGuardar" runat="server" />
            </div>
        </div>
    </section>
</asp:Content>
