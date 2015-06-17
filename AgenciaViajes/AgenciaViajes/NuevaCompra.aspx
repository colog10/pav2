<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="NuevaCompra.aspx.cs" Inherits="AgenciaViajes.NuevaCompra" %>

<%@ Register Src="~/Modules/ConstructionPage.ascx" TagPrefix="uc1" TagName="ConstructionPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<uc1:ConstructionPage runat="server" id="ConstructionPage" />--%>
    <br />
    <br />
    <br />
    
    <section id="seccionReserva" runat="server" class="container-transaccion">
        <div class="row">
        <h2>Registración de Pago a Proveedor</h2>        
    </div>
    <br />
    <br />
    <br />
    <div class="col-lg-3"></div>
    <div class="col-lg-6">
        <asp:GridView ID="gvListaDeReservas" runat="server" DataKeyNames="idPasajero" EmptyDataText="Algún texto" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="NombrePasajero" HeaderText="Nombre" />
                <asp:BoundField DataField="ApellidoPasajero" HeaderText="Apellido" />
                
            </Columns>
        </asp:GridView>        
    </div>
    <div class="col-lg-3"></div>
    </section>


    <section id="sectionDetalleReserva" runat="server" class="container-transaccion">




    </section>



</asp:Content>
