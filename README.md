# Umbraco_Homework
This project is made by Rasmus Jensen for Umbraco

## Database
The solution uses Entity Framework. 
The database will be instantiated when the program is run the first time. 
The location of the Tables can be seen in appsettings.json
If the database is deleted, it will be reinstantiated on the next run.

## Admin
To give a User Admin priviliges, you will need to make a few tweaks in the database.

1. Run the application.
2. Register a User.
3. Close application.
4. In Visual Studio, Go to View -> SQL Server Object Explorer.
5. Expand "Databases" -> Expand "Acme_Identity" -> Expand "Tables".
6. Right Click "dbo.AspNetRoles" and select "View Data".
7. Set Id and Name of the first row. Id = 1, Name = Admin.
8. Right Click "dbo.AspNetUsers" and select "View Data".
9. Copy the Id of the User you wish to give admin priviliges (You may need to expand the Id column to make it work).
10. Right Click "dbo.AspNetUserRoles" and select "View Data".
11. Paste the Id of the User into UserId AND set the RoleId = 1.
12. Save all changes.
13. Start the application and logout and login

Now the user should have Admin Priviliges :D
(If you are still having trouble try to expand the UserId column and check if the entire UserId is correct)

## Serialnumbers
The solution does not contain any pregenerated serialnumbers. 
The Admin can generate serialnumbers in the "Generator".
