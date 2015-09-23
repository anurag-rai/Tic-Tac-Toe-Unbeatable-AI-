

PROJECT SUBMITTED UNDER CTE - C#
********************************

MAIN FEATURES: (for a better view please load features.html in a browser)

1. Pages are made with a combination of ASP.NET pages, HTML and CSS as front-end,C# as back-end and ASP.NET as framework.
2. The user data is stored using SQL Tables by sending queries. Each user will have a unique username.
3. Passwords are encrypted as MD5 hashes.
4. Cookie is created with every login and is deleted when the user logs out.
5. Sending game/score url links to some-else has been disabled by using cookies.
6. Created a perfect Tic-tac-toe AI using methods derived from the Min-Max algorithm.
7. Sounds/Audio effects have been associated with some button features and game-play.


**********************************

Files present are:

1. Project Demo (Please enable audio to listen to the sound effects)
2. Project snapshots that show various pages.
3. C# project files (test_cte_1).
4. SQL Database Back-up file (test.bak) which needs to be imported into the sql server.


************************************
HOWEVER, I'M NOT SURE IF THE CODE WILL WORK AS THE CONNECTION STRING IN THE C# CODE WILL ALSO HAVE TO CHANGE WHEN THE DATABASE LOCATION CHANGES
[[ current connection String: Data Source=Lazy;Initial Catalog=test;Integrated Security=True ]]
************************************


I have attached the SQL Database by following the instructions from http://stackoverflow.com/questions/18866321/how-to-copy-sql-server-2008-r2-database-from-one-machine-to-another

There is already an account with username:cte and password:test in the database


*************************************

[*] Visual Studio Project (test_cte_1)

	cte_tictactoe as a Visual C# Porject file

	FILES:

		1.  about.html
		2.  algo.html 
		3.  default.aspx
		4.  features.html
		5.  home.aspx
		6.  names.aspx
		7.  rules.html
		8.  score.aspx
		9.  signin.aspx
		10. signup.aspx
		11. tictactoe.aspx
		12. tictactoeai.aspx
		13. trystyle.css
		14. war.aspx

	RESOURCES:

		1. beep.wav
		2. loss.wav
		3. move.wav
		4. win.wav

	IMAGES:

		1. ttt_rules.jpg


**************************************


[*] SQL

Back-up file name: test.bak

----------------------------------------

Data-base name: test

Table-name: logininfo

Table has columns: "username"(string), "pass"(string), "email"(string), "score"(int)
Their default initialization values are "MAX".

Codewise:

* Create a database name "test"

use test

create table logininfo
(
username varchar(MAX),
pass varchar(MAX),
email varchar(MAX),
score int
);


------------------------------------

****************************************

CONTACT:

ANURAG RAI [2013A7PS693G]
7775954697

********************************************
