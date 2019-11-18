using System;


namespace Open_Lab_04._02
{
    class Program
    {
        public static string RepetitionChar(string original, int b)
        {
            string a = "";
            for (int i = 0; i < original.Length; i++)
            {
                for (int c = 0; c < b; c++)
                {
                    a = a + original[i];
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter count repetition!");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter word!");
            string word = Console.ReadLine();
            Console.WriteLine(RepetitionChar(word, count));
        }
    }
}
