namespace PRN.SE1621;
public class Employee : Person
{
    /*
     * Fields
     */
    private int _id;
    

    /* 
       Properties/Attributes
     */
    //init-only properties
    public double Salary { get; init; } // .NET CORE
    public int Id { get => _id; set => _id = value; }

    public string Level { get; set; } //"Senior, Leader"
    // Auto-properties
    public string NameOfCompany { get; } = "FPT Education";

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

    public Employee(int id,string name, double salary, DateOnly dob, Address address) : base(name,dob,address)
    {

        Salary = salary;
        Id = id;
       
    }
    //display to consle
    //Overrding
    public override string? ToString()
    {
        return $"[Id = {this._id}, Name = {Name}, Salary = {Salary}, Dob = " +
            $"{Dob}, Address = {Address}]";
    }

    //manual methods here
    public double GetSalaryByLevel()
    {
        if(this.Level == "Senior")
        {
            return this.Salary * 0.1;
        }
        else
        {
            return this.Salary;
        }
    }
    //Overloading(quá tải - cùng tên hàm nhưng khác nhau số lượng tham số or kiểu dữ liệu của tham số)
    public double GetSalaryByLevel(double commitment)
    {
        return this.GetSalaryByLevel() + commitment;
    }
}
