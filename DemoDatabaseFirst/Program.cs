using DemoDatabaseFirst.Models;

namespace EFc.Se1621;
public class Program
{
    public static void Main()
    {
        //1.init Dbcontext
        FptEduStoreContext db = new FptEduStoreContext();
        //2.Load Data
        foreach(var p in db.Products)
        {
            Console.WriteLine($"Product Id : {p.ProductId}, Product Name: {p.ProductName}");
        }
        Console.ReadLine();
    }
}