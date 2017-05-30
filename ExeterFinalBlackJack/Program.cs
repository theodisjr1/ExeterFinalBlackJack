using System;

namespace ExeterBlackJack
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Welcome to BlackJack! Whoever is closest to 21 without going over, wins.");
            Console.WriteLine("In event of tie, the dealer is declared winner.");
            Console.WriteLine();

            Start();
        }
        static void Start()
        {
            Deck deck = new Deck();

            Hand hand1 = new Hand(deck.DealCards(2));
            Hand hand2 = new Hand(deck.DealCards(1));





            //CheckWinner();

            void CheckWinner()
            {


                if (hand1.Value > 21) Console.WriteLine("Player busts");
                else if (hand1.Value == 21) Console.WriteLine("Congratulations!! You have BLACKJACK!");
                else if (hand2.Value > 21) Console.WriteLine("Dealer busts, You WIN!");
                else if (hand1.Value == hand2.Value) Console.WriteLine("House Wins");
                else if (hand1.Value > hand2.Value && hand1.Value < 21) Console.WriteLine("You win!");
                else if (hand1.Value > 21 && hand2.Value <= 21) Console.WriteLine("Dealer wins");
                else if (hand2.Value > hand1.Value && hand2.Value < 21) Console.WriteLine("Dealer wins");
                else if (hand2.Value == 21) Console.WriteLine("Dealer has blackjack!");
                return;

            }




            Console.WriteLine("Your Hand: " + hand1.ToString());

            Console.WriteLine(hand1.Value);

            Console.WriteLine();
            //Console.ReadLine();


            Console.WriteLine("Dealer holds: " + hand2.ToString());

            Console.WriteLine();


            Boolean stay = false;

            Boolean bust = false;
            //Boolean isGameOver = false;
            do
            {


                //Console.WriteLine("Do you want to >hit< or >stay>?");
                Console.WriteLine("PRESS H to hit or S to stay");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "h":
                        hand1.Hit(deck.DealCard());
                        Console.WriteLine("Your Hand: " + hand1.ToString());
                        Console.WriteLine(hand1.Value);
                        break;
                    case "s":
                        stay = true;
                        break;
                    default:
                        Console.WriteLine("Invalid answer. Please, press H to hit or S to stay");
                        break;
                }
                bust = hand1.Value > 21;
            } while (!stay && !bust);

            if (hand1.Value == 21)

            {
                Console.WriteLine("Player stays with " + hand1.Value);
            }
            else if (hand1.Value > 21)
            {
                Console.WriteLine("player busted");
                PlayAgain();
            }
            //CheckWinner();
            //PlayAgain();
            Console.WriteLine();
            Console.WriteLine("Dealer's Turn!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            hand2.Hit(deck.DealCard());
            Console.WriteLine("Dealer's Hand: " + hand2.ToString());

            Console.WriteLine(hand2.Value);

            while (!stay && bust) ;
            if (hand2.Value < hand1.Value && hand1.Value <= 21)
            {
                hand2.Hit(deck.DealCard());
                Console.WriteLine("Dealer's Hand: " + hand2.ToString());
                Console.WriteLine(hand2.Value);


            }
            else if (hand1.Value > 21 && hand2.Value <= 21)
            {
                Console.WriteLine("Dealer's Hand: " + hand2.ToString());
                Console.WriteLine(hand2.Value);
                //CheckWinner();
                Console.WriteLine("Dealer is the winner");
            
            }
            {

            CheckWinner();
            //Console.ReadLine();
            }

            PlayAgain();
           

        }
        static void PlayAgain()
        {
            Console.WriteLine("Press ENTER to start new game or n to quit");
            string playAgain = "";
            //var input = Console.ReadLine();

            do
            {

                playAgain = Console.ReadLine().ToLower();

            } while (playAgain.Equals("y") && playAgain.Equals("n"));

            if (playAgain.Equals("y"))

            {

                Console.WriteLine("Press enter to restart the game!");

                //Console.ReadLine();

                Console.Clear();


                Start();
            }
            else if (playAgain.Equals("n"))
            {
              

                Environment.Exit(0);

            }

            Start();

            Console.ReadLine();

        }

    }
}
