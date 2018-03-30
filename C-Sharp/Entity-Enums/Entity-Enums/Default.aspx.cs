using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Entity_Enums {
	public partial class Default : System.Web.UI.Page {
		protected void Page_Load(object sender, EventArgs e) {
			var db = new EffectsPedalsEntities();
			var pedals = db.EffectsPedals;

			string result = "";

			foreach (var pedal in pedals) {
				result += String.Format("{0}<br />{1}<br />{2}<br />{3}",
					pedal.Brand,
					pedal.Name,
					pedal.Type,
					pedal.Description);
			}

			resultLabel.Text = result;
		}
	}

	public enum Brand {
		Earthquaker,
		Spaceman,
		Walrus,
		Dwarfcraft
	}

	public enum Type {
		Overdrive,
		Distortion,
		Fuzz,
		Chorus,
		Delay,
		Phaser,
		Pitch,
		Other
	}

}