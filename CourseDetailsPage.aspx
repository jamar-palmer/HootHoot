<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseDetailsPage.aspx.cs" Inherits="HootHoot.CourseDetailsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th>Course</th>
                    <th>Course ID</th>
                    <th>CRN</th>
                    <th>Credit Hours</th>
                    <th>Program</th>
                    <th>PreReq</th>
                    <th>Description</th>
                </tr>

                <asp:Repeater ID="rptDetails" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <asp:Label ID="lblCourse" runat="server" Text='<%# Bind("Title") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblID" runat="server" Text='<%# Bind("CourseId") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblCRN" runat="server" Text='<%# Bind("CourseNumber") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblHours" runat="server" Text='<%# Bind("CreditHours") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblProgram" runat="server" Text='<%# Bind("Program") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblPrereq" runat="server" Text='<%# Bind("PreReq") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblDesc" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>

        </div>
    </form>
</body>
</html>
