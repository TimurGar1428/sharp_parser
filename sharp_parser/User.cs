namespace sharp_parser;

public class User
{
    public int id { get; set; }
    public string name { get; set; }
    private Address address { get; set; }

}

public class Address
{
    public string city { get; set; }
    public string street { get; set; }
    public int building { get; set; }
}