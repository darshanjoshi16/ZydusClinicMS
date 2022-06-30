<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Receptionist.aspx.cs" Inherits="ClinicMS.Views.Admin.Receptionist" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h2>Receptionist's Details</h2>
                <form>
                    <div class="mb-3">
                        <label for="RecNameTb" class="form-label" >Receptionist's Name</label>
                        <input type="text" class="form-control" id="RecNameTb"  runat="server">
                        
                    </div>
                     <div class="mb-3">
                        <label for="RecEmailTb" class="form-label" >Email</label>
                        <input type="email" class="form-control" id="RecEmailTb"  runat="server">
                        
                    </div>
                    <div class="mb-3">
                        <label for="RecPhoneTb" class="form-label" >Contact</label>
                        <input type="text" class="form-control" id="RecPhoneTb"  runat="server">
                        
                    </div>
                    <div class="mb-3">
                        <label for="GenderCb" class="form-label" >Gender</label>
                        <input type="text" class="form-control" id="GenderCb"  runat="server">
                        
                    </div>
                    <div class="mb-3">
                        <label for="DOBTb" class="form-label"  >Date of Birth</label>
                        <input type="date" class="form-control" id="DOBTb"  runat="server">
                        
                    </div>
                    <div class="mb-3">
                        <label for="AddressTb" class="form-label"  >Address</label>
                        <input type="text" class="form-control" id="AddressTb"  runat="server">
                        
                    </div>
                    <div class="mb-3">
                        <label for="PasswordTb" class="form-label"  >Password</label>
                        <input type="password" class="form-control" id="PasswordTb"  runat="server">
                    </div>

                    <label id="ErrMsg" runat="server" class="text-danger"></label><br />
                    <asp:Button ID="AddBtn" runat="server" Text="Add" class="btn btn-success" OnClick="AddBtn_Click" />
                    <asp:Button ID="EditBtn" runat="server" Text="Edit" class="btn btn-warning" OnClick="EditBtn_Click" />
                    <asp:Button ID="DeleteBtn" runat="server" Text="Delete" class="btn btn-danger" OnClick="DeleteBtn_Click" />
                                         
                </form>
            </div>
            <div class="col-md-8">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/reception.jpg" class="rounded-3 border-dark" height="250px" width="100%" size="cover"/>
                    </div>
                </div>
                <div class="row">
                    <h1>Receptionists' Details</h1>
                    <asp:GridView ID="RecGV" class="table table-hover" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="RecGV_SelectedIndexChanged">
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
</asp:Content>
