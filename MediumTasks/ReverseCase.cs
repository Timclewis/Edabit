using System;

namespace MediumTasks
{
    class ReverseCase
    {
        public static string Reverse(string str)
        {
            string result = string.Empty;
            char[] strArray = str.ToCharArray();
            foreach (char i in strArray)
            {
                if (char.IsLower(i))
                    result += Char.ToUpper(i);
                else
                    result += Char.ToLower(i);                   
            }

            Console.WriteLine(result);
            return result;
        }

        static void Main(string[] args)
        {
            string str = "Happy Birthday";
            Console.WriteLine( Reverse(str)); 
        }
    }
}
