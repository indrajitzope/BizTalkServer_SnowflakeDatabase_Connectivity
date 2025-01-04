using Snowflake.Data.Client;
using System;

public class SnowflakeConnector
{
    public void ConnectToSnowflake()
    {
        string connectionString = "Host=<server>;User=<username>;Password=<password>;Database=<db>;Schema=<schema>;Warehouse=<warehouse>";
        using (SnowflakeDbConnection conn = new SnowflakeDbConnection())
        {
            conn.ConnectionString = connectionString;
            conn.Open();
            Console.WriteLine("Connected to Snowflake!");

            using (SnowflakeDbCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT CURRENT_TIMESTAMP;";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0));
                    }
                }
            }
        }
    }
}
