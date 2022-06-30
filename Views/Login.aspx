<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ClinicMS.Views.Login" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Zydus Clinic</title>
    <link rel="stylesheet" href="../Assets/Libraries/BootStrap/css/bootstrap.min.css" />
    <link rel="stylesheet" href="../Assets/CSS/Login.css" />
</head>
<body style="background-image:url('https://wallpaperaccess.com/full/6890234.jpg'); background-size:cover">
    <div class="container-fluid">
        <div class="row" style="height:150px">
            
        </div>
        <div class="row">
            <div class="col-md-3">
                
            </div>
            <div class="col-md-5">
                <h1 class="text-light text-center p-lg-2 ">Zydus Clinic</h1>
                <form id="form1" runat="server">
                    <div class="mb-3">
                        <label for="EmailTb" class="form-label">Email address</label>
                        <input type="email" class="form-control" id="EmailTb" runat="server" required="required">
                        <div id="emailHelp" class="form-text text-light">We'll never share your email with anyone else.</div>
                    </div>
                    <div class="mb-3">
                        <label for="PasswordTb" class="form-label">Password</label>
                        <input type="password" class="form-control" id="PasswordTb" runat="server" required="required">
                    </div>
                    <div class="mb-3">
                        <label for="RoleCb" class="form-label">Role</label>
                        <asp:DropDownList ID="RoleCb" runat="server" class="form-control">
                            <asp:ListItem>---Select Role---</asp:ListItem>
                            <asp:ListItem>Admin</asp:ListItem>
                            <asp:ListItem>Doctor</asp:ListItem>
                            <asp:ListItem>Receptionist</asp:ListItem>
                            <asp:ListItem>Laboratorian</asp:ListItem>
                        </asp:DropDownList>


                    </div>
                    <div class="d-grid">
                        <label id="ErrMsg" class="text-light" runat="server"></label><br />
                        <asp:Button ID="LoginBtn" runat="server" class="btn btn-primary btn-block" Text="Login" OnClick="Button1_Click" />
                    </div>
                   
                </form>
            </div>
            <div class="col-md-3"></div>
        </div>
    </div>
    
</body>
</html>
