<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Laboratorian/LabMaster.Master" AutoEventWireup="true" CodeBehind="LabTest.aspx.cs" Inherits="ClinicMS.Views.Laboratorian.LabTest" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">

    <div class="container-fluid">
        <div class="row" style="height:50px"></div>
        <div class="row">
            <div class="col-md-4">
                <h2>Laboratory Test Details</h2>
                <form>
                    <div class="mb-3">
                        <label for="LabTestNameTb" class="form-label">Test Name</label>
                        <input type="text" class="form-control" id="LabTestNameTb" runat="server">
                        
                    </div>
                     <div class="mb-3">
                        <label for="LabTestCostTb" class="form-label">Test Cost</label>
                        <input type="text" class="form-control" id="LabTestCostTb" runat="server">
                        
                    </div>

                    <div class="row" style="height:100px"></div>
                   
                   <label id="ErrMsg" runat="server" class="text-danger"></label><br />
                    <asp:Button ID="AddBtn" runat="server" class="btn btn-success" Text="Add" OnClick="AddBtn_Click" />
                    <asp:Button ID="EditBtn" runat="server" class="btn btn-warning" Text="Edit" OnClick="EditBtn_Click" />
                    <asp:Button ID="DeleteBtn" runat="server" class="btn btn-danger" Text="Delete" OnClick="DeleteBtn_Click" />
                </form>
            </div>
            <div class="col-md-8">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/Lab.jpg" class="rounded-3 border-dark" height="400px" width="100%" size="cover"/>
                    </div>
                </div>
                <div class="row" style="height:20px"></div>
                <div class="row">
                    <h1>Laboratory Test Details</h1>
                    <asp:GridView ID="LabTestGV" class="table" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="LabTestGV_SelectedIndexChanged">
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
