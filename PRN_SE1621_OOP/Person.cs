namespace PRN.SE1621;


/* 
  base(superclass/parent class)
  derived(subclass/childclass)
 */
public class Person
{
    public String Name { get; set; }
    public DateOnly Dob { get; set; }

    public Address Address { get; set; } // Has-A

    public Person()
    {

    }

    public Person(string name, DateOnly dob, Address address)
    {
        Name = name;
        Dob = dob;
        Address = address;
    }

    public override string? ToString()
    {
        return $"[Name= {Name} , Dob = {Dob}, Address = {Address}]";
    }
}