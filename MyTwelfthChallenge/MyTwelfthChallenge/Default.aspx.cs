using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Darts;

namespace MyTwelfthChallenge {
	public partial class Default : System.Web.UI.Page {
		public Random random = new Random();

		protected void Page_Load(object sender, EventArgs e) {
			resultLabel.Text = "Hit the button if you dare.";
		}

		//INITIALIZE NEW DART OBJECT FOR EACH PLAYER, PASS THEM INTO GAME METHOD, DISPLAY GAME RESULTS ON PAGE
		protected void playButton_Click(object sender, EventArgs e) {
			resultLabel.Text = "";
			Dart dartOne = new Dart(random);
			Dart dartTwo = new Dart(random);
			Game game = new Game(dartOne, dartTwo);
			resultLabel.Text += game.Result;
		}

	}

}