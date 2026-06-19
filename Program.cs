namespace c_BasicOppgave3Kalkulator;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // User inputs the full calculation example: 1 + 1
        Console.WriteLine("Input calculation: ");
        string calculation = Console.ReadLine()!;

        // Finds the position of the operator in the input-string
        int operatorIndex = calculation.IndexOfAny(['+', '-', '*', '/', '%']);

        // Splits the user input into two halves, before and after the operator 
        var firstHalf = calculation[..operatorIndex];
        var secondHalf = calculation[operatorIndex..];

        // Removes spaces and symbols so the halves can be converted to doubles
        var firstTrimmed = firstHalf.Trim(" ,+-*/%");
        var secondTrimmed = secondHalf.Trim(" ,+-*/%");

        // Turns the strings into usable double numbers for calculation
        double firstNumber = double.Parse(firstTrimmed);
        double secondNumber = double.Parse(secondTrimmed);
        char operation = calculation[operatorIndex];

        // Runs the calculate method and presents the answer in a readable format
        double result = Calculator.Calculate(firstNumber, secondNumber, operation);
        Console.WriteLine($"{calculation} = {result}");
    }
}