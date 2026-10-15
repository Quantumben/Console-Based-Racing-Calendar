using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Racing Calendar 1.0!");
        Console.WriteLine();

        // PART I: Create racing calendar
        List<Race> racingCalendar = new List<Race>();

        Race race1 = new Race(
            "British Grand Prix",
            new DateTime(2027, 6, 15),
            "Silverstone Circuit"
        );

        Race race2 = new Race(
            "Monaco Grand Prix",
            new DateTime(2027, 7, 20),
            "Circuit de Monaco"
        );

        Race race3 = new Race(
            "Italian Grand Prix",
            new DateTime(2027, 9, 10),
            "Monza Circuit"
        );

        racingCalendar.Add(race1);
        racingCalendar.Add(race2);
        racingCalendar.Add(race3);

        // Print racing calendar
        Console.WriteLine("RACING CALENDAR");

        foreach (Race race in racingCalendar)
        {
            race.PrintInfo();
        }

        Console.WriteLine();

        // PART II: Create and register drivers
        Driver driver1 = new Driver("John");
        Driver driver2 = new Driver("Mary");

        if (race1.AddDriver(driver1))
        {
            Console.WriteLine(driver1.Name + " successfully registered!");
        }

        if (race1.AddDriver(driver2))
        {
            Console.WriteLine(driver2.Name + " successfully registered!");
        }

        Console.WriteLine();

        // PART III: Create driver waiting list
        Stack<Driver> waitingList = new Stack<Driver>();

        waitingList.Push(new Driver("James"));
        waitingList.Push(new Driver("Sarah"));
        waitingList.Push(new Driver("David"));

        // Take the next driver
        if (waitingList.Count > 0)
        {
            Driver nextDriver = waitingList.Pop();

            Console.WriteLine(
                "Next driver from waiting list: " +
                nextDriver.Name
            );
        }
    }
}