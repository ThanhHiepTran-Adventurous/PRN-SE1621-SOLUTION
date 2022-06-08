using System.Collections;
using System.Collections.Generic;
using Prn.Se1621;
IList<Employee> list = new List<Employee>(); // da hinh
list.Add(new Employee(1,"Dong",15224.5d));
list.Add(new Employee(2, "Nguyen Quang Hai", 15224.5d));
list.Add(new Employee(3, "Nguyen Cong Phuong", 15224.5d));
list.Add(new Employee(4, "Park Hang Seo", 15224.5d));
list.Add(new Employee(5, "Ma Van Meo", 15224.5d));
list.Add(new Employee(6, "Tran Van Cao", 15224.5d));


Console.WriteLine($"Number of Employee in List: { list.Count}");

foreach (Employee e in list)
{
    Console.WriteLine(e);
}

/* sortedSet */

SortedSet<Employee> set = new SortedSet<Employee>();
set.Add(new Employee(1, "Dong", 15224.5d));
set.Add(new Employee(9, "Dong", 15224.5d));
set.Add(new Employee(3, "Dong", 15224.5d));
set.Add(new Employee(1, "Dong", 15224.5d));
set.Add(new Employee(8, "Dong", 15224.5d));

Console.WriteLine("============================================");
foreach (Employee e in set)
{
    Console.WriteLine(e);
}