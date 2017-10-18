<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_6.ChallengeEpicSpiesPerformanceTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 150px;
            height: 164px;
        }
        .auto-style2 {
            font-family: "Agency FB";
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>
                <img alt="" class="auto-style1" src="epic-spies-logo.jpg" /><br />
                <br />
                <span class="auto-style2">Asset Performance Tracker</span></h2>
            <p>
                &nbsp;</p>
            <p>
                Asset Name:&nbsp;
                <asp:TextBox ID="AssetTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                &nbsp;</p>
            <p>
                Elections Rigged:&nbsp;
                <asp:TextBox ID="ElectionsTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                &nbsp;</p>
            <p>
                Acts of Subterfuge Performed:&nbsp;
                <asp:TextBox ID="ActsTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="AddButton" runat="server" OnClick="AddButton_Click" style="height: 26px" Text="Add Asset" />
            </p>
            <p>
                <asp:Label ID="ResultLabel" runat="server"></asp:Label>
            </p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
        </div>
    </form>
</body>
</html>
