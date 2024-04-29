namespace BethanysPieShopHRM.HR;
internal class Developer : Employee
{
	private string _currentProject;

	public string CurrentProject
	{
		get { return _currentProject; }
		set { _currentProject = value; }
	}

	public Developer(string firstName, string lastName, string email, DateTime birthdate, double? hourlyRate) : base(firstName, lastName, email, birthdate, hourlyRate)
    {
    }
}
