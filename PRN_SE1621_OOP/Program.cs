 namespace PRN.SE1621;

using System.Collections;
using static System.Console;
public class Program
{
    public static void Main(string[] agrs)
    {



        /*1. Create a Employee object */
        /*
         Employee e = new Employee { Salary = 1253d, Name ="Hiep", Id= 01};
       
         Employee b = new Employee(1,"Tran Van Tung", 1524d);
         WriteLine(b.Name);
         WriteLine(e);
         */
        /*2.Define a collection Employees */
        ArrayList lstEmps= new ArrayList();


        lstEmps.Add(new Employee(1,"Bui Huu Dong", 15.35, new DateOnly(2000,9,2),new Address(493,"CMT8","Phuong 13", "Quan 10", "HCMC")));
        lstEmps.Add(new Employee(2, "An", 15.35));
        lstEmps.Add(new Employee(1, "Hue", 15.35));
        lstEmps.Add(new Employee(1, "Lan", 15.35));
        lstEmps.Add("MA Van Meo");
        //display
        Display(lstEmps);
        Employee e = new Employee { Salary = 1253d, Name = "Hiep", Id = 01 };
        
        ReadLine();
    }
    private static void Display(ArrayList lstData)
    {
        /*
          foreach (Employee e in lstData)
        {
            WriteLine(e);
        }
         */
        for(int i = 0; i < lstData.Count; i++)
        {
            Console.WriteLine(lstData[i]);
        }
    }
}