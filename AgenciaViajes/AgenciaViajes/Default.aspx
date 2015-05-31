<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AgenciaViajes.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<section class="no-margin">
        <div class="item main-item" style="background-image: url(images/slider/bg1.jpg);">
        </div><!--/.item-->
    </section><!--/#main-slider-->

    <section id="feature" >
        <div class="container">
           <div class="center wow fadeInDown">
                <h2>Características</h2>
                <p class="lead">Aplicación en la nube para la gestión y administración relacionada a venta de paquetes turísticos. <br/>Desde aquí podrás ingresar nuevos datos, gestionarlos y obtener información que te permitirá controlar y tomar desiciones facilmente.</p>
            </div>

            <div class="row">
                <div class="features">
                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-plane"></i>
                            <h2>Ventas</h2>
                            <h3>Permite el ingreso y la consulta de ventas.</h3>
                        </div>
                    </div><!--/.col-md-4-->

                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-credit-card"></i>
                            <h2>Compras</h2>
                            <h3>Registro de compras de paquetes turísticos.</h3>
                        </div>
                    </div><!--/.col-md-4-->

                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-check"></i>
                            <h2>Reservas</h2>
                            <h3>El cliente podrá realizar sus reservas desde su casa.</h3>
                        </div>
                    </div><!--/.col-md-4-->
                
                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-pencil"></i>
                            <h2>Administración</h2>
                            <h3>Datos de pasajeros, operadores y empleados.</h3>
                        </div>
                    </div><!--/.col-md-4-->

                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-list-alt"></i>
                            <h2>Consultas</h2>
                            <h3>Informes y búsquedas avanzadas.</h3>
                        </div>
                    </div><!--/.col-md-4-->

                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-certificate"></i>
                            <h2>Mejora contínua</h2>
                            <h3>Adaptaciones, inovaciones y soporte. </h3>
                        </div>
                    </div><!--/.col-md-4-->
                </div><!--/.services-->
            </div><!--/.row-->    
        </div><!--/.container-->
    </section><!--/#feature-->

    <section id="recent-works">
        <div class="container">
            <div class="center wow fadeInDown">
                <h2>Lo Nuevo</h2>
                <p class="lead">Gestión de pasajeros, operadores turísticos y empleados.<br /> Permite una ágil manipulación de los datos y obtener listados de esta información.</p>
            </div>           
        </div><!--/.container-->
    </section><!--/#recent-works-->
</asp:Content>