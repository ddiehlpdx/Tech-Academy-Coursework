using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThirteenthChallenge.Domain {
	public class Game {
		public static string RoundSummary = "";

		//CREATE PLAYER OBJECTS,
		//CREATE Queue FOR EACH PLAYER TO BE DEALT INTO
		public static Player playerOne = new Player() { PlayerName = "Player One" };
		public static Player playerTwo = new Player() { PlayerName = "Player Two" };
		public static Battle War = new Battle();

		//SHUFFLE DECK AND DEAL CARDS INTO EACH PLAYER'S HAND
		public static void Deal() {
			List<Card> deck = new List<Card>(Deck.Shuffle(Deck.GenerateDeck(), Deck.random));
			int i = 0;
			
			foreach (var card in deck) {
				if (i == 0) {
					playerOne.Hand.Enqueue(card);
					i++;
				}
				else {
					playerTwo.Hand.Enqueue(card);
					i--;
				}
			}
			
			//SET INITIAL DRAW FOR EACH PLAYER
			playerOne.CurrentDraw = Draw(playerOne);
			playerTwo.CurrentDraw = Draw(playerTwo);

		}

		//DRAW TOP CARD FROM PLAYER'S HAND
		public static Card Draw(Player player) {
			if (player.Hand.Count > 0) {
				return player.Hand.Dequeue();
			}
			else {
				RoundSummary = GameOver(player);
				return new Card();
			}
		}

		//CHECK ROUND DETAILS TO PRINT TO SCREEN
		public static string RoundCheck() {
			
				return String.Format("<br /><br />{0} draws {1} of {2}<br />{3} draws {4} of {5}.",
					playerOne.PlayerName, playerOne.CurrentDraw.Value, playerOne.CurrentDraw.Type,
					playerTwo.PlayerName, playerTwo.CurrentDraw.Value, playerTwo.CurrentDraw.Type);
		}

		//END GAME SEQUENCE WHEN A PLAYER RUNS OUT OF CARDS
		public static string GameOver(Player loser) {
			return "<br /><br /><strong>Game over! " + loser.PlayerName + " is out of cards!</strong>";
		}

	}
}