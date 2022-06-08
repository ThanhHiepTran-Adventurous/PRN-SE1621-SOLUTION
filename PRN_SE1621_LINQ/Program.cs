using System.Linq;
using System;

string[] names = { "Dong", "Nguyen Van A", "Cong Phuong", "Park Hang SEo", "Luc", "Ha", "AnH Minh" };

/*1. Sap xep tang dan va in ra man hinh */

//Array.Sort(names);
/* 2. SortedSet */
/* 3. LinQ format 1 */
//var  namesAsc = names.OrderBy(n => n.Length);

/* lAY RA TAT CA CAC NAME MA LENGHT > 5 */
var namesLength = names.Where(n => n.Length > 5);

/* LinQ format 2 */

var namesLin = from n in names
               where n.Length > 5 && n.Contains("P")
               select n;

foreach (string name in namesLin)
{
    Console.WriteLine(name);
}