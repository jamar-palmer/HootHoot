<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="OwlSpace.AdminPage" %>

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
            <div class="d-flex flex-column align-items-center text-center">
                    <img src="https://bootdey.com/img/Content/avatar/avatar7.png" alt="Admin" class="rounded-circle" width="150">
                    <div class="mt-3">
                      <h4>John Doe</h4>
                      <p class="text-secondary mb-1">Full Stack Developer</p>
                      <p class="text-muted font-size-sm">Bay Area, San Francisco, CA</p>
                      <button class="btn btn-primary">Follow</button>
                      <button class="btn btn-outline-primary">Message</button>
                    </div>
                  </div>

            <div id="addCourse">
                <asp:TextBox ID="txtTitle" runat="server" placeholder="Title"></asp:TextBox>
                <asp:TextBox ID="txtProgram" runat="server" placeholder="Program"></asp:TextBox>
                <asp:TextBox ID="txtCourseNum" runat="server" placeholder="Number"></asp:TextBox>
                <asp:TextBox ID="txtPreReq" runat="server" placeholder="Pre req"></asp:TextBox>
                <asp:TextBox ID="txtSemester" runat="server" placeholder="semester offering"></asp:TextBox>
                <asp:TextBox ID="txtRepeatability" runat="server" placeholder="repeatability"></asp:TextBox>
                <asp:TextBox ID="txtHours" runat="server" placeholder="hours"></asp:TextBox>
                <asp:TextBox ID="txtDescription" runat="server" placeholder="description"></asp:TextBox>
            </div>
        </div>
    </form>
</body>
</html>
