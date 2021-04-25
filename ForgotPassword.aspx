﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="OwlSpace.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Hoot Hoot Forgot Password</title>
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap_css">
    <link rel="stylesheet" href="~/Styling/ForgotStyle.css" />
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="card login-form">
	<div class="card-body">
		<h3 class="card-title text-center">Reset password</h3>
		
		<div class="card-text">
				<div class="form-group">
					<label for="exampleInputEmail1">Enter your email address and we will send you a link to reset your password.</label>
					<input type="email" class="form-control form-control-sm" placeholder="Enter your email address">
				</div>

			<div class="form-group">
					<label for="exampleInputEmail1">Security Question 1</label>
					<input type="text" class="form-control form-control-sm" placeholder="">
				</div>	


				<button type="submit" class="btn btn-primary btn-block">Send password reset email</button>

			    <br />
                <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" Text="Return" />

			<br />

		</div>


	</div>
</div>
        </div>
    </form>
</body>
</html>
