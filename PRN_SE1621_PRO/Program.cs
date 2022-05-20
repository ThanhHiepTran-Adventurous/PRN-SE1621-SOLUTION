//namespace FptEdu.prn1621;
namespace City.District.Ward.Street;//domain
public class Program
{
   public static void Main(string[] args) 
    {
        Console.WriteLine($"=================================");
        Program obj = new Program();
        int a = 10, b = 20;//argruments
        var salary = 10.5;//goi toi APIs(xml/json)
       // salary = "chungtra";
        string c = "30";
        int age = int.Parse(c);
        Console.WriteLine(age);
        dynamic fullName = 10;
        fullName = "a";       


        Console.WriteLine(fullName);
        Console.WriteLine(salary.GetType());
       // Console.WriteLine("Total of a = {0} and b = {1} is : {2}", a, b,Sum(a,b));
        Console.WriteLine($"Total of a = {a} and b = {b} is:{Sum(a, b)}"); //String Interpolation
        
        Console.ReadLine();
    }
    //manual methods: paramters
    /*
       multi-lines
     */
    public static int Sum(int x, int y)
    {
        return x + y;
    }
}