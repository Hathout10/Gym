using GYM.System.DAL.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.System.DAL.Data.Configrations
{
	public class BookingSessionsConfigrations : IEntityTypeConfiguration<Booking_Seessions>
	{
		public void Configure(EntityTypeBuilder<Booking_Seessions> builder)
		{

			builder.HasKey(bs=> new {bs.playerId, bs.subscriptionId, bs.receptionistId});


		}
	}
}
