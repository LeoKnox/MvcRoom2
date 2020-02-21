using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRoom.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string RoomName { get; set; }
        public string Material { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public ICollection<RoomDoor> RoomDoors { get; set; }
    }
}
