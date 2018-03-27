using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThirteenthChallenge.Domain {
	public class Player {
		public string PlayerName = "";
		public Queue<Card> Hand = new Queue<Card>();
		public Card CurrentDraw = new Card();
	}
}
