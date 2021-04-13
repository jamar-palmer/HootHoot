<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="HootHoot.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hoot Hoot</title>
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap_css">
    <link rel="stylesheet" href="~/Styling/LoginStyle.css" />
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="sidenav">
         <div class="login-main-text">
            <h2>Hoot Hoot<br> Login Page</h2>
            <p>Login or register from here to access.</p>
         </div>
      </div>
        <div class="main">
         <div class="col-md-6 col-sm-12">
            <div class="login-form">
                  <div class="form-group">
                     <label>User Name</label>
                     <input type="text" class="form-control" placeholder="User Name">
                  </div>
                  <div class="form-group">
                     <label>Password</label>
                     <input type="password" class="form-control" placeholder="Password">
                  </div>
                  <button type="submit" class="btn btn-black" runat="server" onserverclick="Login_Button_Click">Login</button>
                  <button type="submit" class="btn btn-secondary" runat="server" onserverclick="Register_Button_Click">Register</button>
            </div>
         </div>
      </div>
    </form>
</body>
</html>
