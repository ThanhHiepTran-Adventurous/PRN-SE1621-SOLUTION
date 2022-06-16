using System;
using System.IO;

using System.Data.Common;//ADO.NET
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient; // Provider
using System.Data;

namespace Prn.Se1621;
public class Program
{
    public static void Main()
    {
        IEnumerable<Product>? products = GetAllProducts();
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

    public static List<Product> GetAllProducts()
    {
        //0.VSQL
        string VSQL = "SELECT * FROM Products";
        List<Product> products;
        //1. init provider
        DbProviderFactory factoty = SqlClientFactory.Instance;//Singleton

        //2. init connection to database
        DbConnection conn = factoty.CreateConnection();
        if(conn == null)
        {
            Console.WriteLine("init connection fail....");
            return null;
        }
        conn.ConnectionString = GetConnectionString();
        conn.Open();
        //3. init command(SQL, Stored Procedure)
        using DbCommand? cmd = factoty.CreateCommand();
        if (cmd == null)
        {
            Console.WriteLine("init connection fail(command)....");
            return null;
        }
        cmd.CommandText = VSQL;
        cmd.Connection = conn;
        //4.Execute command
        using DbDataReader reader = cmd.ExecuteReader();
        //5. Reader
        if(reader.HasRows)
        {
            products = new List<Product>();
            while(reader.Read()){
                 //1. init a product
                 Product p = new Product();
                p.Id = (int)reader["ProductId"];
                p.ProductName = (string)reader["ProductName"];
                p.CategoryId = Convert.ToString(reader["CategoryId"]);
                p.Price = Convert.ToDouble(reader["UnitPrice"]);
                //2.add to list product
                products.Add(p);
            }
            return products;
        }
        return null;
    }
}