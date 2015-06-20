<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Reservas.aspx.cs" Inherits="AgenciaViajes.Reservas" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Button runat="server" ID="btnBuscarReserva" OnClick="btnBuscarReserva_Click" Text="Buscar" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:GridView runat="server" ID="gvReservas" AutoGenerateColumns="False" >
                    <Columns>
                        <asp:BoundField DataField="NumeroReserva" HeaderText="Numero" />
                        <asp:BoundField DataField="Monto" HeaderText="Monto" />
                    </Columns>

                </asp:GridView>
            </div>
        </div>

    </section>
</asp:Content>