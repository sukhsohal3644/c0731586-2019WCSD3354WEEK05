using System;

namespace week5
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        class TestQuestion2
        {
            public int myFavoriteVariable = 0;
            public void PlayingWithForLoops()
            {


                // write For Loop to Add 10 numbers
                for (; MyMethod();)
                {

                    if (myFavoriteVariable > 10)

                    {
                        Console.WriteLine(" I am so out of here!!  ");
                        Console.ReadLine();
                        break;
                    }



                    Console.WriteLine(" Oh no i have to go through this again  ");

                    
            }

            public bool MyMethod()
            {
                return true;
            }
        }


    }
}
