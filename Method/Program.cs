using Microsoft.VisualBasic;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Seven();
        }

        static void Seven()
        {
            int num1 = int.Parse(Console.ReadLine());

            int result_addition = 0;
            int result_subtraction = 0;
            if (num1 % 7 == 0)
            {
                Console.WriteLine("Eded 7-ye bolunur");
            }
            if (num1 % 7 != 0)
            {

                for (int i = num1; i % 7 != 0; i--)
                {
                    result_subtraction = i - 1;

                }
                for (int s = num1; s % 7 != 0; s++)
                {
                    result_addition = s + 1;

                }
                if (num1 - result_subtraction == 3 || num1 - result_subtraction == 2 || num1 - result_subtraction == 1)
                {
                    Console.WriteLine("7-ye en yaxin bolunen: " + result_subtraction);
                }
                else
                {
                    Console.WriteLine("7-ye en yaxin bolunen: " + result_addition);
                }
            }

        }
    }

}