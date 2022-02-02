double num1 = 0; double num2 = 0;

Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

Console.WriteLine("Type a number, and then press Enter");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Type another, and then press Enter");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Choeose an option from the following lint:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.WriteLine("Your option? ");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        while (num2 == 0)
        {
            Console.WriteLine("Enter a non-zero divisor: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
}

Console.Write("Press any key to close the Calculator console app...");
Console.ReadLine();

