<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Inamu.Sipamu.Models.SEG_USUARIO>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Create</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>SEG_USUARIO</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.I_IDUSUARIO) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.I_IDUSUARIO) %>
            <%: Html.ValidationMessageFor(model => model.I_IDUSUARIO) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.I_IDPERSONA, "CAT_PERSONA") %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("I_IDPERSONA", String.Empty) %>
            <%: Html.ValidationMessageFor(model => model.I_IDPERSONA) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.I_IDPERFIL, "SEG_PERFIL") %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("I_IDPERFIL", String.Empty) %>
            <%: Html.ValidationMessageFor(model => model.I_IDPERFIL) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.VC_LOGIN) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.VC_LOGIN)%>            
            <%: Html.ValidationMessageFor(model => model.VC_LOGIN) %>            
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.VC_CONTRASENNA) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.VC_CONTRASENNA) %>
            <%: Html.ValidationMessageFor(model => model.VC_CONTRASENNA) %>
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
    <%: Scripts.Render("~/bundles/jqueryval") %>
</asp:Content>
