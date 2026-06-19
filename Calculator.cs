class Calculator
{
    // Takes the input from the main program, runs through a switch based on the operator and returns the result
    public static double Calculate(double firstNumber, double secondNumber, char operation)
    {
        double result = operation switch
        {
            '+' => firstNumber + secondNumber,
            '-' => firstNumber - secondNumber,
            '*' => firstNumber * secondNumber,
            '/' => firstNumber / secondNumber,
            '%' => firstNumber % secondNumber,
        };
        return result;
    }
}