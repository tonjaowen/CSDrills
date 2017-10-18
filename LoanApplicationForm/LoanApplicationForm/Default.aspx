<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LoanApplicationForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Loan Application Form<br />
            <br />
            Name:&nbsp;
            <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Phone Number&nbsp; <asp:TextBox ID="PhoneNumberTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Social Security Number:&nbsp; <asp:TextBox ID="SsnTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Loan Origination Date:<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            <br />
            Salary:&nbsp;
            <asp:TextBox ID="SalaryBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Submit" />
            <br />
            <br />
            <br />
            <asp:Label ID="ResultLabel" runat="server"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
