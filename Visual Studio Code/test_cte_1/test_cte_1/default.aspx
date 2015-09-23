<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="test_cte_1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> \mxm/</title>
    <link rel="stylesheet" type="text/css" href="trystyle.css">
</head>
<body>
    <div id="header">
        <h1>Hello! Welcome to the tic-tac-toe battleground!</h1>
     </div>

    <!-- The navigation bar on the left -->
    <div id="navbar">
        <ul>
		    <li><a href="about.html"> About </a></li>
            <br />
            <li><a href="features.html"> Main Features </a></li>
        </ul>		
	</div>
    <form id="form1" runat="server">
    
        <div>
           <br /> If you are a new user:<br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Make an Account" Width="155px" />
            <br />
            <br />
            <br />
            <br />
        </div>
        
        <div style="height: 182px">
            Already have an account?<br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Sign-In" Width="155px" />
        </div>
    </form>
</body>
</html>
