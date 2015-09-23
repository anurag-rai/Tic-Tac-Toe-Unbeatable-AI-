<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="names.aspx.cs" Inherits="test_cte_1.names" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Enter The Name</title>
    <link rel="stylesheet" type="text/css" href="trystyle.css">
</head>
<body>
    <div id="header">
        <h1>TAKE THE NAME</h1>
    </div>
    <form id="form1" runat="server">
    <div>
        <p style="text-align:center">
            Your Name Is:        <asp:Label ID="own_label" runat="server"></asp:Label>      
        </p>
        <br /><br />
        <p style="text-align:center">
            Fill in your Opponent's Name:
            <asp:TextBox ID="opp_textbox" runat="server"></asp:TextBox>
        </p> 
        <br /><br />
        <p style="text-align:center">
            <asp:Label ID="name_label" runat="server"></asp:Label>
        </p> 
        <br />
        <p style="text-align:center">
            <asp:Button ID="war_button" runat="server" OnClick="war_button_Click" Text="WAGE WAR!" />
        </p>
        
    </div>
    </form>
</body>
</html>
