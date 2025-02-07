using Gym.System.DAL.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.System.DAL.Data.Entites
{
	public class Admin :Person
	{


        //Relations

        public ICollection<Equipments>? Addequipments { get; set; }
        public ICollection<Subscription>? Addplan { get; set; }
        public ICollection<CashPayment>? ControlPayments { get; set; }
        public ICollection<Employees>? manageEmployee { get; set; }

    }
}
