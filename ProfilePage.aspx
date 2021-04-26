<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="OwlSpace.ProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Hoot Hoot Course Planner</title> 
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
              <li class="breadcrumb-item active" aria-current="page"><a href="HomePage.aspx">User Profile</a></li>
              <li class="breadcrumb-item">Course Registration</li>
            </ol>
          </nav>
          <!-- /Breadcrumb -->
           
            <div>

                <asp:DropDownList ID="ddlSemester" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSemester_SelectedIndexChanged"></asp:DropDownList>
                <!-- dynamic data -->
                
               
            </div>
                   
        </div>
    </form>
</body>
</html>
