<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: "Bookman Old Style";
            font-size: large;
        }
        .auto-style2 {
            font-family: "Bookman Old Style";
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <span class="auto-style1">Simple Calculator</span><br />
        <br />
        <span class="auto-style2">First Value</span>&nbsp;
        <asp:TextBox ID="FirstTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <span class="auto-style2">Second Value</span>&nbsp;
        <asp:TextBox ID="SecondTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="AddButton" runat="server" OnClick="AddButton_Click" Text="+" />
&nbsp;
        <asp:Button ID="SubButton" runat="server" OnClick="SubButton_Click" Text="-" />
&nbsp;
        <asp:Button ID="MultButton" runat="server" OnClick="MultButton_Click" style="height: 26px" Text="*" />
&nbsp;
        <asp:Button ID="DiviButton" runat="server" OnClick="DiviButton_Click1" Text="/" />
&nbsp;
        <br />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server" BackColor="#66FF33" BorderColor="Black" BorderStyle="None"></asp:Label>
    </form>
</body>
</html>
