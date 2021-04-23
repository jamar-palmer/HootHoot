<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseDetailsPage.aspx.cs" Inherits="OwlSpace.CourseDetailsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
            <div>

                <asp:Label ID="lblProgram" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblCourseTitle" runat="server" Text="Label"></asp:Label>
                <br />
                Credit Hours:
                <asp:Label ID="lblHours" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Label ID="lblDesc" runat="server" Text="Label"></asp:Label>
                <br />
                Repeatability:
                <asp:Label ID="lblRepeat" runat="server" Text="Label"></asp:Label>
                <br />
                Pre-requisites:
                <asp:Label ID="lblPreReq" runat="server" Text="Label"></asp:Label>

            </div>
        </div>
    </form>
</body>
</html>
