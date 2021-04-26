<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseCatalogPage.aspx.cs" Inherits="HootHoot.CourseCatalogPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlTerm" runat="server" OnSelectedIndexChanged="ddlTerm_SelectedIndexChanged">
                <asp:ListItem>Fall 2021</asp:ListItem>
                <asp:ListItem>Spring 2022</asp:ListItem>
                <asp:ListItem>Fall 2022</asp:ListItem>
            </asp:DropDownList>

            <table>
                <tr>
                    <th>Title</th>
                    <th>CourseID</th>
                    <th>Details</th>
                    <th>Hours</th>
                    <th>CRN</th>
                    <th>Register</th>
                </tr>

            <asp:Repeater ID="rptCourses" runat="server" OnItemCommand="rptCourses_ItemCommand">
                <ItemTemplate>
                <tr>
                    <td>
                        <asp:Label ID="lblTitle" runat="server" Text='<%# Bind("Title") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblID" runat="server" Text='<%# Bind("Title") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="btnDetails" runat="server" Text="Button" />
                    </td>
                    <td>
                        <asp:Label ID="lblHours" runat="server" Text='<%# Bind("Title") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblCRN" runat="server" Text='<%# Bind("Title") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox ID="cbRegister" runat="server" />
                    </td>
                </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
            
            <asp:Button ID="btnRegister" runat="server" Text="Register for Selected Courses" OnClick="btnRegister_Click" />
        </div>
    </form>
</body>
</html>
