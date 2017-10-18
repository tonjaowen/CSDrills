<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_7.ChallengePostageCalculatorHelperMethod.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arimo;
        }
        .auto-style3 {
            font-family: Arimo;
            font-weight: normal;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 class="auto-style3">Postal Calculator</h2>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <span class="auto-style1">Width: </span>
            <asp:TextBox ID="WidthTextBox" runat="server" AutoPostBack="True" 
                CssClass="auto-style1" OnTextChanged="HandleChange"></asp:TextBox>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <span class="auto-style1">Height: </span>
            <asp:TextBox ID="HeightTextBox" runat="server" AutoPostBack="True" 
                CssClass="auto-style1" OnTextChanged="HandleChange"></asp:TextBox>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <span class="auto-style1">Length: </span>
            <asp:TextBox ID="LengthTexBox" runat="server" AutoPostBack="True" 
                CssClass="auto-style1" OnTextChanged="HandleChange"></asp:TextBox>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:RadioButton ID="GroundRadioButton" runat="server" AutoPostBack="True" 
                CssClass="auto-style1" GroupName="MethodGroup" OnCheckedChanged="handleChange" 
                Text="Ground" />
            <br class="auto-style1" />
            <asp:RadioButton ID="AirRadioButton" runat="server" AutoPostBack="True" 
                CssClass="auto-style1" GroupName="MethodGroup" OnCheckedChanged="HandleChange" 
                Text="Air" />
            <br class="auto-style1" />
            <asp:RadioButton ID="NextDayRadioButton" runat="server" AutoPostBack="True" 
                CssClass="auto-style1" GroupName="MethodGroup" OnCheckedChanged="handleChange" 
                Text="Next Day" />
            <br class="auto-style1" />
            <br class="auto-style1" />
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:Label ID="ResultLabel" runat="server" CssClass="auto-style1"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
