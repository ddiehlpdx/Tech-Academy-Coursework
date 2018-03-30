using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Final.Domain {
	public class Order {
		public static string GetTotal(int sizeTotal, int crustTotal, int toppingsTotal) {
			return String.Format("{0:C}", sizeTotal, crustTotal, toppingsTotal);
		}
    }
}
