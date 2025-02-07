using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.System.DAL.Data.Entites
{
	public class Booking_Seessions
	{

		//relations

		public int? receptionistId { get; set; }
		public Receptionist? receptionist { get; set; }
		public int? playerId { get; set; }
		public Player? player { get; set; }
		public int? subscriptionId { get; set; }
		public Subscription? subscription { get; set; }

	}
}
