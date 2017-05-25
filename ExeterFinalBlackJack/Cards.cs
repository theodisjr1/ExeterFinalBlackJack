using System;
using System.Collections.Generic;
using System.Text;

namespace ExeterBlackJack
{
    public enum Face { Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13 }

    public enum Suit { Hearts, Spades, Diamonds, Clubs }

    public class Card
    {
        public Face Face { get; set; }

        public Suit Suit { get; set; }

        public Card(Face f, Suit s)
        {
            Face = f;

            Suit = s;
        }
        public override string ToString()
        {
            // return base.ToString();
            var output = " ";
           // var total = " ";

            switch (Face)
            {
                case Face.Ace:
                    output += "A"; //total += 11;
                    break;
                case Face.Two:
                    output += "2"; //total += 2;
                    break;
                case Face.Three:
                    output += "3"; //total += 3;
                    break;
                case Face.Four:
                    output += "4"; //total += 4;
                    break;
                case Face.Five:
                    output += "5"; //total += 5;
                    break;
                case Face.Six:
                    output += "6"; //total += 6;
                    break;
                case Face.Seven:
                    output += "7"; //total += 7;
                    break;
                case Face.Eight:
                    output += "8"; //total += 8;
                    break;
                case Face.Nine:
                    output += "9"; //total += 9;
                    break;
                case Face.Ten:
                    output += "10"; //total += 10;
                    break;
                case Face.Jack:
                    output += "J"; //total += 10;
                    break;
                case Face.Queen:
                    output += "Q"; //total += 10;
                    break;
                case Face.King:
                    output += "K"; //total += 10;
                    break;
            }

            switch (Suit)
            {
                case Suit.Hearts:
                    output += "♥";
                    break;
                case Suit.Spades:
                    output += "♠";
                    break;
                case Suit.Diamonds:
                    output += "♦";
                    break;
                case Suit.Clubs:
                    output += "♣";
                    break;

            }

            return output;

        }

    }
}
