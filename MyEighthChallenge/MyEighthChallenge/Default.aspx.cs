using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyEighthChallenge {
	public partial class Default : System.Web.UI.Page {
		double width;
		double height;
		double length;

		//INITIALIZE VARIABLES AND STATES ON FIRST LOAD ONLY
		protected void Page_Load(object sender, EventArgs e) {
			if(!Page.IsPostBack) {
				resultLabel.Text = "Please enter the details of your shipment.";
			}
		}

		protected void groundRadioButton_CheckedChanged(object sender, EventArgs e) {
			if(verifyData() == true) {
				double volume = calculateVolume(width, height, length);
				calculateShipping(0.15, volume);
			}
		}

		protected void airRadioButton_CheckedChanged(object sender, EventArgs e) {
			if (verifyData() == true) {
				double volume = calculateVolume(width, height, length);
				calculateShipping(0.25, volume);
			}
		}

		protected void nextDayRadioButton_CheckedChanged(object sender, EventArgs e) {
			if (verifyData() == true) {
				double volume = calculateVolume(width, height, length);
				calculateShipping(0.45, volume);
			}
		}

		//CALCULATE VOLUME BASED ON DIMENSIONS ENTERED
		protected double calculateVolume(double width, double height, double length = 1) {
			double volume = width * height * length;
			return volume;
		}

		//ADD MULTIPLYER BASED ON RADIO BUTTON SELECTION
		protected void calculateShipping(double modifier, double volume) {
			double result = volume * modifier;
			displayResult(result);
		}

		//DISPLAY RESULT BASED ON SELECTIONS
		protected void displayResult(double result) {
			resultLabel.Text = String.Format("Total to ship: {0:C}.", result);
			boom.ImageUrl = "./images/boomroasted.gif";
		}

		//VERIFY ALL INPUT MEETS REQUIREMENTS, SET LENGTH TO DEFAULT OF 1 IF NO INPUT
		protected bool verifyData() {
			if(!Double.TryParse(widthTextBox.Text, out width)) {
				throwError();
				return false;
			}
			else {
				if(!Double.TryParse(heightTextBox.Text, out height)) {
					throwError();
					return false;
				}
				else {
					if(!Double.TryParse(lengthTextBox.Text, out length)) {
						length = 1.0;
						return true;
					}
					else {
						return true;
					}
				}
			}

		}

		//THROW ERROR IN THE EVENT THAT INPUT CANNOT BE VERIFIED
		protected void throwError() {
			resultLabel.Text = "Please enter a valid width and height and choose a shipping method.";
			boom.ImageUrl = "";
		}
	}
}