using System;

class Program
{
    static void Main()
    {
        // START
        // make Random rng
        Random rng = new Random();

        // print short intro text
        Console.WriteLine("In The Castle of the King");
        Console.WriteLine("Find the King. Beware the Dragon.");

        // running = true
        bool running = true;

        // WHILE running
        while (running)
        {
            // prompt: "Choose a door (1-3)"
            Console.Write("Choose a door (1-3): ");

            // read input
            string? input = Console.ReadLine();

            // IF input is not "1" AND not "2" AND not "3"
            if (input != "1" && input != "2" && input != "3")
            {
                Console.WriteLine("Please enter 1, 2, or 3.\n");
                // CONTINUE loop
                continue;
            }

            // IF input == "1" THEN door = 1; ELSE IF "2" THEN 2; ELSE 3
            int door;
            if (input == "1")
            {
                door = 1;
            }
            else if (input == "2")
            {
                door = 2;
            }
            else
            {
                door = 3;
            }

            // outcome = random number from 1 to 3  // 1=King, 2=Treasure, 3=Dragon
            int outcome = rng.Next(1, 4);

            // IF outcome == 1
            if (outcome == 1)
            {
                Console.WriteLine($"You open door {door}... The King! You win.");
                running = false;
            }
            // ELSE IF outcome == 2
            else if (outcome == 2)
            {
                Console.WriteLine($"You open door {door}... Treasure. You survive, keep searching.");
                // loop continues
            }
            // ELSE (Dragon)
            else
            {
                Console.WriteLine($"You open door {door}... A hungry dragon. Game over.");
                running = false;
            }
        }
        // END
    }
}