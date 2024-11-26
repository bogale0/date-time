Console.WriteLine($"DateOnly.Parse(): {DateOnly.Parse("2024-11-26")}");
Console.WriteLine($"TimeOnly.ParseExact(): {TimeOnly.ParseExact("16.00", "HH.mm")}");
TimeOnly time;
if (TimeOnly.TryParse("8:30", out time))
    Console.WriteLine($"TimeOnly.TryParse(): {time}");
DateOnly date;
if (DateOnly.TryParseExact("26-11-2024", "dd-MM-yyyy", out date))
    Console.WriteLine($"DateOnly.TryParseExact(): {date}");