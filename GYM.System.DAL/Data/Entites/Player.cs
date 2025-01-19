using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.System.DAL.Data.Entites
{
	public class Player : BaseEntity
	{
        public double? Height { get; set; }
		public double? Weight { get; set; }
        public string Gender { get; set; }
        public bool? Action { get; set; } // ("Subscribed" , "Canceled")
		public double? WalletBalance { get; set; }

		//Relations
		public ICollection<Booking_Subscription>? BookingSubscription { get; set; }
        public int? receptionistId { get; set; }
        public Receptionist? receptionist { get; set; }

    }
}
