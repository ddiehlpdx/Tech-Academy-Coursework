using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace MyTwelfthChallenge {
	public class Score {

		//CALCULATE SCORE BASED ON VALUES OF DART RETURNED FROM THROW METHOD
		public static int GetScore(Dart dart) {
			if(dart.IsCenterBullseye) {
				dart.IsCenterBullseye = false;
				return 50;
			}
			else if(dart.IsOuterBullseye) {
				dart.IsOuterBullseye = false;
				return 25;
			}
			else if(dart.IsDouble) {
				dart.IsDouble = false;
				return dart.Landing * 2;
			}
			else if(dart.IsTriple) {
				dart.IsTriple = false;
				return dart.Landing * 3;
			}
			else
				return dart.Landing;
		}
	}
}