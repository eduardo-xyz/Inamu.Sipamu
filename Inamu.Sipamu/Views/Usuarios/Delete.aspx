<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Inamu.Sipamu.Models.SEG_USUARIO>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>SEG_USUARIO</legend>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.I_IDUSUARIO) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.I_IDUSUARIO) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.CAT_PERSONA.VC_IDENTIFICACION) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CAT_PERSONA.VC_IDENTIFICACION) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.SEG_PERFIL.VC_DESCRIPCION) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.SEG_PERFIL.VC_DESCRIPCION) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.VC_LOGIN) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.VC_LOGIN) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.VC_CONTRASENNA) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.VC_CONTRASENNA) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
<% } %>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
