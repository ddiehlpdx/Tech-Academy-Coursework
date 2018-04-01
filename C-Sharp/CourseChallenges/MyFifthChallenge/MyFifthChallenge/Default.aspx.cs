using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFifthChallenge {
	public partial class Default : System.Web.UI.Page {
		protected void Page_Load(object sender, EventArgs e) {
			if(!IsPostBack) {
				image.ImageUrl = "./images/epic-spies-logo.jpg";
				calendar1.SelectedDate = DateTime.Now.Date;
				calendar2.SelectedDate = DateTime.Now.Date.AddDays(14);
				calendar3.SelectedDate = DateTime.Now.Date.AddDays(21);
				resultLabel.Text = "";
			}
		}

		protected void assignButton_Click(object sender, EventArgs e) {
			string codeName = codeNameTextBox.Text;
			string assignment = assignmentTextBox.Text;
			DateTime currentAssignmentEnd = calendar1.SelectedDate;
			DateTime newAssignmentStart = calendar2.SelectedDate;
			DateTime newAssignmentEnd = calendar3.SelectedDate;
			TimeSpan breakDuration = newAssignmentStart - currentAssignmentEnd;
			resultLabel.Text = breakDuration.Days.ToString();
			
			if(breakDuration.Days < 14) {
				resultLabel.Text = "Spies must be given a 14 day break between missions. Don't work them to death, now.";
				calendar2.SelectedDate = DateTime.Now.Date.AddDays(14);
			}
			else {
				TimeSpan missionLength = newAssignmentEnd - newAssignmentStart;
				int totalCost = missionLength.Days * 500;
				if(missionLength.Days > 21) {
					totalCost += 1000;
				}
				resultLabel.Text = String.Format("Mission: {0} has been assigned to codename: {1}.<br>"
												+ "Mission budget will be {2:C}.", assignment, codeName, totalCost);
			}
			
		}
	}
}