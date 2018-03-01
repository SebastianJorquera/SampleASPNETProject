<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SampleASPNETProject.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.css" rel="stylesheet" />

    <script src="Scripts/jquery-1.9.1.js"></script>
    <script src="Scripts/bootstrap.js"></script>
</head>
<body>
<div class="container">
    <form id="form1" runat="server">
        <div class="panel panel-success">
            <div class="panel-heading">
                <h2>ENTER REGISTRATION</h2>
            </div>
            
            <div class="panel-body">
                <div class="form-group">
                    <label>FirstName</label>
                    <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
    
                <div class="form-group">
                    <label>MiddleName</label>
                    <asp:TextBox ID="txtMiddleName" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
               
                <div class="form-group">
                    <label>LastName</label>
                    <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                
                 <div class="form-group">
                    <label>Adress</label>
                    <asp:TextBox ID="txtAdress" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                 <div class="form-group">
                    <label>Apt/Suit</label>
                    <asp:TextBox ID="txtAPT" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label>City</label>
                    <asp:TextBox ID="txtCity" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                 <div class="form-group">
                    <label>State</label>
                    <asp:TextBox ID="txtState" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label>Zip</label>
                    <asp:TextBox ID="txtZip" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group text-center">
                    <asp:Button ID="btnOK" runat="server" Text="OK" CssClass="btn btn-success" OnClick="btnOK_Click"/>
                </div>
             </div>

        </div>
    </form>
 
</div>
    <div id="divOutput" runat="server" class="form-control">

    </div>
</body>
</html>
