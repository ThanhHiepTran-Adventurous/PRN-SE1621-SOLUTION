namespace Prn.Threading;
using static System.Console;
public class Printer
{
    public void PrintNumbers(char c)
    {
        for (int i = 0; i <= 5; i++)
        {
            WriteLine($"Print character:{c} - {i}");
            Thread.Sleep(1000);
        }
    }
}