using System;
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

        // method to locate the closest transit room
        public Room LocateClosestTransit(Room from)
        {
         
            List<Room> initialFloor = new List<Room>();
            List<Link> finalFloor = new List<Link>();

            foreach(Room ro in Rooms.Values)
            {
                if(ro.RoomType == "transit" && ro.Floor == from.Floor)
                {
                    ro.Distance = CalculateDistance(from.Name, ro.Name);
                    initialFloor.Add(ro);
                }
            }
            initialFloor.Sort((x, y) => x.Distance.CompareTo(y.Distance));
            return initialFloor[0];


        }

        // method to calculate the distance of 2 rooms' coordinates 
        public double CalculateDistance(string startRoomName, string finalRoomName)
        {
            Room startRoom;
            Room finalRoom;

            //gets the value with the associated key t.e dvata mi argumenta na metoda
            Rooms.TryGetValue(startRoomName, out startRoom);
            Rooms.TryGetValue(finalRoomName, out finalRoom);

            double currentDistance = 0;

            // ako na startovata staq etaja ne e sushtiq kato na finalnata i e tranzitna i etaja ne e null
            if(!startRoom.Floor.Equals(finalRoom.Floor) && startRoom.RoomType == "transit" && GetLinkedRooms(startRoom.Name).Find(x => x.Floor == finalRoom.Floor) != null)
            {
                Room LinkedRoom = GetLinkedRooms(startRoom.Name).Find(x => x.Floor == finalRoom.Floor);
                currentDistance = Math.Sqrt(Math.Pow(LinkedRoom.X - finalRoom.X, 2) + Math.Pow(LinkedRoom.Y - finalRoom.Y,2));
            }
            else if(!startRoom.Floor.Equals(finalRoom.Floor))
            {
                 Room TransitRoom = LocateClosestTransit(startRoom);
                 currentDistance = Math.Sqrt(Math.Pow(startRoom.X - TransitRoom.X, 2) + Math.Pow(startRoom.Y - TransitRoom.Y, 2));
            }
            else
            {
                currentDistance = Math.Sqrt(Math.Pow(startRoom.X - finalRoom.X, 2)
                       + Math.Pow(startRoom.Y - finalRoom.Y, 2));

            }

            return currentDistance;
        }
    }
}
