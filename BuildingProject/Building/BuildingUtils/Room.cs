using System.Collections.Generic;

namespace Building.BuildingUtils
{
    public class Room
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Floor { get; set; }
        public string RoomType { get; set; }
        public bool WasTested = false;
        public List<Link> Links { get; set; }

        public Room RoomParent { get; set; }

        public Room()
        {

        }

        public Room(string name, int x, int y, int floor, string type)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Floor = floor;
            this.RoomType = type;
            Links = new List<Link>();
        }
    }
}
