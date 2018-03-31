﻿using CS_Final.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CS_Final.Domain {
	public class Order {
		public System.Guid Id { get; set; }
		public string Size { get; set; }
		public string Crust { get; set; }
		public List<string> Toppings { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Zip { get; set; }
		public string Phone { get; set; }
		public string Payment { get; set; }

		public static int parsedZip = 0;
		public static int parsedPhone = 0;

		public static string GetTotal(double sizeTotal, double crustTotal, double toppingsTotal) {
			return String.Format("{0:C}", sizeTotal + crustTotal + toppingsTotal);
		}

		public static double TrackToppings(List<string> toppings) {
			double toppingsTotal = 0;

			foreach (var topping in toppings) {
				switch (topping) {
					case "Pepperoni":
						toppingsTotal += 1.5;
						break;
					case "Sausage":
						toppingsTotal += 2;
						break;
					case "Mushrooms":
						toppingsTotal += 1;
						break;
					case "Peppers":
						toppingsTotal += 1;
						break;
					default:
						break;
				}
			}

			return toppingsTotal;
		}

		public static void ProcessOrder(Order order) {
			if (order.Size == "choose") {
				throw new InvalidSubmission();
			}
			if (order.Crust == "choose") {
				throw new InvalidSubmission();
			} 
			if (order.Name == "") {
				string error = "You must enter a name.";
				throw new FormatException(error);
			}
			if (order.Address == "") {
				string error = "You must enter an address.";
				throw new FormatException(error);
			}
			if (!int.TryParse(order.Zip, out parsedZip)) {
				string error = "You must enter a valid zip code.";
				throw new FormatException(error);
			}
			if (!int.TryParse(order.Phone, out parsedPhone)) {
				string error = "You must enter a valid phone number with digits only.";
				throw new FormatException(error);
			}

			Persistence.Order validatedOrder = new Persistence.Order();

			validatedOrder.Id = order.Id;
			validatedOrder.Size = order.Size;
			validatedOrder.Crust = order.Crust;
			validatedOrder.Toppings = order.Toppings;
			validatedOrder.Name = order.Name;
			validatedOrder.Address = order.Address;
			validatedOrder.Zip = parsedZip.ToString();
			validatedOrder.Phone = String.Format("{0:(###)###-####}", parsedPhone);
			validatedOrder.Payment = order.Payment;
			
			Persistence.Order.StoreOrder(validatedOrder);
		}
    }
}
