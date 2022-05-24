namespace PRN.SE1621;

public class Program
{
    static void Main(string[] agrs)
    {
        Manager jack = new Manager(1000, "Jack Grealish", "Jack Grealish@gmail.com");
        Console.WriteLine(jack);
        Console.ReadLine();
    }
}