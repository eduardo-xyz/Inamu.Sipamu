<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Inamu.Sipamu.Models.SEG_USUARIO>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
<table>
    <tr>
        <th>
            <%: Html.DisplayNameFor(model => model.I_IDUSUARIO) %>
        </th>
        <td>   </td>
        <th>
            <%: Html.DisplayNameFor(model => model.CAT_PERSONA.VC_IDENTIFICACION) %>
        </th>
        <td>   </td>
        <th>
            <%: Html.DisplayNameFor(model => model.SEG_PERFIL.VC_DESCRIPCION) %>
        </th>
        <td>   </td>
        <th>
            <%: Html.DisplayNameFor(model => model.VC_LOGIN) %>
        </th>
        <td>   </td>
        <th>
            <%: Html.DisplayNameFor(model => model.VC_CONTRASENNA) %>
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.I_IDUSUARIO) %>
        </td>
        <td>   </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.CAT_PERSONA.VC_IDENTIFICACION) %>
        </td>
        <td>   </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.SEG_PERFIL.VC_DESCRIPCION) %>
        </td>
        <td>   </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.VC_LOGIN) %>
        </td>
        <td>   </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.VC_CONTRASENNA) %>
        </td>
        <td>   </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
            <%: Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
