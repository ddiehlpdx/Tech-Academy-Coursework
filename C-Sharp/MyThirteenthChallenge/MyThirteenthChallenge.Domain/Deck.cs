using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThirteenthChallenge.Domain {
    public class Deck {
		
		//ENUM FOR CARD TYPE TO GENERATE DECK, 
		//STATIC PUBLIC RANDOM TO BE USED ACROSS ALL CLASSES
		public enum CardType {
			Clubs,
			Diamonds,
			Hearts,
			Spades
		}
		public static Random random = new Random();
		
		//GENERATE A NEW DECK OF CARDS TO POPULATE LIST
		public static List<Card> GenerateDeck() {
			List<Card> deck = new List<Card>();

			//ITERATE THROUGH CARDTYPE ENUM BY NAME, 
			//ADD ALL CARD VALUES (2 - ACE) TO EACH CARDTYPE IN ENUM AND STORE IN LIST
			foreach (string cardType in Enum.GetNames(typeof(Deck.CardType))) {
				for (int i = 2; i < 15; i++) {
					deck.Add(new Card() { Type = (CardType)Enum.Parse(typeof(CardType), cardType), Value = i });
				}
			}
			return deck;
		}

		//SHUFFLE DECK TO RANDOMIZE ORDER OF CARDS
		public static List<Card> Shuffle(List<Card> deck, Random random) {
			List<Card> shuffledDeck = new List<Card>(deck.OrderBy(a => random.Next()));
			return shuffledDeck;
		}
	}
}