<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="AgenciaViajes.Modules.Menu" %>


<div class="navbar navbar-inverse  navbar-fixed-top" role="navigation">
     <div class="container-fluid">
          <div class="collapse navbar-collapse">
    
<asp:Literal runat="server" ID="lblMenuContent"/>
   <ul class="nav navbar-nav-inverse navbar-right">
 
       <li>
      <div class="links">
              
                    <asp:LoginView ID="topLoginView" runat="server">
                        <LoggedInTemplate>
                                <%=Membership.GetUser().UserName %>, <a href="<%=Page.ResolveUrl("~/Admin/logout.aspx")%>">
                                cerrar sesión</a>
                        </LoggedInTemplate>
                    </asp:LoginView>
                </div>

       </li>
    </ul>
    </div>
         </div>
    </div>





