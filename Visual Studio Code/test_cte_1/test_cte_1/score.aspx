<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="score.aspx.cs" Inherits="test_cte_1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SCORE</title>
    <link rel="stylesheet" type="text/css" href="trystyle.css">
</head>
<body>
    <div id="header">
        <h1>THE HOLY NUMBER</h1>
    </div>
    <form id="form1" runat="server">
    <div>
        <p style="text-align:center">
            YOUR SCORE IS
            <asp:Label ID="score_label" runat="server"></asp:Label>
        </p>
        <p style="text-align:center">
            <asp:Button ID="reset_score" runat="server" OnClick="reset_score_Click" Text="Reset Score" />
        </p>
        <p style="text-align:center">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-top: 34px" Text="Main Page" />
        </p>
    </div>
    </form>
</body>
</html>
