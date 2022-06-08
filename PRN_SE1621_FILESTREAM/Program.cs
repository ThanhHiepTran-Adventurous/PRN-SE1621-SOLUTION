
using System.IO;
using System.Text;
namespace Prn.FileStreamDemo;

public class Program
{
    public static void Main(string[] agrs)
    {
        //1. message ta muốn write vào file(FileStream)
        string msg = "ABCDEF";
        //2.convert msg => Array bytes
        byte[] bufferBytes = Encoding.Default.GetBytes(msg);
        //3. dùng FileStream to write to file by path
        using FileStream fileStream = File.Open
            ("data.dat",FileMode.Create);
        //4. execute insert data to file
        fileStream.Write(bufferBytes, 0, bufferBytes.Length);
        fileStream.Position = 0;
        //READ THE TYPESS FROM FILES AND DISPLAY TO CONSOLE
        Console.WriteLine("Print message as an array of bytes: \n");
        byte[] bytesFromFile = new byte[bufferBytes.Length];
        for (int i = 0; i < bufferBytes.Length; i++)
        {
            bytesFromFile[i] = (byte)fileStream.ReadByte();
            Console.Write($"{bytesFromFile[i],5}");
        }

        // display decoded messages
        Console.Write("\nDecoded Message: ");
        Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
        Console.ReadLine();
    }
}