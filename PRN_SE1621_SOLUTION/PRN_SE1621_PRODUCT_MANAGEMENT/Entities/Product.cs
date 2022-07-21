namespace Prn.Se1621;
public class Product
{
    //fields/data
    // fields dùng để chứa dữ liệu
    private int _id;
    private string _productName;

    /* properties*/
   
    // => mũi tên như vậy là Expression-Bodied
    //Biểu thức dạng thân
    public int Id { get => _id; set => _id = value; }
    public string ProductName { get => _productName; set => _productName = value; }

    public string Desc { get; set; } // .Net 5

    public double UnitPrice { get; set; }
    public DateTime StartDate { get; set; }
    /* Constructor */
    public  Product()
    {

    }

    public Product(int id, string productName, string desc, double unitPrice, DateTime startDate)
    {
        Id = id;
        ProductName = productName;
        Desc = desc;
        UnitPrice = unitPrice;
        StartDate = startDate;
    }


    //overide ToString => hien thi tat ca ra man hinh
    public override string? ToString() => NewMethod();
    
    private string NewMethod()
    {
        return $"[Id = {Id}, Product Name = {ProductName}, Desc = {Desc}, Unit Price = {UnitPrice}, Start Date = {StartDate}]";
    }




}