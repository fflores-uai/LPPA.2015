<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Forms/Shared/MasterPage.Master" CodeBehind="JobCandidateDetail.aspx.vb" Inherits="Website.JobCandidateDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">

    <section>
        <article>

            <asp:GridView CssClass="datable" ID="JobCandidateTable" runat="server"></asp:GridView>

        </article>
    </section>

</asp:Content>
