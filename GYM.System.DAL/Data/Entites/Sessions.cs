using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.System.DAL.Data.Entites
{
	public class Sessions  : BaseEntity
	{

		//Relations

		public int? adminId { get; set; }
		public Admin? admin { get; set; }
		public ICollection<Booking_Seessions>? BookingSubscription { get; set; }



	}
}
