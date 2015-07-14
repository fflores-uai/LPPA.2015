<%@ Page Title="LOG IN" Language="vb" AutoEventWireup="false" MasterPageFile="~/Forms/Shared/MasterPage.Master" CodeBehind="LogIn.aspx.vb" Inherits="Website.LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Content/LogInStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">

    <div class="container">

        <fieldset>

            <div id="logInBlock">
                <div id="border">
                    <div class="panel-title">
                        <h2 id="LogInTitle">ADVENTURE WORKS</h2>
                    </div>

                    <p>
                        <label for="txtUser">USER: </label>
                        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                    </p>
                    <p>
                        <label for="txtPassword">PASS: </label>
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </p>

                    <p style="padding-top: 10px;" id="logInButtons">
                        <asp:Button ID="btnLog" type="button" Text="Log In" CssClass="btn-lg btn-danger" runat="server" />
                    </p>
                </div>
            </div>
        </fieldset>
    </div>
</asp:Content>