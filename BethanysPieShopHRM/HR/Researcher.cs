namespace BethanysPieShopHRM.HR;
internal class Researcher : Employee
{
    public Researcher(string firstName, string lastName, string email, DateTime birthdate, double? hourlyRate) : base(firstName, lastName, email, birthdate, hourlyRate)
    {
    }

    private int _numberOfPieTastesInvented = 0;

    public int NumberOfPieTastesInvented
    {
        get { return _numberOfPieTastesInvented; }
        private set { _numberOfPieTastesInvented = value; }
    }

    public void ResearchNewPieTastes(int researchHours)
    {
        NumberOfHoursWorked += researchHours;
        if(new Random().Next(100) > 50)
        {
            NumberOfPieTastesInvented++;
            Console.WriteLine($"Researcher {FirstName} {LastName} has invented a new pie taste! Total number of pies invented: {NumberOfPieTastesInvented}.");
        }
        else
        {
            Console.WriteLine( $"Researcher {FirstName} {LastName} is working still on a new pie taste!");
        }
    }

}
