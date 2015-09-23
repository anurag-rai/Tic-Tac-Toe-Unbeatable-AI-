<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="test_cte_1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tic-Tac-Toe HOME</title>
    <link rel="stylesheet" type="text/css" href="trystyle.css">
</head>
<body>
    <form id="form1" runat="server">
    <div id="header">
        <h1>
            BATTLE-GROUND
        </h1>
    </div>
        <br /><br />
    <div id="homely">
        See battle stats:
        <p>
            <asp:Button ID="score" runat="server" OnClick="score_Click" Text="Stats" />
        </p>
    </div>
        <br /><br />
    <div id="homely">
        Wage a battle:
        <p>
            <asp:Button ID="battle" runat="server" OnClick="battle_Click" Text="WAR!" />
        </p>
    </div>
        <br /><br />
    <div id="homely">
        Rules:
        <p>
            <asp:Button ID="rules" runat="server" OnClick="rules_Click" Text="RULES" />
        </p>
     </div>
     <div>
         If you've had enough blood:
         <p>
             <asp:Button ID="logout_button" runat="server" OnClick="logout_button_Click" Text="Log-Out" />
         </p>
         
     </div>        
            
    </form>
</body>
</html>
