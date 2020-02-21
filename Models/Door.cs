using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcRoom.Models
{
    public class Door
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DoorID { get; set; }
        public string Type { get; set; }
        public int Location { get; set; }

        public ICollection<RoomDoor> RoomDoors { get; set; }
    }
}
