// See https://aka.ms/new-console-template for more information
double firstNumber;
double secondNumber;
Console.WriteLine("Please enter first number:");
string firstNumber1 = Console.ReadLine();
double.TryParse(firstNumber1, out firstNumber);
Console.WriteLine("Please enter second number:");
string secondNumber1 = Console.ReadLine();
double.TryParse(secondNumber1, out secondNumber);
char option = '0';
Console.WriteLine("Enter your calculation option:");
string option1 = Console.ReadLine();
char.TryParse(option1, out option);
Console.WriteLine($"{firstNumber} {option} {secondNumber}");

switch (option)
{
    case '+':
        Console.WriteLine(firstNumber + secondNumber);
        break;
    case '-':
        Console.WriteLine(firstNumber - secondNumber);
        break;
    case '*':
        Console.WriteLine(firstNumber * secondNumber);
        break;
    case '/':
        Console.WriteLine(firstNumber / secondNumber);
        break;
    case '%':
        Console.WriteLine(firstNumber % secondNumber);
        break;
    case 'p':
        Console.WriteLine("Values: {0} {0} ", firstNumber, secondNumber);
        break;
    case 'b':
        Console.WriteLine(Math.Max(firstNumber, secondNumber));
        break;
    case 's':
        Console.WriteLine(Math.Min(firstNumber, secondNumber));
        break;
    default:
        Console.WriteLine("Invalid option selected!");
        break;
}
