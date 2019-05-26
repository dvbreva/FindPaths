using System.Collections.Generic;
using System.Windows.Forms;

namespace Building.BuildingUtils
{
    public class Floor
    {
        // one floor from the building is represented with dictionary 
        public Dictionary<string, Room> Rooms = new Dictionary<string, Room>();
       

        // method to add room
        public void AddRoom(Room room)
        {
            if(room == null || Rooms.ContainsKey(room.Name))
            {
                MessageBox.Show("This room has already been added.");
            }
            else
            {
                Rooms.Add(room.Name, room);
            }
        }

        // getting a list with all the linked rooms
        public List<Room> GetLinkedRooms(string from)
        {
            List<Room> LinkedRooms = new List<Room>();

            Room BaseRoom = new Room();
            Rooms.TryGetValue(from, out BaseRoom);

            foreach (var link in BaseRoom.Links)
            {
                Room r = new Room();
                Rooms.TryGetValue(link.To, out r);
                foreach (var room in Rooms)
                {
                    if (room.Key.Equals(link.To))
                    {
                        room.Value.RoomParent = (room.Value.RoomParent == null) ? BaseRoom : room.Value.RoomParent;
                        LinkedRooms.Add(room.Value);
                    }
                }
            }
            return LinkedRooms;
        }

        // getting a list with all the rooms that have climb link 
        public List<Room> GetLinkedRoomsWithoutStairs(string from)
        {
            List<Room> LinkedRooms = new List<Room>();
            
            Room BaseRoom = new Room();
            Rooms.TryGetValue(from, out BaseRoom);

            foreach (var link in BaseRoom.Links)
            {
                if (link.LinkType == "climb")
                {
                    continue;
                }

                foreach (var item in Rooms)
                {
                    if (item.Key.Equals(link.To))
                    { 
                        if(item.Value.RoomParent == null)
                        {
                            item.Value.RoomParent = BaseRoom;
                        }
                        else
                        {
                            item.Value.RoomParent = item.Value.RoomParent;
                        }
                        LinkedRooms.Add(item.Value);
                    }
                }
            }
            return LinkedRooms;
        }
    }
}
