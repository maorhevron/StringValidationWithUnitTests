using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Maor_Hevron_trendemon
{
    public abstract class StringValidator
    {
        protected Stack m_ValidationStack = new Stack();

        public void RunStringValidator()
        {
            Boolean isStrValidate;
            string StrToValidate;
            StrToValidate = getUserInput();
            isStrValidate = ValidateString(StrToValidate);
            if (isStrValidate == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The string \"{0}\" is valid !", StrToValidate);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The string \"{0}\" is NOT valid !", StrToValidate);
            }

            Console.ResetColor();
            Console.ReadKey();
        }

        private string getUserInput()
        {
            string UserInput;
            Console.WriteLine("\t-----Maor Hevron - Trendemon home Ex.-----{0}", System.Environment.NewLine);
            Console.WriteLine("Please enter a string for validation checking (if brackets are balanced) : ");
            UserInput = Console.ReadLine();

            return UserInput;
        }

        public abstract Boolean ValidateString(string i_StrToValidate);
    }
}
