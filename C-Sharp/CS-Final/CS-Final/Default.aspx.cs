using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_Final {
	public partial class Default : System.Web.UI.Page {
		public int sizeTotal = 0;
		public int crustTotal = 0;
		public int toppingsTotal = 0;
		protected void Page_Load(object sender, EventArgs e) {
			if (!Page.IsPostBack) {
				totalLabel.Text = "$0.00";
			}
		}

		protected void size_SelectedIndexChanged(object sender, EventArgs e) {
			switch(size.SelectedValue) {
				case "small":
					sizeTotal = 12;
					break;
				case "medium":
					sizeTotal = 14;
					break;
				case "large":
					sizeTotal = 16;
					break;
			}
			totalLabel.Text = Domain.Order.GetTotal(sizeTotal, crustTotal, toppingsTotal);
		}

		protected void crust_SelectedIndexChanged(object sender, EventArgs e) {
			if (crust.SelectedValue == "thick")
				crustTotal = 2;
			else 
				crustTotal = 0;

			totalLabel.Text = Domain.Order.GetTotal(sizeTotal, crustTotal, toppingsTotal);
		}

		protected void submitButton_Click(object sender, EventArgs e) {

		}
	}
}