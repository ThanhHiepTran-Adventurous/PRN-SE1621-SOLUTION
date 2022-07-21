
namespace Prn.Se1621;
public class ProductManagement : AbsProduct, IProduct
{

    public ProductManagement()
    {

    }
    public void Add(Product p)
    {
        //1. check for length
        if(Size >= this.Products.Length)
        {
            Product[] temp = new Product[this.Products.Length * 2];
            for(int i = 0; i < this.Products.Length; i++)
            {
                temp[i] = this.Products[i];
            }
            this.Products = temp;
        }
        this.Products[Size] = p;
        Size++; 
    }

    public bool Delete(Product p)
    {
        int index = 0;
        foreach(Product item in this.Products)
        {
            index++;
            if(item is not null && item.Id == p.Id)
            {
                for (int i = index; i < this.Products.Length - 1; i++)
                {
                    this.Products[i] = this.Products[i + 1];
                }
                this.Products[this.Products.Length - 1] = null;
                return true;
            }
        }
        return false;
    }

    public void Display()
    {
        foreach(Product p in this.Products)
        {
            Console.WriteLine(p);
        }
    }

    public Product Get(Product p)
    {
        throw new NotImplementedException();
    }

    public Product[] GetAllProductByUnitPrice(double price)
    {
        throw new NotImplementedException();
    }

    public void Update(Product p)
    {
        throw new NotImplementedException();
    }
}
