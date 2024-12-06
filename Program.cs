using System.Collections.Generic;

namespace ExceptionHandling
{

    internal class Program
    {
        public static void CheckVowels(string s)
        {
            string vowels = "aeiouAEIOU";

            foreach (char c in s)
            {
                if (vowels.Contains(c))
                {
                    return;
                }
            }

            throw new Exception("The string doesn't contain any vowels.");
        }

        static void Main(string[] args)
        {
            //task 1
            try
            {
                Console.WriteLine("Enter a string:");
                string s = Console.ReadLine();

                CheckVowels(s);

                Console.WriteLine("The string contains vowels.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            //task 2
            try
            {
                List<int> ints = new List<int>();
                int value;
                bool isfound= false;
                for (global::System.Int32 i = 0; i <= ints.Count; i++)
                {                
                    value = int.Parse(Console.ReadLine());
                    if (ints.Contains(value))
                    {
                            isfound = true;
                            throw new Exception();
                    }

                    if (!isfound)
                    {
                        ints.Add(value);
                        Console.WriteLine($"{value} added");
                    }
                }
            }
            catch
            {
                
                    Console.WriteLine("Duplicate numbers are not allowed.");
            }

        }
    }

}
