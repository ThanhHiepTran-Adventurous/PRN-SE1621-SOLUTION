namespace PRN.SE1621;

public class Employee
{
    private int id;
    private string name;

    public Employee()
    {
    }

    public Employee(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }

    public string Name { get => name; set => name = value; }
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public override string? ToString()
    {
        return base.ToString();
    }
}