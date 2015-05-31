<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AgenciaViajes.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="">
    <div class="row" >
        <div class="col-md-4 col-md-offset-4">
            <asp:Login ID="LoginControl" runat="server" OnAuthenticate="Login_Authenticate" RememberMeText="Recordar Usuario" LoginButtonText="Iniciar Sesión" >
                                <TitleTextStyle CssClass="title control-title"/>
                <TextBoxStyle CssClass="form-control"/>
                <LabelStyle CssClass="label-control" />
                <CheckBoxStyle CssClass="checkbox-inline" />
                <LoginButtonStyle CssClass="btn btn-primary" />


            </asp:Login>
        </div>
    </div>
    </section>
        
            
        
    
</asp:Content>
