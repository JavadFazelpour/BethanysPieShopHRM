namespace BethanysPieShopHRM.HR;
public class Employee : IEmployee
{
    private string _firstName;
    private string _lastName;
    private string _email;

    private int _numberOfHoursWorked;
    private double _wage;
    private double? _hourlyRate;

    private DateTime _birthDay;

    private Address _address;
    public Address Address { get { return _address; } set { _address = value; } }

    private const int _minimalHoursWorked = 1;

    private static double _taxRate = 0.15;

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public int NumberOfHoursWorked
    {
        get { return _numberOfHoursWorked; }
        protected set { _numberOfHoursWorked = value; }
    }

    public double? HourlyRate
    {
        get => _hourlyRate;
        set
        {
            if (value < 0)
                _hourlyRate = 0;
            else
                _hourlyRate = value;
        }
    }
    public DateTime BirthDay { get => _birthDay; set => _birthDay = value; }

    public static int MinimalHoursWorked => _minimalHoursWorked;

    public static double TaxRate { get => _taxRate; set => _taxRate = value; }
    public double Wage { get => _wage; private set => _wage = value; }
    public Employee(string firstName, string lastName, string email, DateTime birthdate) : this(firstName, lastName, email, birthdate, 0)
    {

    }
    public Employee(string firstName, string lastName, string email, DateTime birthdate, double? hourlyRate)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        BirthDay = birthdate;
        HourlyRate = hourlyRate ?? 10;
    }

    public Employee(string firstName, string lastName, string email, DateTime birthdate, double? hourlyRate, string street, string houseNumber, string zip, string city)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        BirthDay = birthdate;
        HourlyRate = hourlyRate ?? 10;
        Address = new Address(street, houseNumber, zip, city);
    }

    public void PerformWork()
    {
        PerformWork(MinimalHoursWorked);
    }
    public void PerformWork(int numberOfHours)
    {
        NumberOfHoursWorked += numberOfHours;
        Console.WriteLine($"{FirstName} {LastName} has worked for {numberOfHours} hour(s).");
    }

    public int CalculateBonus(int bonus)
    {
        if (NumberOfHoursWorked > 10)
            bonus *= 2;
        Console.WriteLine($"The employee got a bonus of {bonus}");

        return bonus;
    }

    //public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
    //{
    //    if (numberOfHoursWorked > 10)
    //        bonus *= 2;
    //    if (bonus >= 200)
    //    {
    //        bonusTax = bonus / 10;
    //        bonus -= bonusTax;
    //    }
    //    Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");

    //    return bonus;
    //}

    public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
    {
        bonusTax = 0;
        if (NumberOfHoursWorked > 10)
            bonus *= 2;
        if (bonus >= 200)
        {
            bonusTax = bonus / 10;
            bonus -= bonusTax;
        }
        Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");

        return bonus;
    }

    public virtual void GiveBonus()
    {
        Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 100!");
    }
    public double ReceiveWage(bool resetHours = true)
    {
        double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;
        double taxAmount = wageBeforeTax * TaxRate;
        Wage = wageBeforeTax - taxAmount;

        Console.WriteLine($"{FirstName} {LastName} has received a wage of {Wage} for {NumberOfHoursWorked} hour(s) of work");
        if (resetHours)
            NumberOfHoursWorked = 0;

        return Wage;
    }
    public static void DisplayTaxRate() { Console.WriteLine($"Tax rate is {TaxRate}"); }
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"\nFirst name: \t{FirstName}\nLast name: \t{LastName}\nEmail: \t\t{Email}\nBirthday: \t{BirthDay.ToShortDateString()}\nTax rate: \t{TaxRate}");
    }

    public void GiveCompliment()
    {
        Console.WriteLine($"You've done a great job, {FirstName}");
    }
}
