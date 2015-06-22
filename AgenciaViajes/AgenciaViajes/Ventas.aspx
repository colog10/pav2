<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="AgenciaViajes.Ventas" %>

<%@ Register Src="~/Modules/ConstructionPage.ascx" TagPrefix="uc1" TagName="ConstructionPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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


    <section runat="server" class="container-transaccion">
        <div class="row">
            <div class="col-md-12">
               <h3>Informe Ventas</h3>
            </div>
        </div>

        <div class="row">
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Fecha Venta</label>
                    <asp:TextBox type="text" id="txtFechaVenta" runat="server" maxlength="10" class="form-control" />
                </div>
            </div>
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Cliente</label>
                    <asp:TextBox type="text" id="txtCliente" runat="server" maxlength="10" class="form-control" />
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Numero Factura</label>
                    <asp:TextBox type="text" id="txtNumeroFactura" runat="server" maxlength="12" class="form-control" />
                </div>

            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>Vendedor</label>
                    <asp:DropDownList runat="server" ID="ddlVendedor"></asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Button runat="server" ID="btnBuscarVenta" OnClick="btnBuscarVenta_Click" Text="Buscar" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:GridView runat="server" ID="gvVentas" AutoGenerateColumns="False" >
                    <Columns>
                        <asp:BoundField DataField="NumeroFactura" HeaderText="Nro. Factura" />
                        <asp:BoundField DataField="fechaVentaDTO" HeaderText="Fecha Venta" />
                        <asp:BoundField DataField="NombreCliente" HeaderText="Cliente" />
                        <asp:BoundField DataField="NombreVendedor" HeaderText="Empleado" />
                        <asp:BoundField DataField="LegajoVendedor" HeaderText="Legajo" />
                        <asp:BoundField DataField="montoDTO" HeaderText="Monto" />
                        

                    </Columns>

                </asp:GridView>
            </div>
        </div>

    </section>


</asp:Content>
