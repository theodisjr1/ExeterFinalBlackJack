using System;

namespace ExeterBlackJack
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Welcome to BlackJack! Whoever is closest to 21 without going over, wins.");
            Console.WriteLine("Dealer will always stay at 17. In event of tie, the dealer is declared winner.");
            Console.WriteLine();
            Deck deck = new Deck();

            Hand hand1 = new Hand(deck.DealCards(2));

            Console.WriteLine("Your Hand: " + hand1.ToString());

            Console.WriteLine(hand1.Value);

            Console.WriteLine();
            //Console.ReadLine();

            Hand hand2 = new Hand(deck.DealCards(1));

            Console.WriteLine("Dealer holds: " + hand2.ToString());

            Console.WriteLine();


            Boolean stay = false;

            Boolean bust = false;
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

            if (hand1.Value > 21)
            {
                Console.WriteLine("You busted!");
            }
            else 
            {
                Console.WriteLine("Player stays with " + hand1.Value);
            }
            Console.WriteLine();
            Console.WriteLine("Dealer's Turn!");
            Console.WriteLine();

            hand2.Hit(deck.DealCard());
            Console.WriteLine("Dealer's Hand: " + hand2.ToString());
            Console.WriteLine(hand2.Value);
            while (!stay && bust) ;
            if (hand2.Value < hand1.Value && hand1.Value <= 17)
            {
                hand2.Hit(deck.DealCard());
                Console.WriteLine(hand2.Value);
            }
            else
            {

                Console.WriteLine("Dealer's Hand: " + hand2.ToString());
                Console.WriteLine(hand2.Value);
            }
            if (hand2.Value == 21 && hand2.Value == hand1.Value)
                Console.WriteLine("Dealer wins!");
           
            Console.ReadLine();
        }
            
        
        
    }
}