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
    private static string GetConnectionString()
    {
        //
        IConfiguration config = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json",true,true)
                                .Build();
        return config["ConnectionString:AppDatabasePrn211"];
    }

    public static List<Product> GetAllProducts()
    {
        //0. VSQL
        string VSQL = "SELECT * FROM Products";
        List<Product> products;
        //1.init Provider
        DbProviderFactory factory = SqlClientFactory.Instance;
        //2.init connection to database
        DbConnection conn = factory.CreateConnection();
        if(conn == null)
        {
            Console.WriteLine("Connection to faill........");
            return null;
        }
        conn.ConnectionString = GetConnectionString();
        conn.Open();

        //3. init Command(SQL, Stored Procedure)
        using DbCommand? cmd = factory.CreateCommand();
        if(cmd == null)
        {
            Console.WriteLine("init conneciton Fail(command)...");
            return null;
        }
        cmd.CommandText = VSQL;
        cmd.Connection = conn;
        //4.Execute Command
        using DbDataReader reader = cmd.ExecuteReader();
        //5.reader
        if (reader.HasRows)
        {
            products = new List<Product>();
            while (reader.Read())
            {
                //1.init product
                Product p = new Product();
                p.Id = (int)reader["ProductId"];
                p.ProductName = (string)reader["ProductName"];
                p.CategoryID = (int)reader["CategoryId"];
                p.Price = Convert.ToDouble(reader["UnitPrice"]);
                //2.Add to list Product
                products.Add(p);
            }
            return products;
        }
        return null;
    }

} 