﻿using System.Collections.Generic;
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

            foreach(var link in BaseRoom.Links)
            {
                Room room = new Room();
                Rooms.TryGetValue(link.To, out room);
                foreach(var r in Rooms)
                {
                    if (r.Key.Equals(link.To))
                    {
                        if(r.Value.RoomParent == null)
                        {
                            r.Value.RoomParent = BaseRoom;
                        }
                        else
                        {
                            r.Value.RoomParent = r.Value.RoomParent;
                        }
                    }
                }
            }

            return LinkedRooms;
        }
    }
}