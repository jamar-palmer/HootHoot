<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="OwlSpace.ProfilePage" %>

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
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                <!-- dynamic data -->
            </div>
        </div>
    </form>
</body>
</html>
