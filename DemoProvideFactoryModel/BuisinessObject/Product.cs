using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prn.Se1621;

public class Product
{
    public int Id { get; set; }
    public string? ProductName { get; set; }

    public string? CategoryId { get; set; }

    public double? Price { get; set; }

    public Product()
    {
    }

    public Product(int id, string? productName, string? categoryId, double? price)
    {
        Id = id;
        ProductName = productName;
        CategoryId = categoryId;
        Price = price;
    }

    public override string? ToString() => $"[Product ID: {Id}], " +
        $"Product Name: {ProductName}, Category: {CategoryId} and Price: {Price}";
}