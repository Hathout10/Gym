using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.System.DAL.Data.Entites
{
	public class Subscription : BaseEntity
	{
		public int? NumOf_Sessions { get; set; }

		//Relations

        public int? adminId { get; set; }
        public Admin? admin { get; set; }
		public ICollection<Booking_Subscription>? BookingSubscription { get; set; }




	}
}
