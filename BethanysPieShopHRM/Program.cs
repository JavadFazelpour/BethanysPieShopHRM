// See https://aka.ms/new-console-template for more information

using BethanysPieShopHRM.HR;

IEmployee bethany = new StoreManager("Bethany", "Smith", "bethanysmith@pomokelhause.de", new DateTime(1979, 1, 11), 27);

Console.WriteLine("How many hours do we need register for Bethany?");

int numberOfHours = 0;
string input = Console.ReadLine();
numberOfHours = int.Parse(input);

bethany.DisplayEmployeeDetails();
bethany.PerformWork();
bethany.PerformWork(numberOfHours);
