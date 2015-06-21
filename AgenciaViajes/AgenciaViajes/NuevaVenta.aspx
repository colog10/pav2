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
    <section class="row container-transaccion">
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
    </section>

    <section id="VentaSection" runat="server" class="container-transaccion">

        <div class="row">
            <div class="col-md-12">
                <h3>Nueva Venta</h3>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <asp:GridView runat="server" ID="gvReserva" DataKeyNames="IdReserva" EmptyDataText="no hay ninguna reserva de los datos ingresados" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnSelectedIndexChanged="gvReserva_SelectedIndexChanged">
                    <Columns>

                        <asp:BoundField DataField="IdReserva" HeaderText="IdReserva" SortExpression="idReserva" Visible="False" />
                        <asp:BoundField DataField="NombreCliente" HeaderText="RazonSocial" />
                        <%--<asp:BoundField DataField="ApellidoPasajero" HeaderText="Apellido" />--%>
                        <%--<asp:BoundField DataField="NombreSeguro" HeaderText="seguro" />
                        <asp:BoundField DataField="NombreAlojamiento" HeaderText="Servicio De Alojamiento" />--%>
                        <%--<asp:BoundField DataField="ServicioDeTraslado" HeaderText="Servicio De Traslado" />--%>
                        <asp:BoundField DataField="Comprada" HeaderText="Comprada" />
                        <asp:BoundField DataField="Efectuada" HeaderText="Efectuada" />
                        <asp:CommandField ShowSelectButton="True" />

                    </Columns>
                    <SelectedRowStyle BackColor="Salmon" ForeColor="Black" />
                </asp:GridView>
            </div>
        </div>

    </section>
    <section id="SectionDetalleReserva" runat="server" class="container-transaccion">

        <div class="row">
            <div class="col-md-12">
                <h3>Nueva Venta</h3>
            </div>
        </div>

        
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label>Nro. Factura</label>
                    <asp:TextBox ID="txtNroFactura" runat="server" MaxLength="12" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>


        <div class="row">
            <div class="col-md-12">
                <asp:GridView runat="server" ID="gvDetalleReserva" DataKeyNames="idDetallaReserva" EmptyDataText="" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="NombrePasajero" HeaderText="Nombre" />
                        <asp:BoundField DataField="ApellidoPasajero" HeaderText="Apellido" />
                        <asp:BoundField DataField="NombreSeguro" HeaderText="seguro" />
                        <asp:BoundField DataField="NombreAlojamiento" HeaderText="Servicio De Alojamiento" />
                        <asp:BoundField DataField="Comprada" HeaderText="Comprada" />
                        <asp:BoundField DataField="Efectuada" HeaderText="Efectuada" />

                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label>Comisión</label>
                    <asp:TextBox ID="txtComision" runat="server" MaxLength="50" CssClass="form-control" />
                    
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <label>Monto</label>
                <asp:TextBox ID="txtMontoTotal" runat="server" MaxLength="50" CssClass="form-control" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Button Text="Registrar Venta" OnClick="btnGuardar_Click" ID="Button2" runat="server" />
            </div>
        </div>
    </section>
</asp:Content>
