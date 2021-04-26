<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="OwlSpace.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap_css">
    <title>Hoot Hoot Admin Page</title>
    <link rel="stylesheet" href="~/Styling/AdminStyle.css" />
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>

    <style>
        body{

  margin-bottom: 100px;
  margin-right: 150px;
  margin-left: 80px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Breadcrumb -->
          <nav aria-label="breadcrumb" class="main-breadcrumb">
            <ol class="breadcrumb">
              <li class="breadcrumb-item active" aria-current="page">Admin Page</li>

            </ol>
              <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
          </nav>
          <!-- /Breadcrumb -->
            <div class="d-flex flex-column align-items-center text-center">
                    &nbsp;<div class="mt-3">
                      <h4>
                          <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
                        </h4>
                      <p class="text-secondary mb-1">Hoot Hoot Administrator</p>
                        <asp:Button ID="btnAdd" runat="server" Text="Add Course" OnClick="btnAdd_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                        <asp:Button ID="btnMod" runat="server" Text="Modify" OnClick="btnMod_Click" />
                        <br />
                    </div>
                  </div>
            <div id="courses">
                <br />
                <asp:GridView ID="gvCourses" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="9" GridLines="Horizontal" HorizontalAlign="Center" OnPageIndexChanged="gvCourses_PageIndexChanged" OnPageIndexChanging="gvCourses_PageIndexChanging" OnSelectedIndexChanged="gvCourses_SelectedIndexChanged">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:CheckBox ID="chkDelete" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Program" HeaderText="Program" />
                        <asp:BoundField DataField="CourseNumber" HeaderText="Course Number" />
                        <asp:BoundField DataField="Title" HeaderText="Title" />
                        <asp:BoundField DataField="CreditHours" HeaderText="Credit Hours" />
                        <asp:BoundField DataField="PreReq" HeaderText="Pre-Req" />
                        <asp:BoundField DataField="Repeatability" HeaderText="Repeatability" />
                        <asp:BoundField DataField="SemesterOffering" HeaderText="Semester" />
                        <asp:BoundField DataField="Description" HeaderText="Description" />
                    </Columns>
                </asp:GridView>
            </div>
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                <div id="addCourse">
                    <!-- 2 column grid layout with text inputs for the first and last names -->
                    <div class="row mb-4">
                        <div class="col">
                            <div class="form-outline">
                                <input type="text" id="form6Example1" class="form-control" name="program" />
                                <label class="form-label" for="form6Example1">
                                Course Program</label>
                            </div>
                        </div>
                        <div class="col">
                            <div class="form-outline">
                                <input type="text" id="form6Example2" class="form-control"name="hours" />
                                <label class="form-label" for="form6Example2">
                                Credit Hours</label>
                            </div>
                        </div>
                    </div>
                    <!-- Text input -->
                    <div class="form-outline mb-4">
                        <input type="text" id="form6Example3" class="form-control" name="title" />
                        <label class="form-label" for="form6Example3">
                        Course Title</label>
                    </div>
                    <!-- Text input -->
                    <div class="row mb-4">
                        <div class="col">
                            <div class="form-outline">
                        <input type="text" id="form6Example4" class="form-control" name="crn"/>
                        <label class="form-label" for="form6Example4">
                        Course Number</label>
                    </div>
                             </div>
                        <div class="col">
                            <div class="form-outline">
                                <label class="form-label" for="form6Example6">
                        Repeatability</label>
                                <br />
                                <asp:DropDownList ID="ddlRepeat" runat="server">
                                    <asp:ListItem Selected="True">Yes</asp:ListItem>
                                    <asp:ListItem>No</asp:ListItem>
                                </asp:DropDownList>
                            
                        
                    </div>
                             </div>
                         </div>
                    <!-- Email input -->
                    <div class="form-outline mb-4">
                        <input type="text" id="form6Example5" class="form-control" name="semester"/>
                        <label class="form-label" for="form6Example5">
                        Semester Offering</label>
                    </div>

<div class="form-outline mb-4">
    <asp:CheckBox ID="chkPreReq" runat="server" />
                        <input type="text" id="form6Example5" class="form-control" name="prereq"/>
                        <label class="form-label" for="form6Example5">
                        Pre-Requisites</label>
                    </div>
                        
    
                        
                    <!-- Message input -->
                    <div class="form-outline mb-4">
                        <textarea class="form-control" id="form6Example7" rows="4" cols="20" name="description"></textarea>
                        <label class="form-label" for="form6Example7">
                        Description</label>
                    </div>
                    
                    <!-- Submit button -->
                    <asp:Button ID="btnAddCourse" runat="server" Text="Add Course" BackColor="#66FFFF" OnClick="btnAddCourse_Click" />
                    <asp:Button ID="btnCancelAdd" runat="server" BackColor="#66FFFF" Text="Cancel" OnClick="btnCancelAdd_Click" />
                </div>
                </asp:Panel>
            <asp:Panel ID="pnlMod" runat="server" Visible="False">
                <div id="modCourse">
                    <!-- 2 column grid layout with text inputs for the first and last names -->
                    <div class="row mb-4">
                        <div class="col">
                            <div class="form-outline">
                                <input type="text" id="form6Example1" class="form-control" name="program" />
                                <label class="form-label" for="form6Example1">
                                Course Program</label>
                            </div>
                        </div>
                        <div class="col">
                            <div class="form-outline">
                                <input type="text" id="form6Example2" class="form-control"name="hours" />
                                <label class="form-label" for="form6Example2">
                                Credit Hours</label>
                            </div>
                        </div>
                    </div>
                    <!-- Text input -->
                    <div class="form-outline mb-4">
                        <input type="text" id="form6Example3" class="form-control" name="title" />
                        <label class="form-label" for="form6Example3">
                        Course Title</label>
                    </div>
                    <!-- Text input -->
                    <div class="row mb-4">
                        <div class="col">
                            <div class="form-outline">
                        <input type="text" id="form6Example4" class="form-control" name="crn"/>
                        <label class="form-label" for="form6Example4">
                        Course Number</label>
                    </div>
                             </div>
                        <div class="col">
                            <div class="form-outline">
                                <input type="text" id="form6Example6" class="form-control" name="repeat" />
                        <label class="form-label" for="form6Example6">
                        Repeatability</label>
                    </div>
                             </div>
                         </div>
                    <!-- Email input -->
                    <div class="form-outline mb-4">
                        <input type="text" id="form6Example5" class="form-control" name="semester"/>
                        <label class="form-label" for="form6Example5">
                        Semester Offering</label>
                    </div>

<div class="form-outline mb-4">
    <asp:CheckBox ID="CheckBox1" runat="server" />
                        <input type="text" id="form6Example5" class="form-control" name="prereq"/>
                        <label class="form-label" for="form6Example5">
                        Pre-Requisites</label>
                    </div>
                        
    
                        
                    <!-- Message input -->
                    <div class="form-outline mb-4">
                        <textarea class="form-control" id="form6Example7" rows="4" cols="20" name="description"></textarea>
                        <label class="form-label" for="form6Example7">
                        Description</label>
                    </div>
                    
                    <!-- Submit button -->
                    <asp:Button ID="btnModify" runat="server" Text="Modify Course" BackColor="#66FFFF" OnClick="btnModify_Click" />
                                        <asp:Button ID="btnCancelMod" runat="server" BackColor="#66FFFF" Text="Cancel" OnClick="btnCancelMod_Click" />

                </div>

            </asp:Panel>
        </div>
    </form>
</body>
</html>
