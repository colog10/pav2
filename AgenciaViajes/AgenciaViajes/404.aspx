<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="404.aspx.cs" Inherits="AgenciaViajes._404" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section id="error" class="container text-center page-404">
        <h1>404, Página no encontrada</h1>
        <p>La página no existe o ha ocurrido un error.</p>
        <a class="btn btn-primary" href="/">Ir a la página de inicio</a>
    </section><!--/#error-->
</asp:Content>
