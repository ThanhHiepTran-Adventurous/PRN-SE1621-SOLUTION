namespace Prn.Se1621;
//Lop truu tuong giup ta khai bao 1 mang tinh de luu tap cac Products

public abstract class AbsProduct
{
    public Product[] Products { get; set; }
    public int Size { set;get } // cho biet so luong phan tu co that

    public AbsProduct()
    {
        Products = new Product[Utils.InitNumberProduct];
        Size = 0;
    }

}
