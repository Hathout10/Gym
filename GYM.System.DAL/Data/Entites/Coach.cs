using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.System.DAL.Data.Entites
{
	public class Coach : BaseEntity
	{
		public string Shift { get; set; }
		public double Salary { get; set; }
		public string? SpecializationType { get; set; }


    }
}
