using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_Final {
	public partial class OrderManagement : System.Web.UI.Page {
		protected void Page_Load(object sender, EventArgs e) {
			
		}

		protected void ordersGridView_RowCommand(object sender, GridViewCommandEventArgs e) {
			int index = Convert.ToInt32(e.CommandArgument);

			ordersGridView.Rows[index].Visible = false;
		}
	}
}