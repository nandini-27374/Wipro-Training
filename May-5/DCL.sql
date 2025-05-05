WHAT IS DCL?

DCL (Data Control Language) is a subset of SQL used to control access to data in a database.

Core DCL Commands:

i. Create user: Creates a user at the database level.

Syntax:
 	CREATE USER [user name] FOR LOGIN [loginname];
Example:
	create login JohnLogin with password='StrongPass';
	create user Johndoe for login johnlogin;

ii. Drop user: Removes a userfrom the database.

Syntax:
	DROP USER [user_name];
Example:
	Drop user Johndoe;

iii. Grant: Grants permissions to user or roles to perform actions like SELECT,INSERT,EXECUTE.

Syntax:
	GRANT permission_type ON object to user_or_role;
Example:
	GRANT SELECT ON dbo.Customers to Johndoe;
	GRANT SELECT ON dbo.GetCustomerDetails to Johndoe;

iv.Revoke: Revokes previously granted permissions-removes the grant.

Syntax:
	Revoke permission_type on object from user_or_role;
Example:
	Revoke select on dbo.Customers from johndoe;

