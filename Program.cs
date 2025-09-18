static int ReadInt(string message, int min, int max) // function to validate int inputs
{
    Console.Write(message);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int value) && value >= min && value <= max) return value;
        Console.Write($"Invalid input. Enter a number between {min} and {max}: ");
    }
}
static double ReadDouble(string message) // function to validate double inputs
{
    while (true)
    {
        Console.Write(message);
        if (double.TryParse(Console.ReadLine(), out double value)) return value;
        Console.Write("Invalid number. Try again: ");
    }
}

while (true)
{
    Console.Clear();
    int SI;
    Console.WriteLine("Unit Converter");
    Console.WriteLine("==============");
    Console.WriteLine(@"1. length
2. weight
3. time
4. temperature");
    Console.Write(@"Select a measurement system (1-4): ");
    while (true)
    {
        string input = Console.ReadLine();
        if (int.TryParse(input, out SI) && SI >= 1 && SI <= 4) break; // repeat until valid input
        Console.Write("Invalid input. Enter a number between 1 and 4: ");
    }

    switch (SI)
    {
        case 1: //length
            var units = new Dictionary<int, (string Name, double toMeter)>
        {
            { 1, ("mm", 0.001)}, // millimeter to meter
            { 2, ("cm", 0.01) },  // centimeter to meter
            { 3, ("m", 1) },     // meter to meter
            { 4, ("km", 1000) }   // kilometer to meter
        };
            Console.WriteLine(@"==============
Length conversion. 
1. mm
2. cm
3. m
4. km");

            int convertFrom = ReadInt("Enter a unit to convert from (1-4): ", 1, 4);
            double value = ReadDouble("Enter value: ");
            int convertTo = ReadInt("Select a unit to convert to (1-4): ", 1, 4);

            double result = value * (units[convertFrom].toMeter / units[convertTo].toMeter); // convert value in meters then to target unit
            Console.WriteLine($"{value} {units[convertFrom].Name} = {result} {units[convertTo].Name}"); //display result, get unit names from dictionary

            int option = ReadInt("Enter 0 to exit or 1 to restart converter: ", 0, 1);
            if (option == 0) Environment.Exit(0);
            else if (option == 1) continue;
            break;
        case 2: //weight
            var weightUnits = new Dictionary<int, (string Name, double toKg)>
            {
                { 1, ("mg", 0.000001)}, // milligram to kilogram
                { 2, ("g", 0.001) },  // gram to kilogram
                { 3, ("kg", 1) },     // kilogram to kilogram
                { 4, ("t", 1000) }   // tonne to kilogram
            };













            break;
    }
}

