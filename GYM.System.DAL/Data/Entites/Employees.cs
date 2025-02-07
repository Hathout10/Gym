using GYM.System.DAL.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.System.DAL.Data.Entites
{
	public class Employees: Person
	{
		public string Shift { get; set; }
		public double Salary { get; set; }
		public double? Bonus { get; set; }

		//Relation

		public int? adminId { get; set; }
        public Admin? admin { get; set; }



    }
}
