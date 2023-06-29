<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="WebApplication13.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 67px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <center>
        <asp:Label ID="Label10" runat="server" Text="Enrollment Number"></asp:Label>

        <br />
            <asp:TextBox ID="TBenrol" runat="server"></asp:TextBox>
            <br />
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>

        <div>
            <asp:TextBox ID="TBname" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>

        <div>
            <asp:TextBox ID="TBemail" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Label ID="Label3" runat="server" Text="Mobile Number"></asp:Label>

        <div>
            <asp:TextBox ID="TBnumber" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Blood Group"></asp:Label>
        </div>
            <asp:TextBox ID="TBblood" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Fees"></asp:Label>
        <br />
        <asp:TextBox ID="TBfees" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label11" runat="server" Text="Percentage"></asp:Label>
        <br />
        <asp:TextBox ID="TBpercentage" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>

        <div>
            <asp:TextBox ID="TBpassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
        <asp:Label ID="Label7" runat="server" Text="Confirm Password"></asp:Label>

        <div>
            <asp:TextBox ID="TBconfirm" runat="server" TextMode="Password"></asp:TextBox>
            <br />
        <asp:Label ID="Label8" runat="server" Text="Address"></asp:Label>

        <div>
            <asp:TextBox ID="TBaddress" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="Label9" runat="server" Text="Pincode"></asp:Label>

        <div class="auto-style1">
            <asp:TextBox ID="TBpincode" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="BTNsubmit" runat="server" Text="Submit" OnClick="BTNsubmit_Click" />
            <br />
            <br />
            <asp:Label ID="error" runat="server" ForeColor="Red"></asp:Label>
            <br />
        </div>
        </div>
        </div>
        <br />
        <asp:RegularExpressionValidator ID="RegexName" runat="server" ErrorMessage="Name Should contain only Alphabats" ControlToValidate="TBname" ValidationExpression="/^[a-z ,.'-]+$/i" SetFocusOnError="True"></asp:RegularExpressionValidator>
        <br />
        <asp:RegularExpressionValidator ID="RegexNumber" runat="server" ErrorMessage="Mobile Number Should contain only 10 numbers" ControlToValidate="TBnumber" ValidationExpression="(?&lt;!\d)\d{10}(?!\d)"></asp:RegularExpressionValidator>
        <br />
        <asp:RegularExpressionValidator ID="RegexEmail" runat="server" ErrorMessage="Invalid Email Address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="Tbemail"></asp:RegularExpressionValidator>
        <br />
        <asp:RegularExpressionValidator ID="RegexFees" runat="server" ErrorMessage="There Should be only 2 Decimal PLaces" ValidationExpression="^[0-9]*\.[0-9]{2}$ or ^[0-9]*\.[0-9][0-9]$" ControlToValidate="TBfees"></asp:RegularExpressionValidator>
        <br />
        <asp:RegularExpressionValidator ID="RegexPincode" runat="server" ErrorMessage="Invalid Pincode" ValidationExpression="(?&lt;!\d)\d{6}(?!\d)" ControlToValidate="TBpincode"></asp:RegularExpressionValidator>
        </center>
    </form>
</body>
</html>
