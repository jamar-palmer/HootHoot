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
            <!-- temp? -->
            <asp:GridView ID="gvCourses" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvCourses_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Title" HeaderText="Title" />
                    <asp:BoundField DataField="CourseId" HeaderText="Course ID" />
                    <asp:TemplateField HeaderText="Details">
                        <ItemTemplate>
                            <asp:Button ID="btnDetails" runat="server" Text="Click for Details" OnClick="btnDetails_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="CreditHours" HeaderText="Hours" />
                    <asp:BoundField DataField="CourseNumber" HeaderText="CRN" />
                    <asp:TemplateField HeaderText="Register">
                        <ItemTemplate>
                            <asp:CheckBox ID="cbRegister" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Button ID="btnRegister" runat="server" Text="Register for Selected Courses" OnClick="btnRegister_Click" />
        </div>
    </form>
</body>
</html>
