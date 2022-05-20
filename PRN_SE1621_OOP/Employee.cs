namespace PRN.SE1621;
public class Employee
{
    /*
     * Fields
     */
    private int _id;
    private string _name;

    /* 
       Properties/Attributes
     */
    //init-only properties
    public double Salary { get; init; } // .NET CORE
    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }

    // CONSTRUCTOR
    // mục tiêu của nó là khởi tạo dữ liệu và chuyển giá trị vào cho các thuộc tính
    //mục tiêu yêu cầu hdh cấp cho nó 1 vùng nhớ và set data cho nó
    public Employee()
    {

    }

    public Employee(int id, string name, double salary)
    {
        Salary = salary;
        Id = id;
        Name = name;
    }
    //display to consle
    public override string? ToString()
    {
        return $"[Id = {this._id}, Name = {Name}, Salary = {Salary}]";
    }


}
