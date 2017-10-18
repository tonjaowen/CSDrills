<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_5.ChallengeEpicSpiesNewAssignmentForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 190px;
            height: 229px;
        }
        .auto-style2 {
            font-family: "Agency FB";
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img class="auto-style1" src="epic-spies-logo.jpg" /></div>
        <h2 class="auto-style2">Spy New Assignment Form</h2>
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style2">
            Spy Code Name:&nbsp;
            <asp:TextBox ID="CodeNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style2">
            New Assignment Name:&nbsp;
            <asp:TextBox ID="NewAssignTextBox" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style2">
            End Date of Previous Assignment</p>
        <p class="auto-style2">
            <asp:Calendar ID="PreviousCalendar" runat="server"></asp:Calendar>
        </p>
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style2">
            Start Date of New Assignment</p>
        <p class="auto-style2">
            <asp:Calendar ID="NewCalendar" runat="server"></asp:Calendar>
        </p>
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style2">
            Projected End Date of New Assignment</p>
        <p class="auto-style2">
            <asp:Calendar ID="EndCalendar" runat="server"></asp:Calendar>
        </p>
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style2">
            <asp:Button ID="AssignButton" runat="server" OnClick="AssignButton_Click" Text="Assign Spy" />
&nbsp;</p>
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style2">
            <asp:Label ID="ResultLabel" runat="server"></asp:Label>
        </p>
        <p class="auto-style2">
            &nbsp;</p>
        <p class="auto-style2">
            &nbsp;</p>
    </form>
</body>
</html>
