using System;
using System.Text;

namespace TestStrings
{
    class MainClass
    {
        static string RetrieveFirstName(string fullName)
        {
            int index = fullName.IndexOf(' ');
            return fullName.Substring(0, index);
        }

        static string RetrieveLastName(string fullName)
        {
            int index = fullName.IndexOf(' ');
            return fullName.Substring(index + 1);
        }

        static void IsValidString(string text)
        {
            Boolean isValid;
            isValid = !string.IsNullOrWhiteSpace(text);

            if(isValid)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        static StringBuilder CreateHeader(string headerText)
        {
            var builder = new StringBuilder();

            return builder.Append('-', 10)
                .AppendLine()
                .Append(headerText)
                .AppendLine()
                .Append('-', 10);
        }

        static void ReplaceCharacters(StringBuilder builder, char oldChar, char newChar)
        {
            builder.Replace(oldChar, newChar);
        }

        static string FormatPriceValue(float price, string noDecimalPoints)
        {
            string currencyFormat = "C" + noDecimalPoints;
            string formattedPrice = price.ToString(currencyFormat);
            return formattedPrice;
        }

        public static void Main(string[] args)
        {
            string fname = "John";
            string lname = "Lundgren";
            string fullName = string.Format("{0} {1}", fname, lname);
            Console.WriteLine(fullName);

            var numbers = new int[5] { 1, 2, 3, 4, 5 };
            string sNumbers = string.Join(", ", numbers);
            Console.WriteLine(sNumbers);

            //Non verbatim string
            string path1 = "c:\\dev\\cSharp";
            Console.WriteLine(path1);

            //Verbatim string
            string path2 = @"c:\dev\cSharp";
            Console.WriteLine(path2);

            //Verbatim string with new lines
            string text = @"Hello
                what is going on?
                I wish you were here.";
            Console.WriteLine(text);

            Console.WriteLine(RetrieveFirstName("John Lundgren"));
            Console.WriteLine(RetrieveLastName("John Lundgren"));

            IsValidString(" ");
            IsValidString("");
            IsValidString(null);
            IsValidString(" r");

            Console.WriteLine(FormatPriceValue(99.991459f, "0"));

            var header = CreateHeader("Welcome");

            Console.WriteLine(header);

            ReplaceCharacters(header, '-', '+');

            Console.WriteLine(header);

            header.Remove(0, 10);
            Console.WriteLine(header);

            header.Insert(0, new string('*', 10));
            Console.WriteLine(header);
        }
    }
}
