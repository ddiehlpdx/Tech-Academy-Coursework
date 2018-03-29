using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DB_Entity.DTO {
	public partial class Guitar {
		public System.Guid Id { get; set; }
		public string Brand { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string Finish { get; set; }
	}
}
