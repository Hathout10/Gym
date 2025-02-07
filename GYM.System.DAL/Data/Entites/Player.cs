using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.System.DAL.Data.Entites
{
	public class Player : Person
	{
        public double? Height { get; set; }
		public double? Weight { get; set; }
        public string Gender { get; set; }
		public bool? IsStopped { get; set; } = false; // ("Subscribed" , "Canceled")

		//Relations
		public ICollection<Booking_Subscription>? BookingSubscription { get; set; }
        public int? receptionistId { get; set; }
        public Receptionist? receptionist { get; set; }

    }
}
