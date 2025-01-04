This code will show you how to establish connectivity between Snowflake and BizTalk when WCF-SQL adapter does not meet your requirement. Below are the steps to follow :
1.	Install and Configure Snowflake ODBC Driver
Obtain the Snowflake ODBC driver from the Snowflake documentation.
Install it on the BizTalk Server machine.
2.	Configure ODBC DSN:
Open the ODBC Data Source Administrator tool (32-bit or 64-bit based on your BizTalk version).
Add a new DSN for Snowflake.
Provide the required details:
DSN Name: A name to identify the connection.
Server: Snowflake server URL
Database: Default database to connect.
User: Snowflake username.
Password: Snowflake password.
Warehouse: Default warehouse for queries.
Test the connection.
3.	Configure BizTalk Server
Create a custom .NET component using the Snowflake Connector for .NET.
Install Snowflake Connector for .NET
Install the NuGet package: Install-Package Snowflake.Data
Develop .NET Component
Write a .NET class to handle Snowflake connections and queries.
Please find attached code.
Call the .NET Component in BizTalk:
Deploy the custom assembly.
Use a BizTalk orchestration or pipeline to call the component.
4. Test the Integration
Perform end-to-end testing of the data flow between BizTalk Server and Snowflake.
Check for connectivity, query execution, and data transformation.
