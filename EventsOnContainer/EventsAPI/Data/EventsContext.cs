
using EventsAPI.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsAPI.Data
{
    public class EventsContext :DbContext
    {
        // What part
        public DbSet<EventsType> EventTypes { get; set; }
        public DbSet<EventsHost> EventHosts { get; set; }
        public DbSet<Location> Locations { get; set; }

        public DbSet<Event> Events { get; set; }

        // How part
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventsType>(e =>
            {
                e.Property(t => t.Id)
                 .IsRequired()
                 .ValueGeneratedOnAdd();

                e.Property(t => t.Type)
                 .IsRequired()
                 .HasMaxLength(100);

            });

            modelBuilder.Entity<EventsHost>(e =>
            {
                e.Property(h => h.Id)
                 .IsRequired()
                 .ValueGeneratedOnAdd();

                e.Property(h => h.Creater)
                 .IsRequired()
                 .HasMaxLength(100);

            });

            modelBuilder.Entity<Location>(e =>
            {
                e.Property(l => l.Id)
                 .IsRequired()
                 .ValueGeneratedOnAdd();

                e.Property(l => l.Lat)
                 .IsRequired();

                e.Property(l => l.Lon)
                 .IsRequired();

                e.Property(l => l.State)
                 .IsRequired()
                 .HasMaxLength(100);

                e.Property(l => l.City)
                 .IsRequired()
                 .HasMaxLength(100);


            });

            modelBuilder.Entity<Event>(e =>
            {
                e.Property(i => i.Id)
                 .IsRequired()
                 .ValueGeneratedOnAdd();

                e.Property(i => i.Name)
                 .IsRequired()
                 .HasMaxLength(200);

                e.Property(i => i.Description)
                 .IsRequired()
                 .HasMaxLength(1000);

                e.Property(i => i.Price)
                 .IsRequired();

                e.Property(i => i.StartTime)
                 .IsRequired();

                e.Property(i => i.EndTime)
                 .IsRequired();

                e.HasOne(i => i.EventsType)
                 .WithMany()
                 .HasForeignKey(i => i.EventsTypeId);

                e.HasOne(i => i.EventsCreater)
                 .WithMany()
                 .HasForeignKey(i => i.EventCreaterId);

                e.HasOne(i => i.Location)
                 .WithMany()
                 .HasForeignKey(i => i.LocationId);
            });
        }
    }
}
