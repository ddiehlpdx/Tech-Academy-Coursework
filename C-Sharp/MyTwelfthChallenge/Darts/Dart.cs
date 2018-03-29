using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
		public int Landing { get; set; }
		public int Multiplyer { get; set; }
		public bool IsDouble { get; set; }
		public bool IsTriple { get; set; }
		public bool IsOuterBullseye { get; set; }
		public bool IsCenterBullseye { get; set; }

		//CONSTRUCTOR ACCEPTS RANDOM TO DETERMINE LANDING AND MULTIPLYERS
		public Dart(Random random) {
			this.Landing = Convert.ToInt32(random.Next(0, 21));
			this.Multiplyer = Convert.ToInt32(random.Next(1, 21));
		}

		//METHOD ACCEPTS DART OBJECT, DETERMINES VALUES OF THROW
		//TO BE PASSED INTO GETSCORE METHOD
		public Dart Throw(Dart dart) {
			
			if (this.Landing == 0) {
				if (this.Multiplyer == 20)
					IsCenterBullseye = true;
				else
					IsOuterBullseye = true;
			} else {
			if (this.Multiplyer == 20)
				IsTriple = true;
			else if (this.Multiplyer == 19)
				IsDouble = true;
			}

			return dart;
		}
    }
}
