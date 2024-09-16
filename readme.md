Handling the caching_sha2_password authentication plugin in MySQL 8 can be a bit tricky,
especially if you’re encountering compatibility issues with certain clients or connectors.
Here are a few ways to manage it:

1. Change the Authentication Plugin for a User
If you need to change the authentication plugin for a specific user to 
mysql_native_password, you can do so with the following SQL command:

ALTER USER 'root'@'localhost' IDENTIFIED WITH mysql_native_password BY 'PAss12#$';

2. Change the Default Authentication Plugin
To change the default authentication plugin for the entire MySQL server, you can modify the MySQL
configuration file (my.cnf or my.ini):

[mysqld]
default_authentication_plugin=mysql_native_password

After making this change, restart the MySQL server.

3. Use Secure Connections
The caching_sha2_password plugin requires either a secure connection or an RSA key pair for 
password exchange. Ensure that your connection is secure by using SSL/TLS:

string connectionString = "Server=localhost;Port=3306;Database=mydatabase;User=myuser;
Password=mypassword;SslMode=Required;";
MySqlConnection connection = new MySqlConnection(connectionString);

4. Update Your MySQL Connector
Ensure that you are using the latest version of the MySQL connector for your programming language,
as newer versions are more likely to support caching_sha2_password.

string connectionString = "Server=localhost;Port=3306;Database=mydatabase;User=myuser;
	Password=mypassword;SslMode=Required;";
MySqlConnection connection = new MySqlConnection(connectionString);

#######################################

Create another user with sha2 and test applcation for both modes.

CREATE USER 'root19'@'localhost' IDENTIFIED WITH caching_sha2_password BY 'PAss12#$';

GRANT ALL PRIVILEGES ON *.* TO 'root19'@'localhost';
