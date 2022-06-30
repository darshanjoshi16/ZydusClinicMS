<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Doctors/DoctorMaster.Master" AutoEventWireup="true" CodeBehind="Prescription.aspx.cs" Inherits="ClinicMS.Views.Doctors.Prescription" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h2 class="text-center">Prescription Details</h2>
                <form>
                    <div class="mb-3">
                        <label for="PatientCb" class="form-label">Patient</label>
                        <asp:DropDownList ID="PatientCb" runat="server" class="form-control"></asp:DropDownList>
                        
                    </div>
                    <div class="mb-3">
                        <label for="MedicinesTb" class="form-label">Medicines</label>
                        <input type="text" class="form-control" id="MedicinesTb" runat="server">
                        
                    </div>
                    <div class="mb-3">
                        <label for="TestCb" class="form-label">Lab Test </label>
                        <asp:DropDownList ID="TestCb" runat="server" class="form-control"></asp:DropDownList>
                        
                    </div>
                    <div class="mb-3">
                        <label for="CostTb" class="form-label">Total Cost</label>
                        <input type="text" class="form-control" id="CostTb" runat="server">
                        
                    </div>
                   <div class="d-grid">
                        <label id="ErrMsg" runat="server" class="text-danger"></label><br />
                       <asp:Button ID="AddBtn" runat="server" class="btn btn-success btn-block" Text="Save Prescription" OnClick="AddBtn_Click" />
                   </div>       
                </form>
            </div>
            <div class="col-md-8">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/medicines.jpg" class="rounded-3 border-dark" width="100%" height="350px" />
                    </div>
                </div>
                <div class="row">
                    <h1 class="text-center">Prescriptions</h1>
                    <asp:GridView ID="PreGV" class="table" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None">
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
</asp:Content>
