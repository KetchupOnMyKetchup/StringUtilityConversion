using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StringUtility
{
    public static class StringUtilityRegex
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="myString">String </param>
        /// <returns>The value in milliseconds</returns>
        public static int ConvertStringToMilliseconds(String myString)
        {
            // Guard block
            if (myString == null)
            {
                throw new ArgumentException("String Cannot be null");
            }

            // The result
            int num = -1;

            // The Regular Expression Pattern
            Regex regex = new Regex("\\b(\\d+)(ms|h|m|s)?\\b");

            // Match the String that was passed in against the Regular Expression
            MatchCollection matches = regex.Matches(myString);

            // We really should only match once (since we're not scanning a page of text for
            // instances of a word or something like that, if we were we would use a foreach loop)
            if (matches.Count == 1)
            {
                // Get that single match
                Match match = matches[0];

                // We are expecting Match Group to have 3, since we have 2 capturing parenthesis. 
                // Note: The Capturing Parenthesis starts at [1], since [0] is the capture of the entire
                // String
                if (match.Groups.Count == 3)
                {
                    String numberString = match.Groups[1].Value;
                    String suffix = match.Groups[2].Value;

                    // Write out stuff here.
                    //Console.WriteLine("x: positive whole number {0}", numberString);
                    //Console.WriteLine("y (suffix): {0}", suffix);
                    //Console.WriteLine();

                    // Milliseconds
                    if (String.IsNullOrWhiteSpace(suffix) || "ms".Equals(suffix))
                    {
                        bool ableToParse = int.TryParse(numberString, out num);
                    }
                    // Hours
                    else if ("h".Equals(suffix))
                    {
                        bool ableToParse = int.TryParse(numberString, out num);
                        if (ableToParse)
                        {
                            num *= 3600000;
                        }
                    }
                    // Minutes
                    else if ("m".Equals(suffix))
                    {
                        bool ableToParse = int.TryParse(numberString, out num);
                        if (ableToParse)
                        {
                            num *= 60000;
                        }
                    }
                    // Seconds
                    else if ("s".Equals(suffix))
                    {
                        bool ableToParse = int.TryParse(numberString, out num);
                        if (ableToParse)
                        {
                            num *= 1000;
                        }
                    }
                    else
                    {
                        throw new ArgumentException("String did not match expected pattern");
                    }
                }
            }
            else
            {
                throw new ArgumentException("String did not match expected pattern");
            }

            return num;
        }
    }
}