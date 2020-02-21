using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRoom.Models
{
    public enum Side
    {
        North, South, East, West
    }
    public class RoomDoor
    {
        public int RoomDoorID { get; set; }
        public int DoorID { get; set; }
        public int RoomId { get; set; }
        public Side? Side { get; set; }

        public Door Door { get; set; }
        public Room Room { get; set; }
    }
}
