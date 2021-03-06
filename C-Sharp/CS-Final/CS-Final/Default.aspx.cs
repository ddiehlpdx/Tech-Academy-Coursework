﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CS_Final {
	public partial class Default : System.Web.UI.Page {

		//PROPERTIES USED TO TRACK PRICING BASED ON SELECTIONS
		public string exception = "";
		public static double sizeTotal = 0;
		public static double crustTotal = 0;
		public static double toppingsTotal = 0;
		public static int parsedZip = 0;
		public static List<string> toppings = new List<string>();

		protected void Page_Load(object sender, EventArgs e) {
			if (!Page.IsPostBack) {
				totalLabel.Text = "$0.00";
			}
		}

		//FUNCTIONS TO DETECT USER'S SELECTIONS AND UPDATE PRICING BY CATEGORY
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

		protected void pepperoni_CheckedChanged(object sender, EventArgs e) {
			if (pepperoni.Checked) {
				if (!toppings.Contains("Pepperoni"))
						toppings.Add("Pepperoni");
			}
			else if (!pepperoni.Checked) {
				if (toppings.Contains("Pepperoni"))
						toppings.Remove("Pepperoni");
			}

			totalLabel.Text = Domain.Order.GetTotal(sizeTotal, crustTotal, Domain.Order.TrackToppings(toppings));
		}

		protected void sausage_CheckedChanged(object sender, EventArgs e) {
			if (sausage.Checked) {
				if (!toppings.Contains("Sausage"))
						toppings.Add("Sausage");
			}
			else if (!sausage.Checked) {
				if (toppings.Contains("Sausage"))
						toppings.Remove("Sausage");
			}

			totalLabel.Text = Domain.Order.GetTotal(sizeTotal, crustTotal, Domain.Order.TrackToppings(toppings));
		}

		protected void mushrooms_CheckedChanged(object sender, EventArgs e) {
			if (mushrooms.Checked) {
				if (!toppings.Contains("Mushrooms"))
						toppings.Add("Mushrooms");
			}
			else if (!mushrooms.Checked) {
				if (toppings.Contains("Mushrooms"))
						toppings.Remove("Mushrooms");
			}

			totalLabel.Text = Domain.Order.GetTotal(sizeTotal, crustTotal, Domain.Order.TrackToppings(toppings));
		}

		protected void peppers_CheckedChanged(object sender, EventArgs e) {
			if (peppers.Checked) {
				if (!toppings.Contains("Peppers"))
					toppings.Add("Peppers");
			}
			else if (!peppers.Checked) {
				if (toppings.Contains("Peppers"))
					toppings.Remove("Peppers");
			}

			totalLabel.Text = Domain.Order.GetTotal(sizeTotal, crustTotal, Domain.Order.TrackToppings(toppings));
		}

		//CREATE A NEW DATA TRANSFER OBJECT ON SUBMIT,
		//SEND TO DOMAIN FOR PROCESSING
		protected void submitButton_Click(object sender, EventArgs e) {
			var order = new DTO.Order();

			try {
				order.Id = Guid.NewGuid();
				order.Size = size.SelectedValue;
				order.Crust = crust.SelectedValue;
				order.Toppings = toppings;
				order.Name = name.Text;
				order.Address = address.Text;
				order.Zip = zip.Text;
				order.Phone = phone.Text.Trim();
				if(cashRadio.Checked)
					order.Payment = "Cash";
				else if(cardRadio.Checked)
					order.Payment = "Card";
				double total = Convert.ToDouble(sizeTotal + crustTotal + toppingsTotal);

				Domain.Order.ProcessOrder(order);
				Server.Transfer("Success.aspx");
			}
			catch (Domain.Exceptions.InvalidSubmission) {
				exception = "You must choose a size option and a crust option.";
			}
			catch (FormatException ex) {
				exception = ex.Message;
			}

			exceptionLabel.Text = exception;
		}
	}
}