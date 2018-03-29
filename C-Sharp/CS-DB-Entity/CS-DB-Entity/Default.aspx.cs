using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_DB_Entity {
	public partial class Default : System.Web.UI.Page {
		protected void Page_Load(object sender, EventArgs e) {
			var guitars = Domain.GuitarsManager.GetGuitars();

			displayGuitars();
		}

		protected void guitarsGridView_RowCommand(object sender, GridViewCommandEventArgs e) {
			int index = Convert.ToInt32(e.CommandArgument);
			GridViewRow row = guitarsGridView.Rows[index];

			var brand = row.Cells[1].Text;
			var model = row.Cells[2].Text;
			var year = row.Cells[3].Text;
			var finish = row.Cells[4].Text;
			var id = Guid.Parse(row.Cells[5].Text);

			resultLabel.Text = String.Format("{0}<br />{1}<br />{2}<br />{3}<br />{4}<br />",
				brand, model, year, finish, id);
			
		}

		protected void saveButton_Click(object sender, EventArgs e) {
			var newGuitar = new DTO.Guitar();

			newGuitar.Brand = brandTextBox.Text;
			newGuitar.Model = modelTextBox.Text;
			newGuitar.Year = Convert.ToInt32(yearTextBox.Text);
			newGuitar.Finish = finishTextBox.Text;
			newGuitar.Id = Guid.NewGuid();

			try {
				Domain.GuitarsManager.AddGuitar(newGuitar);
			}
			catch (Exception ex) {
				resultLabel.Text = ex.Message;
			}
			displayGuitars();
		}

		private void displayGuitars() {
			var guitars = Domain.GuitarsManager.GetGuitars();
			guitarsGridView.DataSource = guitars.ToList();
			guitarsGridView.DataBind();
		}
	}
}