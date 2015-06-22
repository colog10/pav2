<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Reservas.aspx.cs" Inherits="AgenciaViajes.Reservas" %>



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
               <h3>Informe Reserva</h3>
            </div>
        </div>

        <div class="row">
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Monto</label>
                    <asp:TextBox type="text" id="txtMonto" runat="server" maxlength="50" class="form-control" />
                </div>
            </div>
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Fecha Reserva</label>
                    <asp:TextBox type="text" id="txtFechaReserva" runat="server" maxlength="12" class="form-control" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Efectuada</label>
                    <asp:CheckBox runat="server" ID="chkEfectuada" />
                </div>

            </div>
            <div class="col-md-6">
                <div  class="form-group">
                    <label>Empleado</label>
                    <asp:DropDownList runat="server" ID="ddlEmpleado"></asp:DropDownList>
                </div>

            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Button runat="server" ID="btnBuscarReserva" OnClick="btnBuscarReserva_Click" Text="Buscar" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <br/>
                <asp:GridView runat="server" ID="gvReservas" AutoGenerateColumns="False"  AllowSorting="true" AllowPaging="true" OnPageIndexChanging="gvReservas_PageIndexChanging" PageSize="5">
                    <Columns>
                        <asp:BoundField DataField="NumeroReserva" HeaderText="Numero" />
                        <asp:BoundField DataField="NombreYApellidoEmpleado" HeaderText="Empleado" />
                        <asp:BoundField DataField="NombreCliente" HeaderText="Cliente" />
                        
                        <asp:TemplateField HeaderText="Monto">
                        <ItemTemplate>
                            <%# String.Format("${0}", Convert.ToDouble(Eval("Monto"))) %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    </Columns>

                </asp:GridView>
            </div>
        </div>

    </section>
</asp:Content>