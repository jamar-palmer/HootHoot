<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="HootHoot.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap_css">
    <title>Hoot Hoot Account Page</title>
    <link rel="stylesheet" href="~/Styling/HomeStyle.css" />
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
    <div class="main-body">
    
          <!-- Breadcrumb -->
          <nav aria-label="breadcrumb" class="main-breadcrumb">
              
            <ol class="breadcrumb">
              <li class="breadcrumb-item active" aria-current="page">>User Profile</li>
            </ol>
          </nav>
          <!-- /Breadcrumb -->
        <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="Logout" />
        <div class="row">
    <div class="col-md-6 mb-6 d-flex flex-column ">
              <asp:Button ID="Button1" runat="server" Text="View Courses" OnClick="Button1_Click" BackColor="#990033" ForeColor="White" />
        </div>
        <div class="col-md-6 mb-6 d-flex flex-column ">
              <asp:Button ID="Button2" runat="server" Text="Plan Registration" OnClick="Button2_Click" BackColor="#990033" ForeColor="White" />
              <br />
              
              <br />
            </div>
                  
            </div>
          <div class="row gutters-sm">
              
            <div class="col-md-4 mb-3">
              <div class="card">
                <div class="card-body">
                  <div class="d-flex flex-column align-items-center text-center">
                      <asp:Image ID="Image1" runat="server" Height="70px" Width="70px" />
&nbsp;<div class="mt-3">
                      <h4>
                          <asp:Label ID="lblFullName" runat="server"></asp:Label>
                          </h4>
                      <p class="text-secondary mb-1">
                          <asp:Label ID="lblMajor" runat="server"></asp:Label>
                          </p>
                    </div>
                  </div>
                </div>
              </div>
              
            </div>
            <div class="col-md-8">
              <div class="card mb-3">
                <div class="card-body">
                  <div class="row">
                    <div class="col-sm-3">
                      <h6 class="mb-0">Full Name</h6>
                    </div>
                    <div class="col-sm-9 text-secondary">
                        <asp:Label ID="lblName2" runat="server"></asp:Label>
                    </div>
                  </div>
                  <hr>
                  <div class="row">
                    <div class="col-sm-3">
                      <h6 class="mb-0">Email</h6>
                    </div>
                    <div class="col-sm-9 text-secondary">
                        <asp:Label ID="lblEmail" runat="server"></asp:Label>
                    </div>
                  </div>
                  <hr>
                  <div class="row">
                    <div class="col-sm-3">
                      <h6 class="mb-0">Phone</h6>
                    </div>
                    <div class="col-sm-9 text-secondary">
                        Total Credits:
                        <asp:Label ID="lblCredits" runat="server"></asp:Label>
                    </div>
                  </div>
                </div>
              </div>
              <div class="row gutters-sm">
                <div class="col-sm-6 mb-3" id="currentSemester" runat="server">

                </div>
                <div class="col-sm-6 mb-3">
                  
                </div>
              </div>
            </div>
          </div>
        </div>
    </div>
    </form>
</body>
</html>
