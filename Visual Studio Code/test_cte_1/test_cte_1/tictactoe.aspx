<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tictactoe.aspx.cs" Inherits="test_cte_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BATTLE-GROUND</title>
    <link rel="stylesheet" type="text/css" href="trystyle.css">
</head>
<body>
    <div id="header">
        <h1>BATTLE-FIELD</h1>
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
            <asp:Label ID="move_label" runat="server"></asp:Label>
        </p>
        SCORE:
        <p>
            <asp:Label ID="score_label" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="restart" runat="server" Height="31px" OnClick="restart_Click" Text="Restart " Width="93px" />
        </p>
        <p>
            <asp:Button ID="home_button" runat="server" Height="23px" OnClick="home_button_Click" Text="Home" Width="91px" />
        </p>
    </div>
        
    </form>
</body>
</html>
