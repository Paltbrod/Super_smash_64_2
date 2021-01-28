using System;

namespace Super_smash_64_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            string player1 = "Lukas";
            string player2 = "Joel";

            int player1hp = 100;
            int player2hp = 100;

            int r = generator.Next(1, 21);

            Console.WriteLine("Välkommen till mitt tråkiga spel");
            Console.WriteLine("välj 2 stycken spelare");

            string chooseChamp = Console.ReadLine();
            string chooseChamp2 = Console.ReadLine();

            if (chooseChamp == ("Lukas") && chooseChamp2 == ("Joel"))
            {
                Console.WriteLine("Valde du dom... Inte dom jag hade valt men men det funkar. Börja slåss");

                while (player1hp >= 0 && player2hp >= 0)
                {

                    int dmg = generator.Next(10, 20);
                    int dmg2 = generator.Next(10, 20);

                    player1hp = player1hp - dmg;
                    player2hp = player2hp - dmg2;

                    Console.WriteLine(player1 + " har nu " + (player1hp) + " hp");
                    Console.WriteLine(player2 + " har nu " + (player2hp) + " hp");
                    Console.ReadLine();


                }

                if (player1hp < 0 && player2hp < 0)
                {
                    Console.WriteLine("tråkigt värre det blev oavgjort");
                    Console.ReadLine();
                }
                else if (player1hp >= 0)
                {
                    Console.WriteLine("poggers " + (player1) + " vann matchen");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(player2 + " vann gud vad tråkigt");
                    Console.ReadLine();
                }


            }

            else if (chooseChamp != player1 && chooseChamp2 != player2)
            {
                Console.WriteLine("välj någon som man kan spela din nöt");
            }

            Console.ReadLine();

        }

    }
}
