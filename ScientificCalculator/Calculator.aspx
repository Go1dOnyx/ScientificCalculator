<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="ScientificCalculator.Calculator" %>
  

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
    <style>
        .set {
        }
        .inputBox {
            margin-top: 20px;
        }
        .auto-style1 {
            font-size: x-large;
            margin-right: 5px;
        }
        .auto-style2 {}
    </style>
</head>
<body>
   <center>
    <form id="form1" runat="server">
        <div style="text-align: center">
        <asp:Label ID="Label1" runat="server" Text="Calculator" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <div class="container m-4 p-4">
            <center class="set" style="background-color:darkcyan; height: 538px; width: 480px;">
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="resultsText" runat="server" CssClass="auto-style2" Height="16px" ReadOnly="True" Width="233px"></asp:TextBox>
                <br />
                <asp:TextBox class="inputBox" ID="inputBox" runat="server" Height="52px" style="text-align: center" BorderStyle="Groove" Width="391px" readonly="True"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="oneBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="1" Width="63px" OnClick="oneBtn_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="twoBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" OnClick="Button2_Click" Text="2" Width="63px" />
                &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="threeBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="3" Width="63px" OnClick="threeBtn_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Button ID="backBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="&lt;" Width="63px" OnClick="Button4_Click" />
                <br />
                <br />
                <asp:Button ID="fourBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="4" Width="65px" OnClick="fourBtn_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="fiveBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="5" Width="63px" OnClick="fiveBtn_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="sixBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="6" Width="63px" OnClick="sixBtn_Click" />
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="divBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="÷" Width="63px" OnClick="divBtn_Click" />
                <br />
                <br />
                <asp:Button ID="sevenBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="7" Width="63px" OnClick="sevenBtn_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="eightBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="8" Width="63px" OnClick="eightBtn_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="nineBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="9" Width="63px" OnClick="nineBtn_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                <asp:Button ID="multiBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="x" Width="63px" OnClick="multiBtn_Click" />
                <br />
                <br />
                <asp:Button ID="posOrNegBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="±" Width="63px" OnClick="posOrNegBtn_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="zeroBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="0" Width="63px" OnClick="zeroBtn_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Button ID="decimalBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="." Width="63px" OnClick="decimalBtn_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="plusBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="+" Width="63px" OnClick="plusBtn_Click" />
                <br />
                <br />
                <asp:Button ID="xSqrBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="x²" Width="63px" OnClick="xSqrBtn_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="clearBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="C" Width="63px" OnClick="clearBtn_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                <asp:Button ID="equalBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="=" Width="63px" OnClick="equalBtn_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                <asp:Button ID="minusBtn" runat="server" CssClass="auto-style1" Font-Bold="True" Height="54px" Text="-" Width="63px" OnClick="minusBtn_Click" />
            </center>
        </div>
    </form>
  </center>
</body>
</html>