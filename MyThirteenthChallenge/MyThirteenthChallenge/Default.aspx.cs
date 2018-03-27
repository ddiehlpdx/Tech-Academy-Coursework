using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyThirteenthChallenge.Domain;

namespace MyThirteenthChallenge {
	public partial class Default : System.Web.UI.Page {

		public void Page_Load(object sender, EventArgs e) {
			if (!Page.IsPostBack) {
				Game.Deal();
				resultLabel.Text += "Cards dealt! Begin round!";
			}
		} 

		protected void warButton_Click(object sender, EventArgs e) {
			while (Game.playerOne.Hand.Count > 0 && Game.playerTwo.Hand.Count > 0) {
				if (Game.War.IsTie) {
					resultLabel.Text += "<br /><strong>*** WAAARRR!!! ***</strong>";
				}

				resultLabel.Text += Game.RoundCheck();
				Game.War.IsTie = false;
				Game.War.DoBattle(Game.playerOne, Game.playerTwo);
				Game.playerOne.CurrentDraw = Game.Draw(Game.playerOne);
				Game.playerTwo.CurrentDraw = Game.Draw(Game.playerTwo);
			}

			resultLabel.Text += Game.RoundSummary;
		}
	}
}