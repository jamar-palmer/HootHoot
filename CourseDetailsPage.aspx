<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseDetailsPage.aspx.cs" Inherits="OwlSpace.CourseDetailsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hoot Hoot Course Details</title> 
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
              <li class="breadcrumb-item"><a href="CourseCatalogPage.aspx">Course Catalog</a></li>
              <li class="breadcrumb-item" >Course Details</li>
            </ol>
          </nav>
          <!-- /Breadcrumb -->
            <div>
                  <!-- Header -->
  <header class="bg-primary py-5 mb-5">
    <div class="container h-100">
      <div class="row h-100 align-items-center">
        <div class="col-lg-12">
          <h1 class="display-4 text-white mt-5 mb-2">
              <asp:Label ID="lblTitleProgram" runat="server"></asp:Label>
            </h1>
          <p class="lead mb-5 text-white-50">
              <asp:Label ID="lblSemester" runat="server"></asp:Label>
            </p>
        </div>
      </div>
    </div>
  </header>

  <!-- Page Content -->
  <div class="container">

    <div class="row">
      <div class="col-md-8 mb-5">
        <h2>Credit Hours:
            <asp:Label ID="lblCreds" runat="server"></asp:Label>
          </h2>
        <hr>
        <p>
            <asp:Label ID="lblDescript" runat="server"></asp:Label>
          </p>
        <p>Repeatability:
            <asp:Label ID="lblRepeatability" runat="server"></asp:Label>
          </p>
          <asp:Button ID="btnCatalogReturn" runat="server" BackColor="#33CCFF" OnClick="btnCatalogReturn_Click" Text="Return to Catalog" />
          <asp:Button ID="btnAddRoster" runat="server" BackColor="#33CCFF"  Text="Add to Schedule" OnClick="btnAddRoster_Click" />
      </div>
      <div class="col-md-4 mb-5">
        <h2>Pre-requisites:</h2>
        <hr>
        <div>
          &nbsp;<asp:Label ID="lblPreRequis" runat="server" Text=""></asp:Label>
          <br>
        </div>
        <address>
            &nbsp;</address>
      </div>
    </div>
    <!-- /.row -->
      <div id="feedback" style="text-align:center">
      <div class="row">
          <asp:Button ID="btnFeedback" runat="server" Text="Add Feedback" BackColor="#33CCFF" OnClick="btnFeedback_Click" />
          <asp:TextBox ID="txtFeedback" runat="server" Height="76px" Visible="False" Width="224px"></asp:TextBox>
          <asp:Button ID="btnSubmit" runat="server" BackColor="#33CCFF" OnClick="btnSubmit_Click" Text="Submit" Visible="False" />
          <br />
          </div>
    <div class="row">
      <div class="col-md-4 mb-5">
        <h2>Feedback</h2>
      </div>
      <div class="col-md-4 mb-5">
        
      </div>
      <div class="col-md-4 mb-5">
        
      </div>
    </div>
          </div>
    <!-- /.row -->

  </div>



            </div>
        </div>
    </form>
</body>
</html>
