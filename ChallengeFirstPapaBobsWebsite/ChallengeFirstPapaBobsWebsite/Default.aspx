<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeFirstPapaBobsWebsite.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 200px;
            height: 200px;
        }
        .auto-style2 {
            font-family: "Bodoni MT";
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <img alt="PapaBob" class="auto-style1" src="PapaBob.png" /><br />
            <br />
            <br />
            <h1 class="auto-style2">Papa Bob&#39;s Pizza and Software</h1>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:RadioButton ID="BabyRadioButton" runat="server" GroupName="SizeGroup" Text="Baby Bob Size (10&quot;)-$10" ValidationGroup="SizeGroup" />
            <br />
            <asp:RadioButton ID="MamaRadioButton" runat="server" GroupName="SizeGroup" Text="Mama Bob Size (13&quot;)-$13" />
            <br />
            <asp:RadioButton ID="PapaRadioButton" runat="server" GroupName="SizeGroup" Text="Papa Bob Size (16&quot;)-$16" />
            <br />
            <br />
            <br />
            <br />
            <asp:RadioButton ID="ThinRadioButton" runat="server" GroupName="CrustGroup" Text="Thin Crust" />
            <br />
            <asp:RadioButton ID="DeepRadioButton" runat="server" GroupName="CrustGroup" Text="Deep Dish (+$2)" />
            <br />
            <br />
            <br />
            <asp:CheckBox ID="PepperoniCheckBox" runat="server" Text="Pepperoni (+$1.50)" />
            <br />
            <asp:CheckBox ID="OnionsCheckBox" runat="server" Text="Onions (+$0.75)" />
            <br />
            <asp:CheckBox ID="GreenPeppersCheckBox" runat="server" OnCheckedChanged="CheckBox3_CheckedChanged" Text="Green Peppers (+$0.75)" />
            <br />
            <asp:CheckBox ID="RedPeppersCheckBox" runat="server" Text="Red Peppers (+$0.75)" />
            <br />
            <asp:CheckBox ID="AnchoviesCheckBox" runat="server" Text="Anchovies (+$2)" />
            <br />
&nbsp;<br />
            <br />
            Papa Bob&#39;s Special Deal<br />
            <br />
            Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza.<br />
            <br />
            <asp:Button ID="PurchaseButton" runat="server" OnClick="PurchaseButton_Click" Text="Place Order" />
            <br />
            <br />
            Total:&nbsp; <asp:Label ID="TotalLabel" runat="server" Text="$0.00"></asp:Label>
        </div>
    </form>
</body>
</html>
