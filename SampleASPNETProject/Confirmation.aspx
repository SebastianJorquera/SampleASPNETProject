<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confirmation.aspx.cs" Inherits="SampleASPNETProject.Confirmation" %>

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
        <div class="panel panel-info">
            <div class="panel-heading">
                <h2>Registration Confirmation</h2>
            </div>
            
            <div class="panel-body">
                <div class="form-group">
                    <label>FirstName</label>
                    <asp:Label ID="lblFirstName" runat="server" CssClass="form-control"></asp:Label>
                </div>

                <div class="form-group">
                    <label>MiddleName</label>
                    <asp:Label ID="lblMiddleName" runat="server" CssClass="form-control"></asp:Label>
                </div>
                <div class="form-group">
                    <label>LastName</label>
                    <asp:Label ID="lblLastName" runat="server" CssClass="form-control"></asp:Label>
                </div>

                

                 <div class="form-group">
                    <label>Adress</label>
                    <asp:Label ID="lblAdress" runat="server" CssClass="form-control"></asp:Label>
                </div>

                 <div class="form-group">
                    <label>Apt/Suit</label>
                    <asp:Label ID="lblAPT" runat="server" CssClass="form-control"></asp:Label>
                </div>

                <div class="form-group">
                    <label>City</label>
                    <asp:Label ID="lblCity" runat="server" CssClass="form-control"></asp:Label>
                </div>

                 <div class="form-group">
                    <label>State</label>
                    <asp:Label ID="lblState" runat="server" CssClass="form-control"></asp:Label>
                </div>

                <div class="form-group">
                    <label>Zip</label>
                    <asp:Label ID="lblZip" runat="server" CssClass="form-control"></asp:Label>
                </div>

                <div class="form btn-group text-center">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>

                    <asp:Button ID="btnBack" runat="server" Text="Back"  OnClick="btnBack_Click"/>
                </div>
             </div>

        </div>
    </form>
 
</div>
    <div id="divOutput" runat="server" class="form-control">

    </div>
</body>
</html>


