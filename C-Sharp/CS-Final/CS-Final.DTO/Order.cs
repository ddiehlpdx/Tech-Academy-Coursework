using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Final.DTO
{
    public class Order
    {
		public System.Guid Id { get; set; }
		public string Size { get; set; }
		public string Crust { get; set; }
		public List<string> Toppings { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Zip { get; set; }
		public string Phone { get; set; }
		public string Payment { get; set; }
	}
}
