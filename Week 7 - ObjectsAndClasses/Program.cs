namespace Week_7___ObjectsAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;



            //Game g1 =
            //   new Game("Monopoly", 19.99m, new DateTime(1970, 01, 31));

            //Game g2 =
            //    new Game( "Scrabble", 10.99m, new DateTime(2000, 6, 15) );

            //DisplayGame(g1);
            //DisplayGame(g2);

            ComputerGame cg1 = new ComputerGame("Sonic", 29.99m, new DateTime(1990, 7, 11), "18");
            ComputerGame cg2 = new ComputerGame("Mario", 24.99m, new DateTime(2023, 5, 24), "U");

            DisplayGame(cg1);
            DisplayGame(cg2);

            static void DisplayGame(Game game)
            {
                Console.WriteLine(game);
            }

        }
    }
}
