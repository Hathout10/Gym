using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.System.DAL.Data.Entites
{
	public class Receptionist : BaseEntity
	{
		public string Shift { get; set; }
		public double Salary { get; set; }

		//Relations

		public ICollection<Booking_Subscription>? BookingSubscription { get; set; }
		public ICollection<Player>? AddPlayer { get; set; }
		public ICollection<CashPayment>? Enrollpayments { get; set; }


	}
}
