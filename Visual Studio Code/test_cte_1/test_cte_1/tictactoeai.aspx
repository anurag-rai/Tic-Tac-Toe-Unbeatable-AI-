<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tictactoeai.aspx.cs" Inherits="test_cte_1.tictactoeai" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UNWINNABLE</title>
    <link rel="stylesheet" type="text/css" href="trystyle.css">
</head>
<body>
    <div id="header">
        <h1>BATTLE AGAINST THE UNBEATABLE</h1>
    </div>
    <br /><br />
    <form id="form1" runat="server">
    <div id="homely">
    
        <asp:Button ID="Button1" runat="server" Height="77px" OnClick="Button1_Click" Width="77px" />
        <asp:Button ID="Button2" runat="server" Height="77px" OnClick="Button2_Click" Width="77px" />
        <asp:Button ID="Button3" runat="server" Height="77px" OnClick="Button3_Click" Width="77px" />
        <br />
        <asp:Button ID="Button4" runat="server" Height="77px" OnClick="Button4_Click" Width="77px" />
        <asp:Button ID="Button5" runat="server" Height="77px" OnClick="Button5_Click" Width="77px" />
        <asp:Button ID="Button6" runat="server" Height="77px" OnClick="Button6_Click" Width="77px" />
        <br />
        <asp:Button ID="Button7" runat="server" Height="77px" OnClick="Button7_Click" Width="77px" />
        <asp:Button ID="Button8" runat="server" Height="77px" OnClick="Button8_Click" Width="77px" />
        <asp:Button ID="Button9" runat="server" Height="77px" OnClick="Button9_Click" Width="77px" />
        <br />
        <br />
        </div>
        <div id="homely">
            <p>
                <asp:Button ID="restart_button" runat="server" OnClick="restart_button_Click" Text="RESTART" />
            </p>
            <p>
                <asp:Label ID="winner_label" runat="server"></asp:Label>
            </p>

        SCORE:<br />
            <p>
                <asp:Label ID="check_label_1" runat="server"></asp:Label>
            </p>
            <p>
                &nbsp;<asp:Button ID="home_button" runat="server" OnClick="HOME_Click" Text="HOME" />
            </p>
        </div>
        
    
    
        
    </form>
</body>
</html>
