using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DB_Entity.Persistence {
    public class GuitarsRepository {
		public static List<DTO.Guitar> GetGuitars() {
			var db = new GuitarsEntities();
			
			var dbGuitars = db.Guitars.OrderBy(p => p.Brand).ToList();

			var dtoGuitars = new List<DTO.Guitar>();

			foreach (var dbGuitar in dbGuitars) {
				var dtoGuitar = new DTO.Guitar();

				dtoGuitar.Id = dbGuitar.Id;
				dtoGuitar.Brand = dbGuitar.Brand;
				dtoGuitar.Model = dbGuitar.Model;
				dtoGuitar.Year = dbGuitar.Year;
				dtoGuitar.Finish = dbGuitar.Finish;

				dtoGuitars.Add(dtoGuitar);
			}

			return dtoGuitars;
		}

		public static void AddGuitar(DTO.Guitar newGuitar) {
			GuitarsEntities db = new GuitarsEntities();
			var dbGuitars = db.Guitars;
			var guitar = new Guitar();

			if (newGuitar.Brand.Trim().Length == 0)
				throw new Exception("Brand is a required field.");

			guitar.Brand = newGuitar.Brand;
			guitar.Model = newGuitar.Model;
			guitar.Year = newGuitar.Year;
			guitar.Finish = newGuitar.Finish;
			guitar.Id = newGuitar.Id;

			try {
				dbGuitars.Add(guitar);
				db.SaveChanges();
			}
			catch (Exception ex) {

				//LOG EXCEPTION

				throw ex;
			}
			
		}
	}
}
