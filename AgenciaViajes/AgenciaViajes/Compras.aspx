<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="AgenciaViajes.Compras" %>

<%@ Register Src="~/Modules/ConstructionPage.ascx" TagPrefix="uc1" TagName="ConstructionPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(document).ready(function () {
            $("[id$=txtFechaCompra]").datepicker();
            $("[id$=txtFechaReserva]").datepicker();
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


<section runat="server" class="container-transaccion">
        <div class="row">
            <div class="col-md-12">
               <h3>Informe Compras</h3>
            </div>
        </div>

        <div class="row">
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Fecha Compra</label>
                    <asp:TextBox type="text" id="txtFechaCompra" runat="server" maxlength="10" class="form-control" />
                </div>
            </div>
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Fecha Reserva</label>
                    <asp:TextBox type="text" id="txtFechaReserva" runat="server" maxlength="10" class="form-control" />
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
                    <label>Operador Turistico</label>
                    <asp:DropDownList runat="server" ID="ddlOperadorTuristico"></asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Button runat="server" ID="btnBuscarCompra" OnClick="btnBuscarCompra_Click" Text="Buscar" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <br/>
                <asp:GridView runat="server" ID="gvCompras" AutoGenerateColumns="False" PageSize="5" OnPageIndexChanging="gvCompras_PageIndexChanging" AllowPaging="true"  >
                    <Columns>
                        <asp:BoundField DataField="NumeroFactura" HeaderText="Nro. Factura" />
                        
                        <asp:TemplateField HeaderText="Fecha Compra">
                            <ItemTemplate>
                                <%# Convert.ToDateTime(Eval("fechaCompraDTO")).ToShortDateString() %>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:BoundField DataField="NombreOperadorTuristico" HeaderText="Operador Turístico" />
                        <asp:BoundField DataField="TelefonoOperadorTuristico" HeaderText="Telefono" />
                        
                        <asp:TemplateField HeaderText="Monto">
                            <ItemTemplate>
                                <%# String.Format("${0}", Convert.ToDouble(Eval("montoDTO"))) %>
                            </ItemTemplate>
                        </asp:TemplateField>


                    </Columns>

                </asp:GridView>
            </div>
        </div>

    </section>
</asp:Content>
