using System;

namespace VowelOrConsonant
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine("Enter the Alphabet");
            char alphabet=Convert.ToChar(Console.ReadLine());
            int test = 0;
            for(int i = 0; i < vowel.Length; i++)
            {
               if( vowel[i] == alphabet)
                {
                    test = 1;
                   
                }
            }
            if(test == 1)
            {
                Console.WriteLine("The Alphabet {0} is Vowel", alphabet);
            }
            else
            {
                Console.WriteLine("The Alphabet {0} is Consonant", alphabet);
            }
        }
    }
}
