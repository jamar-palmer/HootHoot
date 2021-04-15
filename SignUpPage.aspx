<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUpPage.aspx.cs" Inherits="HootHoot.SignUpPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hoot Hoot Registration</title>
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap_css">
    <link rel="stylesheet" href="~/Styling/RegisterStyle.css" />
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
	<div class="row">
    <div class="col-md-8">   
        <h1 class="entry-title"><span>Sign Up</span> </h1>
        <hr>
   
        <div class="form-group">
          <label class="control-label col-sm-3">Email Address<span class="text-danger">*</span></label>
          <div class="col-md-8 col-sm-9">
              <div class="input-group">
              <span class="input-group-addon"><i class="glyphicon glyphicon-envelope"></i></span>
              <input type="email" class="form-control" name="emailid" id="emailid" placeholder="Enter your Email" value="">
            </div>
            <small> Your must have a Temple email address to register as a student user. </small> </div>
        </div>
        
        <div class="form-group">
          <label class="control-label col-sm-3">Set Password <span class="text-danger">*</span></label>
          <div class="col-md-5 col-sm-8">
            <div class="input-group">
              <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
              <input type="password" class="form-control" name="password" id="password" placeholder="Choose password (5-15 chars)" value="">
           </div>   
          </div>
        </div>
        <div class="form-group">
          <label class="control-label col-sm-3">Confirm Password <span class="text-danger">*</span></label>
          <div class="col-md-5 col-sm-8">
            <div class="input-group">
              <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
              <input type="password" class="form-control" name="cpassword" id="cpassword" placeholder="Confirm your password" value="">
            </div>  
          </div>
        </div>
        <div class="form-group">
          <label class="control-label col-sm-3">First Name <span class="text-danger">*</span></label>
          <div class="col-md-8 col-sm-9">
            <input type="text" class="form-control" name="mem_name" id="mem_name" placeholder="Enter your First Name here" value="">
          </div>
        </div>
        <div class="form-group">
          <label class="control-label col-sm-3">Last Name <span class="text-danger">*</span></label>
          <div class="col-md-8 col-sm-9">
            <input type="text" class="form-control" name="last_name" id="last_name" placeholder="Enter your Last Name here" value="">
          </div>
        </div>
        <div class="form-group">
          <label class="control-label col-sm-3">User Type <span class="text-danger">*</span></label>
          <div class="col-md-8 col-sm-9">
            <label>
            <input name="student" type="radio" value="Student" checked>
            Student </label>
               
            <label>
            <input name="admin" type="radio" value="Administrator" >
            Administrator </label>
          </div>
        </div>
        <div class="form-group">
          <label class="control-label col-sm-3">Major <span class="text-danger">*</span></label>
          <div class="col-md-8 col-sm-9">
            <input type="text" class="form-control" name="major" id="major" placeholder="Enter your Major here" value="">
          </div>
        </div>
        <div class="form-group">
          <label class="control-label col-sm-3">Total Credits <span class="text-danger">*</span></label>
          <div class="col-md-8 col-sm-9">
            <input type="text" class="form-control" name="credits" id="credits" placeholder="Enter your total number of credits here" value="">
          </div>
        </div>
        <div class="form-group">
          <label class="control-label col-sm-3">Profile Photo </label>
          <div class="col-md-5 col-sm-8">
            <div class="input-group"> <span class="input-group-addon" id="file_upload"><i class="glyphicon glyphicon-upload"></i></span>
              <input type="file" name="file_nm" id="file_nm" class="form-control upload" placeholder="" aria-describedby="file_upload">
            </div>
          </div>
        </div>
        <div class="form-group">
          <div class="col-xs-offset-3 col-xs-10">
            <asp:Button ID="btnSignUp" runat="server" Text="Sing Up" BackColor="#990033" ForeColor="White" OnClick="btnSignUp_Click" />
          </div>
        </div>
   
    </div>
</div>
</div>
    </form>
</body>
</html>
