using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.System.DAL.Data.Entites
{
	public class BaseEntity
	{
        public int id { get; set; }
		public string? Description { get; set; }
		public double Price { get; set; }


	}
}
