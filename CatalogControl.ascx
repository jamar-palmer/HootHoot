<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CatalogControl.ascx.cs" Inherits="OwlSpace.CatalogControl" %>
<p>
    <asp:Label ID="lblProgram" runat="server"></asp:Label>
    :
    <asp:Label ID="lblCRN" runat="server"></asp:Label>
    . Credit Hours:
    <asp:Label ID="lblHours" runat="server"></asp:Label>
</p>
<p>
    <asp:HyperLink ID="hylTitle" runat="server" NavigateUrl="~/CourseDetailsPage.aspx">[hylTitle]</asp:HyperLink>
</p>

