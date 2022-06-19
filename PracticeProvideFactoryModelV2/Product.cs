using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prn.Se1621;

public class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; }
    
    public int CategoryID { get; set; }

    public double Price { get; set; }

    public Product()
    {
    }

    public Product(int id, string productName, int categoryID, double price)
    {
        Id = id;
        ProductName = productName;
        CategoryID = categoryID;
        Price = price;
    }

    public override string? ToString() => $"[Product ID: {Id}], " +
        $"[Product Name:{ProductName}, Category ID: {CategoryID} and Price: {Price}]";
   
}
