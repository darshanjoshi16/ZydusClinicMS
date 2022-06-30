<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Laboratorians.aspx.cs" Inherits="ClinicMS.Views.Admin.Laboratorians" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
 <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h2>Laboratorian's Details</h2>
                <form>
                    <div class="mb-3">
                        <label for="LabNameTb" class="form-label">Laboratorian's Name</label>
                        <input type="text" class="form-control" id="LabNameTb" runat="server">
                        
                    </div>
                     <div class="mb-3">
                        <label for="LabEmailTb" class="form-label">Email</label>
                        <input type="email" class="form-control" id="LabEmailTb" runat="server">
                        
                    </div>
                    <div class="mb-3">
                        <label for="LabPhoneTb" class="form-label">Contact</label>
                        <input type="text" class="form-control" id="LabPhoneTb" runat="server">
                        
                    </div>
                    <div class="mb-3">
                        <label for="GenderCb" class="form-label">Gender</label>
                        <input type="text" class="form-control" id="GenderCb" runat="server">

                        
                    </div>
                    <div class="mb-3">
                        <label for="DOBTb" class="form-label">Date of Birth</label>
                        <input type="date" class="form-control" id="DOBTb" runat="server">
                        
                    </div>
                    <div class="mb-3">
                        <label for="AddressTb" class="form-label">Address</label>
                        <input type="text" class="form-control" id="AddressTb" runat="server">
                        
                    </div>
                    <div class="mb-3">
                        <label for="PasswordTb" class="form-label">Password</label>
                        <input type="password" class="form-control" id="PasswordTb" runat="server">
                    </div>
                    
                   <label id="ErrMsg" runat="server" class="text-light"></label><br />
                    <asp:Button ID="AddBtn" runat="server" class="btn btn-success" Text="Add" OnClick ="AddBtn_Click" />
                    <asp:Button ID="EditBtn" runat="server" class="btn btn-warning" Text="Edit" OnClick="EditBtn_Click"  />
                    <asp:Button ID="DeleteBtn" runat="server" class="btn btn-danger" Text="Delete" OnClick ="DeleteBtn_Click"  />
                </form>
            </div>
            <div class="col-md-8">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/Lab.jpg" class="rounded-3 border-dark" height="400px" width="100%" size="cover"/>
                    </div>
                </div>
                <div class="row">
                    <h1>Laboratorians' Details</h1>
                    <asp:GridView ID="LabGV" class="table table-hover" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="LabGV_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775"></AlternatingRowStyle>

                        <EditRowStyle BackColor="#999999"></EditRowStyle>

                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></FooterStyle>

                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></HeaderStyle>

                        <PagerStyle HorizontalAlign="Center" BackColor="#284775" ForeColor="White"></PagerStyle>

                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333"></RowStyle>

                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

                        <SortedAscendingCellStyle BackColor="#E9E7E2"></SortedAscendingCellStyle>

                        <SortedAscendingHeaderStyle BackColor="#506C8C"></SortedAscendingHeaderStyle>

                        <SortedDescendingCellStyle BackColor="#FFFDF8"></SortedDescendingCellStyle>

                        <SortedDescendingHeaderStyle BackColor="#6F8DAE"></SortedDescendingHeaderStyle>
                    </asp:GridView>
                </div>
            </div>
        </div>
     </div>
</asp:Content>
