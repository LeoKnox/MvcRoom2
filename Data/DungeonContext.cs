using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcRoom.Models;

namespace MvcRoom.Data
{
    public class DungeonContext : DbContext
    {
        public DungeonContext (DbContextOptions<DungeonContext> options)
            : base(options)
        {
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomDoor> RoomDoors { get; set; }
        public DbSet<Door> Doors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Door>().ToTable("Door");
            modelBuilder.Entity<RoomDoor>().ToTable("RoomDoor");
            modelBuilder.Entity<Room>().ToTable("Room");
        }
    }
}
