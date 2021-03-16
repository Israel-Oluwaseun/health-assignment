// program to test out the class


using System;

class HealthProfileTest
{
    public static void Main(string[] args)
    {
        HealthProfile hpo1 = new HealthProfile(null, null, 0, 0, 0, 0, 0, null);

        Console.Write("Enter First Name: ");
        hpo1.FirstName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter Last Name: ");
        hpo1.LastName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter Day of Birth: ");
        hpo1.DayOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Month of Birth: ");
        hpo1.MonthOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Year of Birth: ");
        hpo1.YearOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Weight in pounds: ");
        hpo1.WeightInPounds = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Height in inches: ");
        hpo1.HeightInInches = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Gender: ");
        hpo1.Gender = Convert.ToString(Console.ReadLine());

        
        
        hpo1.DisplayFirstName();
        hpo1.DisplayLastName();
        hpo1.DisplayDayOfBirth();
        hpo1.DisplayMonthOfBirth();
        hpo1.DisplayYearOfBirth();
        hpo1.DisplayWeightInPounds();
        hpo1.DisplayHeightInInches();
        hpo1.DisplayGender();
        hpo1.DisplayYearsOfAgeSimple();
        hpo1.DisplayMaxHeartRate();
        hpo1.DisplayTargetHeartRate();
        hpo1.DisplayBodyMassIndex();
        hpo1.DisplayBMIOutput();
        hpo1.DisplayBMIChart();        
    }
}