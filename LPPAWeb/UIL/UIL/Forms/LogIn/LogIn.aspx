<%@ Page Title="LOG IN" Language="vb" AutoEventWireup="false" MasterPageFile="~/Forms/Shared/MasterPage.Master" CodeBehind="LogIn.aspx.vb" Inherits="Website.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">

        
    <div class="cnt_login-front">

        <div class="clip">
            <div class="string"></div>
            <div class="tie"></div>
            <div class="triangle"></div>
            <div class="hook"></div>
        </div>

        <div class="badgecard">
            <i class="hole"></i>
            <i class="logo_fic"></i>

            <fieldset>


            
            <p>
            <label for="txtUser">USER ID: </label>
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                </p>
            <p>
            <label for="txtPassword">PASS: </label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </p>
                
</fieldset>                
                
                    <div class="alert alert-danger alert-dismissible" role="alert">
                        <button type="button" class="close" data-dismiss="alert">
                            <span aria-hidden="true">&times;</span>
                            <span class="sr-only">Close</span>
                        </button>
                        
                    </div>
            
            
        </div>

    </div>
    


</asp:Content>
