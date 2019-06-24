using System;

namespace jack

{
    class program
    {
        static void Main(string[] args)
        {
            /*in this challenge you need to generate a random numbers from 1 to 10 
             *ask the user to guess the number and based on that, this program needs to tell how well the guess is
             * whether good, close, bad or exact. 
             * in order to generate random number use the build in Random function 
             * so lets get the party started :-)
            */
            
            bool flag = true;
            while (flag)
            {
                Random rand = new Random();
                int num = rand.Next(1, 11);
                Console.WriteLine("lets get started with this game");
                Console.WriteLine("enter the number you guess from values 1 - 10");
                int guess = int.Parse(Console.ReadLine());

                if (num != guess)
                {

                    while (num != guess)
                    {

                        if (guess < num)
                        {
                            Console.WriteLine("your guess is small, please try up something new!!!");
                            guess = int.Parse(Console.ReadLine());

                        }
                        else if (guess > num)
                        {
                            Console.WriteLine("your guess is high, try to make it low i hope you get it!!");
                            guess = int.Parse(Console.ReadLine());
                        }

                    }
                }
                else
                {
                    Console.WriteLine("wow thats amazing you got this on first atempt!!!!!!!!!!!!!!!");
                }

                if (num == guess)
                {
                    Console.WriteLine("hoooray you got this one!!!!!!!!!!");
                    Console.WriteLine("do you want to play it again \n enter [y or n]");
                    String ans = Console.ReadLine();
                    flag = ans == "y" ? true : false;
                    num = 0;
                }
            }

            Console.WriteLine("see you soon");
            
            



            }   
    }
}