namespace PRN.SE1621;

public class Address
{
    public int No { get; set; }

    public string Street { get; set; }
    public string Ward { get; set; }

    public string Distric { get; set; }

    public string City { get; set; }

    public Address()
    {

    }

    public Address(int no, string street, string ward, string distric, string city)
    {
        No = no;
        Street = street;
        Ward = ward;
        Distric = distric;
        City = city;
    }

    public override string? ToString()
    {
        return $"No = {No}, Street = {Street}, Ward = {Ward}, Distric = " +
            $"{Distric}, City = {City}";
    }
}