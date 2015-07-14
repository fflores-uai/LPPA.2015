<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Forms/Shared/MasterPage.Master" CodeBehind="NewJobCandidate.aspx.vb" Inherits="Website.Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">

    <div class="container">

        <section id="ListJobCandidate">
            <article>

                <asp:GridView ID="JobCandidateTable" CssClass="dataTable" runat="server"></asp:GridView>
            </article>

            <article>

                <p style="padding-top: 10px;">
                    <label for="txtNumber">Number: </label>
                    <asp:TextBox ID="txtNumber" type="text" runat="server"></asp:TextBox>
                </p>

                <p style="padding-top: 20px;">
                    <asp:Button ID="btnViewJobCandidate" type="button" Text="View JobCandidate" runat="server" />
                </p>
                <p>
                    <label id="textoTest"></label>
                </p>
            </article>
        </section>
    </div>
    <script src="../../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/Views/RRHH/NewJobCandidate.js"></script>
</asp:Content>