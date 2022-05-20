 namespace PRN.SE1621;
using static System.Console;
public class Program
{
    public static void Main(string[] agrs)
    {
        /*1. Create a Employee object */
        Employee e = new Employee { Salary = 1253d, Name ="Hiep", Id= 01};

        //Thằng này truyền thông qua get
        
        //Truyền dữ liệu thông qua constructor có tham số
        Employee b = new Employee(1,"Tran Van Tung", 1524d);
        WriteLine(b.Name);
        WriteLine(e);
        ReadLine();
    }
}