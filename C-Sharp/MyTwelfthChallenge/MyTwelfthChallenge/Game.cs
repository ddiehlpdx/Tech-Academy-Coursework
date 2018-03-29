using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace MyTwelfthChallenge {
	public class Game {
		public static int PlayerOneScore { get; set; }
		public static int PlayerTwoScore { get; set; }
		public string Result { get; set; }

		//GAME METHOD ACCEPTS TWO DART OBJECTS - ONE FOR EACH PLAYER
		public Game(Dart dartOne, Dart dartTwo) {
			
			//WHILE NEITHER PLAYER HAS SCORED 300 POINTS (WIN THRESHOLD)
			while (PlayerOneScore < 300 && PlayerTwoScore < 300) {

				//ALLOW EACH PLAYER TO THROW 3 DARTS PER TURN USING THE THROW METHOD
				//RUN EACH THROW RESULT THROUGH SCORE METHOD, AND ADD EACH RETURNED SCORE TO PLAYER'S RUNNING TOTAL
				//CHECK AFTER EACH THROW TO SEE IF EITHER PLAYER HAS REACHED 300 POINTS
				for (int i = 0; i < 3; i++) {
					dartOne = dartOne.Throw(dartOne);
					PlayerOneScore += Score.GetScore(dartOne.Throw(dartOne));
					if(PlayerOneScore >= 300 || PlayerTwoScore >= 300)
						break;
				}

				for (int i = 0; i < 3; i++) {
					dartTwo = dartTwo.Throw(dartTwo);
					PlayerTwoScore += Score.GetScore(dartTwo.Throw(dartTwo));
					if (PlayerOneScore >= 300 || PlayerTwoScore >= 300)
						break;
				}

				//SUMMARIZE RESULT OF GAME FOR DISPLAY
				if (PlayerOneScore > PlayerTwoScore)
					Result += String.Format("Player One Score: {0}<br />Player Two Score: {1}<br>Player One Wins!<br />", PlayerOneScore, PlayerTwoScore);
				else
					Result += String.Format("Player One Score: {0}<br />Player Two Score: {1}<br>Player Two Wins!<br />", PlayerOneScore, PlayerTwoScore);
			}
				PlayerOneScore = 0;
				PlayerTwoScore = 0;
		}
	}
}