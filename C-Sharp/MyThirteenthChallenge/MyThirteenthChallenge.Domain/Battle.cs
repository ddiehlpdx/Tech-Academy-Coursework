using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThirteenthChallenge.Domain {
	public class Battle {
		public bool IsTie { get; set; }

		//PLACE TWO DRAWN CARDS INTO LIST TO HOLD,
		//DETERMINE WHICH CARD WINS, PLACE BOUNTY CARDS AT END OF QUEUE
		//IN THE CASE OF A TIE, CALL THE WAR METHOD
		public void DoBattle(Player playerOne, Player playerTwo) {
			List<Card> BattleGroup = new List<Card> { playerOne.CurrentDraw, playerTwo.CurrentDraw };
			if (playerOne.CurrentDraw.Value > playerTwo.CurrentDraw.Value) {
				foreach (var card in BattleGroup) {
					playerOne.Hand.Enqueue(card);
				}
			}
			else if (playerTwo.CurrentDraw.Value > playerOne.CurrentDraw.Value) {
				foreach (var card in BattleGroup) {
					playerTwo.Hand.Enqueue(card);
				}
			}
			else {
				IsTie = true;
				DoWar(playerOne, playerTwo, BattleGroup);
			}
		}

		//OVERLOADED DOBATTLE METHOD,
		//TAKES BATTLEGROUP CARRIED OVER FROM WAR METHOD
		public void DoBattle(Player playerOne, Player playerTwo, List<Card> battleGroup) {
			List<Card> BattleGroup = battleGroup;
			if (playerOne.CurrentDraw.Value > playerTwo.CurrentDraw.Value) {
				foreach (var card in BattleGroup) {
					playerOne.Hand.Enqueue(card);
				}
			}
			else if (playerTwo.CurrentDraw.Value > playerOne.CurrentDraw.Value) {
				foreach (var card in BattleGroup) {
					playerTwo.Hand.Enqueue(card);
				}
			}
			else {
				DoWar(playerOne, playerTwo, BattleGroup);
			}
		}

		//PULL 3 CARDS FROM EACH PLAYER'S HAND TO PLACE IN BOUNTY,
		//DRAW A FOURTH CARD AND BATTLE AGAIN
		public void DoWar(Player playerOne, Player playerTwo, List<Card> battleGroup) {
			for (int i = 0; i < 3; i++) {
				battleGroup.Add(Game.Draw(playerOne));
				battleGroup.Add(Game.Draw(playerTwo));
			}

			playerOne.CurrentDraw = Game.Draw(playerOne);
			playerTwo.CurrentDraw = Game.Draw(playerTwo);
			DoBattle(playerOne, playerTwo, battleGroup);		
		}
	}
}
