<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseCatalogPage.aspx.cs" Inherits="OwlSpace.CourseCatalogPage" %>

<%@ Register Src="~/CatalogControl.ascx" TagPrefix="uc1" TagName="CatalogControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hoot Hoot Course Catalog</title>
    <link rel="stylesheet" href="~/Styling/CatalogStyle.css" />

    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap_css">
    <link rel="stylesheet" href="~/Styling/LoginStyle.css" />
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <!-- Breadcrumb -->
          <nav aria-label="breadcrumb" class="main-breadcrumb">
            <ol class="breadcrumb">
              <li class="breadcrumb-item active" aria-current="page"><a href="index.html">Home</a></li>
              <li class="breadcrumb-item"><a href="javascript:void(0)">User</a></li>
              <li class="breadcrumb-item" >User Profile</li>
            </ol>
          </nav>
          <!-- /Breadcrumb -->
            <div id="mainpage">
            Course Descriptions
             <br />
             <br />
            <table>
                <asp:Repeater ID="rptCourses" runat="server" OnItemCommand="rptCourses_ItemCommand">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <asp:Label ID="lblProgram" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Program") %>'></asp:Label>
                            </td>
                             <td>
                                <asp:Label ID="lblCRN" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "CourseNumber") %>'></asp:Label>
                            </td>
                             <td>
                                <asp:Label ID="lblHours" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "CreditHours") %>'></asp:Label>
                            </td>
                             <td>
                          
                                 <asp:LinkButton ID="lnkTitle" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Title") %>'></asp:LinkButton>
                            </td>
                        </tr>
                        <bt />
                    </ItemTemplate>

                </asp:Repeater>
            </table>
                </div>
        </div>
    </form>
</body>
</html>
