using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.System.DAL.Data.Entites
{
	public class CashPayment
	{
        public int Id { get; set; }
		public string PaymentType { get; set; }
		public string? Details { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        //relations

        public int? adminId { get; set; }
        public Admin? admin { get; set; }
        public int? receptionistId { get; set; }
        public Receptionist? receptionist { get; set; }



    }
}
