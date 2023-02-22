using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            pow();
            static void pow()
            {
                try
                {
                    Console.Write("     Enter a number --> ");
                    int mainNum = Convert.ToInt32((Console.ReadLine()));
                    Console.Write("     Enter a power --> ");
                    int powNum = Convert.ToInt32((Console.ReadLine()));
                    int resolt = mainNum;
                    for (int i = powNum; i > 1; i--)
                    {
                        resolt = resolt * mainNum;
                    }
                    Console.WriteLine($"     {resolt}");
                }
                catch (Exception)
                {
                    Console.WriteLine("     Somthing went wrong, try again");
                    throw;
                }
            }
        }
    }
}