<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="OwlSpace.ProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Hoot Hoot Course Planner</title> 
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap_css">
    <link rel="stylesheet" href="~/Styling/LoginStyle.css" />
    <link rel="stylesheet" href="~/Styling/ProfileStyle.css" />
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
           
            <div id="content">
                <h1>Course Registration</h1>

                <div>
                <h3>Select Semester: </h3><asp:DropDownList ID="ddlSemester" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSemester_SelectedIndexChanged"></asp:DropDownList>
                    </div>
                <br />
                <!-- dynamic data -->
                <div runat="server" id="coursesDiv">


                </div>

                <div>
                    <asp:Button ID="btnRemove" runat="server" Text="Clear Roster" BackColor="#990033" ForeColor="White" OnClick="btnRemove_Click" />
                </div>
               
            </div>
                   
        </div>
    </form>
</body>
</html>
