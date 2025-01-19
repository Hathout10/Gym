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
	public class BookingSubscriptionConfigurations : IEntityTypeConfiguration<Booking_Subscription>
	{
		public void Configure(EntityTypeBuilder<Booking_Subscription> builder)
		{
			builder.HasKey(bs => new {bs.playerId, bs.subscriptionId, bs.receptionistId});


			builder.HasOne(bs=> bs.player)
				   .WithMany(p=>p.BookingSubscription)
				   .HasForeignKey(bs=>bs.playerId)
				   .OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(bs => bs.subscription)
				   .WithMany(s => s.BookingSubscription)
				   .HasForeignKey(bs => bs.subscriptionId)
				   .OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(bs => bs.receptionist)
			       .WithMany(r => r.BookingSubscription)
			       .HasForeignKey(bs => bs.receptionistId)
			       .OnDelete(DeleteBehavior.Restrict);

		}
	}
}
