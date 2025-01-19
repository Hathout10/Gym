using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.System.DAL.Data.Entites
{
	public class Equipments
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; } = 1;

        //Relations

        public int? adminid { get; set; }
        public Admin? admin { get; set; }


    }
}
