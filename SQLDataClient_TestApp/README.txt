To reproduce the issue create a new Database on an SQL-Server.
Copy the lines from CreateTable.txt and execute as new query on the created database.
Copy the lines from CreateStoredProc.txt and execute as new query on the created database.
Don't forget to set the connection string in program.cs.
Issue is cause in the database.cs in line 37 (also marked with a comment).