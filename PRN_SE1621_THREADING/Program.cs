namespace Prn.Threading;
public class Program
{
    public static void Main()
    {
        // 1. Gia sử mình có 1 lớp printer có 1 hàm là print số từ 1 - 5
        Printer p = new Printer();
        //p.PrintNumbers('a'); 
        //Console.WriteLine("============================");
        //p.PrintNumbers('b');
        //Console.WriteLine("============================");
        //p.PrintNumbers('c');

        Console.WriteLine();
        //2. Tạo ra 3 luồng to print the numbers from 1 to 5
        Thread t1 = new Thread(()=> p.PrintNumbers('a'));
        t1.Start();
        Thread t2 = new Thread(()=> p.PrintNumbers('b'));
        t2.Start();
        Thread t3 = new Thread(()=> p.PrintNumbers('c'));
        t3.Start();


        Thread[] arrThreads = new Thread[5];
        arrThreads[0] = new Thread(() => p.PrintNumbers('a'));
        arrThreads[1] = new Thread(() => p.PrintNumbers('b'));
        arrThreads[2] = new Thread(() => p.PrintNumbers('c'));
        arrThreads[3] = new Thread(() => p.PrintNumbers('d'));
        arrThreads[4] = new Thread(() => p.PrintNumbers('e'));

        for (int i = 0; i < 5; i++)
        {
            arrThreads[i].Start();
        }

    }
}