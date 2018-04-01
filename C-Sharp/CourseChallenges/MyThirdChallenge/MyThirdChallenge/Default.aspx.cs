using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyThirdChallenge
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void okButton_Click(object sender, EventArgs e)
		{
			if(stark.Checked) {
				houseImage.ImageUrl = "./images/stark.jpg";
				resultLabel.Text = "Winter is coming.";
			}
			else if(baratheon.Checked) {
				houseImage.ImageUrl = "./images/baratheon.png";
				resultLabel.Text = "Ours is the fury.";
			}
			else if(greyjoy.Checked) {
				houseImage.ImageUrl = "./images/greyjoy.jpg";
				resultLabel.Text = "We do not sow.";
			}
			else if(martell.Checked) {
				houseImage.ImageUrl = "./images/martell.png";
				resultLabel.Text = "Unbowed, unbent, unbroken.";
			}
			else {
				resultLabel.Text = "Choose a house.";
			}
		}
	}
}