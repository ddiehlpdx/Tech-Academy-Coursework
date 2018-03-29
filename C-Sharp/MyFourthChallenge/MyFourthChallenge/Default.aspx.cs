using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFourthChallenge
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void okButton_Click(object sender, EventArgs e)
		{
			if(calendar1.SelectedDate > calendar2.SelectedDate) {
				TimeSpan difference = calendar1.SelectedDate - calendar2.SelectedDate;
				resultLabel.Text = difference.Days.ToString();
			} 
			else {
				TimeSpan difference = calendar2.SelectedDate - calendar1.SelectedDate;
				resultLabel.Text = difference.Days.ToString();
			}
		}
	}
}