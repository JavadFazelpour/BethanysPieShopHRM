// See https://aka.ms/new-console-template for more information
using BethanysPieShopHRM.HR;

List<IEmployee> employees = new List<IEmployee>();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("*********************************");
Console.WriteLine("*Bethany's Pie Shop Employee App*");
Console.WriteLine("*********************************");
Console.ForegroundColor = ConsoleColor.White;

string userSelection;
Console.ForegroundColor = ConsoleColor.Blue;

//Utilities.CheckForExistingEmployeeFile();

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Loaded {employees.Count} employee(s)\n\n");

    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine("********************");
    Console.WriteLine("* Select an Action *");
    Console.WriteLine("********************");

    Console.WriteLine("1: Register an employee");
    Console.WriteLine("2: View all employees");
    Console.WriteLine("3: Save Data");
    Console.WriteLine("4: Load Data");
    Console.WriteLine("9: Quit Application");

} while (true);