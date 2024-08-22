namespace IfStatementsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // CHALLENGE: BUILD A GUESSING GAME

            Random random = new Random();
            int numberToGuess = random.Next(1, 11);
            int userGuess = 0;

            //we beginning with while loop

            while (userGuess != numberToGuess)
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Too High!");

                }
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too Low!");

                }
                else
                {
                    Console.WriteLine("You guesse it!");
                }
            }

            ///////////////////////////////////////////////////////////


            // if-Statements
            int age = 16;

            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else if (age >= 13)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are a child.");
            }


            //For Loop
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Iteration: " + i);
            }

            //While Loop
            int count = 1;

            while (count <= 5)
            {
                Console.WriteLine("Count: " + count);
                count++;
            }



        }
    }
}