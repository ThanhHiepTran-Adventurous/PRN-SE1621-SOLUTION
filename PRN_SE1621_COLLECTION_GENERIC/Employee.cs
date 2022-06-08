namespace Prn.Se1621;

public class Employee : IComparable<Employee>   
{
    public int Id { get; set; }

    public string Name { get; set; }

    public double Salary { get; set; }

    public Employee()
    {
    }

    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    public override string? ToString()
    {
        return $"[Id = {Id}, Name = {Name} and Salaary = {Salary}]";
    }

    public override bool Equals(object? obj)
    {
        // Ta logic the nao la bang nhau
        if(obj == null) return false;

        Employee? other = obj as Employee; // casting
        return this.Id == other.Id;
    }

    public int CompareTo(Employee? other)
    {
        return (int)(this.Salary + other.Salary);
    }
}
