﻿
using Microsoft.Data.SqlClient;


const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=Th144289@#$;Trusted_Connection=False; TrustServerCertificate=True;"; ;


using ( var connection = new SqlConnection( connectionString ) )
{
    Console.WriteLine("conectado");
    connection.Open();

    using ( var command = new SqlCommand())
    {
       
        command.Connection = connection;
        command.CommandType = System.Data.CommandType.Text;
        command.CommandText = "SELECT [Id], [Title] FROM [Category]";

        var reader = command.ExecuteReader();

        while( reader.Read())
        {
            Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
        }
    }


}


Console.WriteLine("Hello, World!");