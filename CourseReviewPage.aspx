<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseReviewPage.aspx.cs" Inherits="OwlSpace.CourseReviewPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <!-- main div -->
        <div>
            <asp:Label ID="Label1" runat="server" Text="Please select a course to review"></asp:Label>
            <table>
                <tr>
                    <th>Course</th>
                    <th>CRN</th>
                    <th>Select</th>
                </tr>
                <asp:Repeater ID="rptCourses" runat="server">
                    <ItemTemplate>
                    <tr>
                        <td>
                        <asp:Label ID="lblTitle" runat="server" Text='<%# Bind("Title") %>'></asp:Label>
                        </td>
                        <td>
                        <asp:Label ID="lblCRN" runat="server" Text='<%# Bind("Title") %>'></asp:Label>
                    </td>
                        <td>
                            <asp:Button ID="btnSelect" runat="server" Text="Review" />
                        </td>
                    </tr>
                </ItemTemplate>
                </asp:Repeater>         
            </table>
        </div>
        <!-- review div -->
        <div>
            <asp:Label ID="lblReview" runat="server" Text="Please answer the following using the dropdown lists."></asp:Label>
            <br />
            <asp:Label ID="lblReview1" runat="server" Text="The material taught in this course was interesting"></asp:Label>
            <asp:DropDownList ID="ddlReview1" runat="server">
                <asp:ListItem>Strongly Agree</asp:ListItem>
                <asp:ListItem>Agree</asp:ListItem>
                <asp:ListItem>Neutral</asp:ListItem>
                <asp:ListItem>Disagree</asp:ListItem>
                <asp:ListItem>Strongly Disagree</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblReview2" runat="server" Text="The material taught in this course helped me with my major"></asp:Label>
            <asp:DropDownList ID="ddlReview2" runat="server">
                <asp:ListItem>Strongly Agree</asp:ListItem>
                <asp:ListItem>Agree</asp:ListItem>
                <asp:ListItem>Neutral</asp:ListItem>
                <asp:ListItem>Disagree</asp:ListItem>
                <asp:ListItem>Strongly Disagree</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblReview3" runat="server" Text="The course provided an excellent learning environment"></asp:Label>
            <asp:DropDownList ID="ddlReview3" runat="server">
                <asp:ListItem>Strongly Agree</asp:ListItem>
                <asp:ListItem>Agree</asp:ListItem>
                <asp:ListItem>Neutral</asp:ListItem>
                <asp:ListItem>Disagree</asp:ListItem>
                <asp:ListItem>Strongly Disagree</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblReview4" runat="server" Text="The professor taught this course well"></asp:Label>
            <asp:DropDownList ID="ddlReview4" runat="server">
                <asp:ListItem>Strongly Agree</asp:ListItem>
                <asp:ListItem>Agree</asp:ListItem>
                <asp:ListItem>Neutral</asp:ListItem>
                <asp:ListItem>Disagree</asp:ListItem>
                <asp:ListItem>Strongly Disagree</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblReview5" runat="server" Text="The professor was fair in their grading"></asp:Label>
            <asp:DropDownList ID="ddlReview5" runat="server">
                <asp:ListItem>Strongly Agree</asp:ListItem>
                <asp:ListItem>Agree</asp:ListItem>
                <asp:ListItem>Neutral</asp:ListItem>
                <asp:ListItem>Disagree</asp:ListItem>
                <asp:ListItem>Strongly Disagree</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblReview6" runat="server" Text="Please write a review for the class (optional)"></asp:Label>
            <asp:TextBox ID="txtReview" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
