using System;
using System.Collections.Generic;

class Race
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Track { get; set; }

    private List<Driver> drivers;

    public Race(string name, DateTime date, string track)
    {
        Name = name;
        Date = date;
        Track = track;

        drivers = new List<Driver>();
    }

    // Register a driver if space is available
    public bool AddDriver(Driver driver)
    {
        if (drivers.Count < 20)
        {
            drivers.Add(driver);
            return true;
        }

        return false;
    }

    // Print all information about the race
    public void PrintInfo()
    {
        Console.WriteLine(
            Name + " | " +
            Date.ToString("dd/MM/yyyy") + " | " +
            Track
        );
    }
}
