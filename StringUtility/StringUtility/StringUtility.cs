using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtility
{
    public static class StringUtility

    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="myString">String </param>
        /// <returns>The value in milliseconds</returns>
        public static Int32 ConvertStringToMilliseconds(String myString)
        {
            // Guard Block
            // String null
            // String ""
            // String "        "
            if (String.IsNullOrWhiteSpace(myString))
            {
                throw new ArgumentException("Value was null, empty, or not a recognized time format.");
            }

            // Try Parse in the hopes that they gave us a number without ANY suffix
            int num;
            bool res = int.TryParse(myString, out num);

            if (res)
            {
                // Log statement saying that we're good
            }
                // Hours suffix scenario - h
            else if (myString.EndsWith("h"))
            {
                myString = myString.TrimEnd(new char[] {'h'});
                bool x = int.TryParse(myString, out num);
                if (x)
                {
                    num = num * 3600000;
                }
                
            }
                // Minute suffix scenario - m
            else if (myString.EndsWith("m"))
            {
                myString = myString.TrimEnd(new char[] { 'm' });
                bool x = int.TryParse(myString, out num);
                if (x)
                {
                    num = num * 60000;
                }
            }
              // Second suffix scenario - s
            else if (myString.EndsWith("s"))
            {
                myString = myString.TrimEnd(new char[] { 's' });
                bool x = int.TryParse(myString, out num);
                if (x)
                {
                    num = num * 1000;
                }
            }
            else
            {
                throw new ArgumentException("Value is not a recognized time format.");
            }
            return num;
        }
    }
}