using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyNinthChallenge {
	public partial class Default : System.Web.UI.Page {
		bool winner = true;
		int modifier = 1;
		int sevens;
		static double playerMoney = 100.00;
		double playerBet;
		Random random = new Random();

		protected void Page_Load(object sender, EventArgs e) {
			if(!Page.IsPostBack) {
				reel1.ImageUrl = setImage();
				reel2.ImageUrl = setImage();
				reel3.ImageUrl = setImage();
				resultLabel.Text = "Go ahead, place your bet and pull the lever!";
				runningTotalLabel.Text = String.Format("<strong>You currently have {0:C} remaining.</strong>", playerMoney);
			}
		}

		protected void leverButton_Click(object sender, EventArgs e) {
			playerBet = Double.Parse(betTextBox.Text);
			if (playerMoney <= 0 || playerBet > playerMoney) {
				resultLabel.Text = "Hey now, you don't have enough money... SECURITY!";
				borat.ImageUrl = "./images/whatyoujoke.gif";
				return;
			}
			reel1.ImageUrl = setImage();
			reel2.ImageUrl = setImage();
			reel3.ImageUrl = setImage();
			if(modifier > 1) {
					playerMoney += (playerBet * modifier);
					resultLabel.Text = String.Format("Great Job! You win {0} times your bet!", modifier);
					modifier = 1;
					sevens = 0;
					borat.ImageUrl = "./images/greatsuccess.gif";
			}
			else if (sevens == 3) {
				playerMoney += (playerBet * 100);
				resultLabel.Text = "Great Job! You win 100x your bet!";
				modifier = 1;
				sevens = 0;
				borat.ImageUrl = "./images/verynice.jpg";
			}
			else {
				playerMoney -= playerBet;
				resultLabel.Text = "Bummer... You lose your bet.";
				modifier = 1;
				sevens = 0;
				borat.ImageUrl = "./images/thumbsdown.gif";
			}
			runningTotalLabel.Text = String.Format("<strong>You currently have {0:C} remaining.</strong>", playerMoney);
			winner = true;
		}

		//GENERATE RANDOM NUMBER 1-12 TO CHOOSE PICTURE FOR REEL
		protected int randomNumber() {
			return random.Next(1, 13);
		}

		//ASSIGN IMAGE URLS TO STRINGS TO BE USED FOR ASSIGNING REEL IMAGES BASED ON NUMBER DRAWN
		protected string imageByNumber(int randomNumber) {
			switch(randomNumber) {
				default: 
					winner = false;
					return "./images/Bar.png";
				case 1:
					winner = false;
					return "./images/Bar.png";
				case 2:
					return "./images/Bell.png";
				case 3:
					modifier++;
					return "./images/Cherry.png";
				case 4:
					return "./images/Clover.png";
				case 5:
					return "./images/Diamond.png";
				case 6:
					return "./images/HorseShoe.png";
				case 7:
					return "./images/Lemon.png";
				case 8: 
					return "./images/Orange.png";
				case 9:
					return "./images/Plum.png";
				case 10:
					sevens++;
					return "./images/Seven.png";
				case 11:
					return "./images/Strawberry.png";
				case 12:
					return "./images/Watermellon.png";
			}
		}
		//SET IMAGE URLS AS STRINGS TO PREPARE FOR DISPLAY
		protected string setImage() {
			int random = randomNumber();
			return imageByNumber(random);
		}
	}	
}