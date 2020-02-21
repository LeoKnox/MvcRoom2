using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcRoom.Data;
using MvcRoom.Models;

namespace MvcRoom.Data
{
    public class DbInitializer
    {
        public static void Initialize(DungeonContext context)
        {
            context.Database.EnsureCreated();

            if (context.Rooms.Any())
            {
                return;
            }

            var rooms = new Room[]
            {
                new Room{RoomName="Entry",Material="Earth",Length=5,Width=5},
                new Room{RoomName="StorageA",Material="Stone",Length=3,Width=7 },
                new Room{RoomName="Dungeon1",Material="Brick",Length=5,Width=3 },
                new Room{RoomName="Dungeon2",Material="Stone",Length=4,Width=4 }
            };
            foreach (Room r in rooms)
            {
                context.Rooms.Add(r);
            }
            context.SaveChanges();

            var doors = new Door[]
            {
                new Door{DoorID=1,Type="Wood",Location=2 },
                new Door{DoorID=8, Type="Stone", Location=4 },
                new Door{DoorID=12, Type="Stone", Location=3 },
                new Door{DoorID=11, Type="Iron", Location=2 },
                new Door{DoorID=44, Type="Wood", Location=1}
            };
            foreach (Door d in doors)
            {
                context.Doors.Add(d);
            }
            context.SaveChanges();

            var roomdoors = new RoomDoor[]
            {
                new RoomDoor{DoorID=1,RoomId=1,Side=Side.East},
                new RoomDoor{DoorID=8,RoomId=2,Side=Side.North },
                new RoomDoor{DoorID=12,RoomId=3,Side=Side.West },
                new RoomDoor{DoorID=11,RoomId=4, Side=Side.North },
                new RoomDoor{DoorID=44,RoomId=1, Side=Side.South}
            };
            foreach (RoomDoor s in roomdoors)
            {
                context.RoomDoors.Add(s);
            }
            context.SaveChanges();
        }
    }
}
