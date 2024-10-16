

// შექმენით კონსოლური კალკულატორი რომელსაც მენიუ ექნება. კალკულატორი მანამდე უნდა მუშაობდეს
//სანამ მომხმარებელს არ მოუნდება მისი გათიშვა. 
//მაგ.:
//Calculator Menu:
//1) Addition
//2) Subtraction
//3) Multiplication
//4) Division
//5) Exit
//Choose an option: 1
//Enter first number: 10
//Enter second number: 5
//Result: 15
//[The menu repeats until the user selects Exit i am doing this cosole app can you help me with logics

while (true)
{

    Console.WriteLine("Calculator Menu:");
    Console.WriteLine("1) Addition");
    Console.WriteLine("2) Subtraction");
    Console.WriteLine("3) Multiplication");
    Console.WriteLine("4) Division");
    Console.WriteLine("5) Exit");
    Console.Write("Choose an option: ");

    string input = Console.ReadLine();



    if (input == "5")
    {
        Console.WriteLine("Calculator exited.");
        break;
    }

    if (input == "1" || input == "2" || input == "3" || input == "4")
    {
        Console.Write("Enter first number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (input)
        {
            case "1": // Addition
                result = firstNumber + secondNumber;
                break;
            case "2": // Subtraction
                result = firstNumber - secondNumber;
                break;
            case "3": // Multiplication
                result = firstNumber * secondNumber;
                break;
            case "4": // Division
                if (secondNumber == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    continue;
                }
                result = firstNumber / secondNumber;
                break;
        }

        Console.WriteLine("Result: " + result);
    }
    else
    {
        Console.WriteLine("Invalid option. Please enter a number between 1 and 5.");
    }

    Console.WriteLine();
}






