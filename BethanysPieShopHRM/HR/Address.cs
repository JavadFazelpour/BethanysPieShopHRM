namespace BethanysPieShopHRM.HR;
public class Address
{
    private string _street;
    private string _houseNumber;
    private string _zipCode;

    public string ZipCode
    {
        get { return _zipCode; }
        set { _zipCode = value; }
    }
    private string _city;

    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    public string HouseNumber
    {
        get { return _houseNumber; }
        set { _houseNumber = value; }
    }


    public string Street
    {
        get { return _street; }
        set { _street = value; }
    }

    public Address(string street, string houseNumber, string zipCode, string city)
    {
        Street = street;
        HouseNumber = houseNumber;
        ZipCode = zipCode;
        City = city;
    }
}
