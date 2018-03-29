using CS_DB_Entity.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DB_Entity.Domain {
    public class GuitarsManager {
		public static List<DTO.Guitar> GetGuitars() {
			var guitars = GuitarsRepository.GetGuitars();
			return guitars;
		}

		public static void AddGuitar(DTO.Guitar guitar) {
			try {
				GuitarsRepository.AddGuitar(guitar);
			}
			catch (Exception) {

				//LOG

				throw;
			}
		}
    }
}
