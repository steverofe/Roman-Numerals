
//Write code to convert any number between 1 and 2000 to a Roman Numeral, 
//   using the standard rules.You can use libraries/packages within reason 
//    but your solution must demonstrate the application of the rules logic you have written. 
//    Your solution will be assessed on whether it: -

//1) solves the problem 
//2) is well structured
//3) has an appropriate level of complexity

using Converters;

RomanNumeralConverter _converter = new RomanNumeralConverter();
var _number = int.MinValue;

Console.WriteLine("Convert numbers to Roman Numerals");
Console.WriteLine();
PromptUser();


string GetRomanNumeral(int numberToConvert)
{
    return _converter.ConvertIntegerToRomanNumeral(numberToConvert);
}

void PromptUser()
{
    while (_number == int.MinValue)
    {
        Console.WriteLine("Enter a number from 1 to 2000.");

        var input = Console.ReadLine();
        if (!int.TryParse(input, out _number))
        {
            Console.WriteLine("The input was not valid.");
        }
    }

    try
    {
        Console.WriteLine($"Result: {GetRomanNumeral(_number)}");
        _number = int.MinValue;
        Console.WriteLine();

        PromptUser();
    }
    catch (Exception ex)
    {
        //TODO: log ex
        Console.WriteLine($"An error has occurred - number cannot be converted.");
    }
}





