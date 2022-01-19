
using System.Text;

namespace Converters
{
    public class RomanNumeralConverter
    {
        readonly int _minNumber = 1;
        readonly int _maxNumber = 2000;

        readonly Dictionary<int, char> _romanValues = new Dictionary<int, char>()
        {
            {1000, 'M' },
            {500, 'D' },
            {100, 'C' },
            {50, 'L' },
            {10, 'X' },
            {5, 'V' },
            {1, 'I' }
        };

        public string ConvertIntegerToRomanNumeral(int number)
        {
            if (!IsValidForConversion(number))
            {
                return($"{number} is not valid for conversion. Please enter a number between {_minNumber} and {_maxNumber}");
            }

            return GetRomanFromInt(number);
        }

        private string GetRomanFromInt(int number)
        {
            StringBuilder romanNumber = new StringBuilder();

            var intList = number.ToString().Select(digit => int.Parse(digit.ToString()));
            var numberLength = intList.Count();

            var candidateKey = _romanValues.Keys.First(k => k.ToString().Length == numberLength);
            int currentIndex = _romanValues.Keys.ToList().IndexOf(candidateKey);
            int currentKey;

            int digitCount;

            var nextIndex = currentIndex + 1;
            int? nextKey;

            var previousIndex = currentIndex - 1;
            int? previousKey;
            
            int remainder = number;
            int unitColumn;

            do
            {
                nextIndex = currentIndex + 1;
                previousIndex = currentIndex - 1;
                
                currentKey = _romanValues.ElementAt(currentIndex).Key;
                nextKey = nextIndex < _romanValues.Count ? _romanValues.ElementAt(nextIndex).Key : null;
                previousKey = previousIndex >= 0 ? _romanValues.ElementAt(previousIndex).Key : null;

                numberLength = (int)Math.Floor(Math.Log10(remainder) + 1);
                unitColumn = (int)(Math.Pow(10, numberLength - 1));
                digitCount = remainder / currentKey;

                if (digitCount > 0)
                {
                    if (remainder / unitColumn == 9)
                    {
                        romanNumber.Append(nextKey.HasValue ? _romanValues[nextKey.Value] : string.Empty);
                        romanNumber.Append(previousKey.HasValue ? _romanValues[previousKey.Value] : string.Empty);

                        remainder -= unitColumn * 4;
                    }
                    else if (digitCount == 4)
                    {
                        romanNumber.Append(_romanValues[currentKey]);
                        romanNumber.Append(previousKey.HasValue ? _romanValues[previousKey.Value] : string.Empty);
                    }
                    else if (digitCount == currentKey)
                    {
                        romanNumber.Append(_romanValues[currentKey]);
                    }
                    else
                    {
                        romanNumber.Append(_romanValues[currentKey], digitCount);
                    }
                    remainder = remainder % (digitCount * currentKey);
                }

                currentIndex += 1;

            } while (nextKey.HasValue && remainder > 0);

            return romanNumber.ToString();
        }

        private bool IsValidForConversion(int number)
        {
            return number >= _minNumber && number <= _maxNumber;
        }
    }
}
