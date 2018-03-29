using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySecondChallenge
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void add_Click(object sender, EventArgs e)
		{
			string firstValueText = firstValueTextBox.Text;
			string secondValueText = secondValueTextBox.Text;
			int firstValue = Convert.ToInt32(firstValueText);
			int secondValue = Convert.ToInt32(secondValueText);
			resultLabel.Text = Convert.ToString(firstValue + secondValue);
		}

		protected void subtract_Click(object sender, EventArgs e)
		{
			string firstValueText = firstValueTextBox.Text;
			string secondValueText = secondValueTextBox.Text;
			int firstValue = Convert.ToInt32(firstValueText);
			int secondValue = Convert.ToInt32(secondValueText);
			resultLabel.Text = Convert.ToString(firstValue - secondValue);
		}

		protected void multiply_Click(object sender, EventArgs e)
		{
			string firstValueText = firstValueTextBox.Text;
			string secondValueText = secondValueTextBox.Text;
			int firstValue = Convert.ToInt32(firstValueText);
			int secondValue = Convert.ToInt32(secondValueText);
			resultLabel.Text = Convert.ToString(firstValue * secondValue);
		}

		protected void divide_Click(object sender, EventArgs e)
		{
			string firstValueText = firstValueTextBox.Text;
			string secondValueText = secondValueTextBox.Text;
			int firstValue = Convert.ToInt32(firstValueText);
			int secondValue = Convert.ToInt32(secondValueText);
			resultLabel.Text = Convert.ToString(firstValue / secondValue);
		}
	}
}