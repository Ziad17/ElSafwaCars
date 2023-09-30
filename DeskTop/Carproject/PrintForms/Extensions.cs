using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Carproject.PrintForms
{
    public static class Extensions
    {
        public static string ConvertNumbersToArabic(this string input)
        {
            // Define a regular expression to match numeric substrings
            Regex regex = new Regex(@"\d");

            // Match all numeric substrings in the input string
            MatchCollection matches = regex.Matches(input);

            // Loop through the matches and replace each numeric substring with Arabic numbers
            foreach (Match match in matches)
            {
                string numericValue = match.Value;
                string arabicValue = NumericToArabic(numericValue);
                input = input.Replace(numericValue, arabicValue);
            }

            return input;
        }

        public static string NumericToArabic(string numericValue)
        {
            // Define an array to map numeric digits to Arabic digits
            string[] arabicDigits = { "٠", "١", "٢", "٣", "٤", "٥", "٦", "٧", "٨", "٩" };

            // Initialize a StringBuilder to build the Arabic equivalent
            var arabicBuilder = new StringBuilder();

            // Iterate through the characters of the numeric value
            foreach (char digit in numericValue)
            {
                if (char.IsDigit(digit))
                {
                    int numericDigit = int.Parse(digit.ToString());
                    arabicBuilder.Append(arabicDigits[numericDigit]);
                }
                else
                {
                    // If the character is not a digit, append it as-is
                    arabicBuilder.Append(digit);
                }
            }

            return arabicBuilder.ToString();
        }


        public static string Invert(this string text)
        {
            var invertedText = string.Empty;
            var textArray = text.Reverse();
            foreach (var c in textArray)
            {
                invertedText += c;
            }

            return invertedText;
        }
    }
}
