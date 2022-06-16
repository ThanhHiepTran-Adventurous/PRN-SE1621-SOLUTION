using System;
using System.IO;

using System.Data.Common;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Prn211.Se1621;

public class Program
{
    public static void Main()
    {
        IEnumerable<Product>? products = GetAllProduct(); 
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine(GetConnectionString());
        Console.ReadLine();
    }
    //Read content from the setting.json
    private static string GetConnectionString()
    {
        //có chức năng read file appsetting.json
        IConfiguration config = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json", true, true)
                                .Build();
        return config["ConnectionString:AppDatabasePrn211"];
    }
    public static List<Product>? GetAllProduct()
    {
        //0.VSQL
        string VSQL = "SELECT * FROM Products";
        List<Product> products;
        //1.init
        DbProviderFactory factory = SqlClientFactory.Instance;
        //2. init connection to database
        DbConnection conn = factory.CreateConnection();
        if(conn == null)
        {
            Console.WriteLine("Connection to fail....");
            return null;
        }
        conn.ConnectionString = GetConnectionString();
        conn.Open();
        //3. init command(SQL, Stored Procedure)
        using DbCommand? cmd = factory.CreateCommand();
        if(cmd == null)
        {
            Console.WriteLine("init connection fail(command).....");
            return null;
        }
        cmd.CommandText = VSQL;
        cmd.Connection = conn;
        //4.Excute command
        using DbDataReader reader = cmd.ExecuteReader();
        //5.Reader
        if (reader.HasRows)
        {
            products = new List<Product>();
            while (reader.Read())
            {
                //1.init a product
                Product p = new Product();
                p.Id = Convert.ToString(reader["ProductId"]);
                p.ProductName = (string)reader["ProductName"];
                p.CategoryId = Convert.ToString(reader["CategoryID"]);
                p.Price = Convert.ToDouble(reader["UnitPrice"]);

                products.Add(p);
            }
            return products;
        }
        return null;
    }
    
}