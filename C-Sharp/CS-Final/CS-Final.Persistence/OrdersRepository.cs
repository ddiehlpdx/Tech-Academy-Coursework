using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Final.Persistence {
	public partial class OrdersRepository {

		//ACCEPT VALIDATED ORDER FROM DOMAIN LAYER,
		//FORMAT DATA AND PASS INTO DATABASE
		public static void StoreOrder(DTO.Order submittedOrder) {
			OrdersEntities db = new OrdersEntities();
			var dbOrders = db.Orders;
			var order = new Order();
			string toppings = "";

			foreach (var topping in submittedOrder.Toppings) {
				toppings += topping + ", ";
			}

			order.Id = Guid.NewGuid();
			order.Size = submittedOrder.Size;
			order.Crust = submittedOrder.Crust;
			order.Toppings = toppings;
			order.Name = submittedOrder.Name;
			order.Address = submittedOrder.Address;
			order.Zip = submittedOrder.Zip;
			order.Phone = submittedOrder.Phone;
			order.Payment = submittedOrder.Payment;

			dbOrders.Add(order);
			db.SaveChanges();
		}
	}
}
