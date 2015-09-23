<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="war.aspx.cs" Inherits="test_cte_1.war" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>A WAR IS COMING</title>
    <link rel="stylesheet" type="text/css" href="trystyle.css">
</head>
<body>
    <div id="header">
        <h1>
            CHOOSE
        </h1>
    </div>
    <form id="form1" runat="server">
    <div id ="homely">
        Play against another human player:<br />
        <p>
            <asp:Button ID="human_button" runat="server" Text="HUMAN" OnClick="human_button_Click" />
        </p>
        Play against the unbeatable computer:<br />
        <p>
            <asp:Button ID="comp_button" runat="server" Text="COMPUTER" OnClick="comp_button_Click" />
        </p>

        Run away from war:
        <p>
            <asp:Button ID="run_button" runat="server" Text="RUN" OnClick="run_button_Click" />
        </p>
    </div>
    </form>
</body>
</html>
