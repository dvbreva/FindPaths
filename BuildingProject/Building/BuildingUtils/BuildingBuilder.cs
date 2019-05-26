using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Building.BuildingUtils
{
    public class BuildingBuilder
    {
        public Room From { get; set; }
        public Room To { get; set; }

        public Floor Floor = new Floor();
        public Dictionary<string, int> AlreadyUsedLinks = new Dictionary<string, int>();

        public string Result = "";

        // method to set the link of each room on the specific floor
        public void SetRooms(string fromString, string toString)
        {
            foreach (var item in Floor.Rooms)
            {
                if (item.Key == fromString)
                {
                    this.From = item.Value;
                }
                else
                {
                    this.From = From;
                }

                if (item.Key == toString)
                {
                    this.To = item.Value;
                }
                else
                {
                    this.To = To;
                }
            }

            if (this.From == null && this.To == null)
            {
                MessageBox.Show("I couldn't find these rooms.");
            }

        }

        // method to clear search
        public void ClearFields()
        {
            foreach (var room in Floor.Rooms)
            {
                room.Value.RoomParent = null;
                room.Value.isExpanded = false;
                room.Value.isTested = false;
            }
            AlreadyUsedLinks.Clear();
        }


        // todo : algorithm with lift rather than climb 
        public string NoStairsPath(string f, string t)
        {
            // additional check if user(for some reason) choses the same destination room as start)
            try
            {
                if (f == t)
                {
                    MessageBox.Show($"You cannot find path between the same rooms. Values you've chosen are not valid. Please check 2 different rooms.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            string ResultPath = "";
            string SearchedPath = "Rooms that are going to be checked: \n\n";

            List<Room> queue = new List<Room>();
            List<Room> actualPath = new List<Room>();

            int cost = 0;
            string typeOfLink = "";

            ClearFields();
            SetRooms(f, t);
            queue.Add(From);

            Room tempRoom = new Room();

            // while there are any rooms to queue 
            while (queue.Count > 0)
            {
                tempRoom = queue.First<Room>();
                actualPath.Add(tempRoom);

                if (tempRoom.Links.Count != 0)
                {
                    SearchedPath += $" > {tempRoom.Name} which has link to:";
                }
                else
                {
                    SearchedPath += $" > {tempRoom.Name} \n ";
                }

                foreach (var item in tempRoom.Links)
                {
                    // display the rooms linked to our temp room
                    SearchedPath += $" {item.To},";
                }
                SearchedPath = SearchedPath.TrimEnd(',');
                SearchedPath += " \n";

                // if current temp room equals the destination room, then we have found path (name shte e = to)
                if (tempRoom.Name == t)
                {
                    ResultPath += "I found path! \n\n";

                    // dokato na temp room imeto na roditelq e razlichno ot kudeto sme zapochnali

                    while (tempRoom.RoomParent.Name != f)
                    {
                        // add the parent room to the searching path and initialize temp room with it
                        actualPath.Add(tempRoom.RoomParent);
                        tempRoom = tempRoom.RoomParent;
                        if (tempRoom.RoomParent == null)
                        {
                            break; // ako nqmame parent shte izleze
                        }
                    }

                    actualPath.Add(tempRoom.RoomParent);
                    actualPath.Reverse(); // reverse temproom with its parent 

                    ResultPath += $"Your first selected Room is: \nRoom {actualPath.ElementAt(0).Name}";

                    foreach (var currentItem in actualPath)
                    {
                        if (actualPath.ElementAt(0) == currentItem)
                        {
                            continue;
                        }
                        List<Link> tempLinkList = new List<Link>();
                        tempLinkList = currentItem.RoomParent.Links.FindAll(x => x.To == currentItem.Name);

                        Link tempLink;
                        if ((tempLinkList.Find(x => x.LinkType == "lift") != null))
                        {
                            tempLink = tempLinkList.Find(x => x.LinkType == "lift");
                        }
                        else
                        {
                            tempLink = tempLinkList.ElementAt(0);
                        }
                        var type = tempLink.LinkType;

                        // udvoqvaneto na cost-a
                        int newCost = 0;
                        if (tempLink.LinkType == "climb")
                        {
                            newCost = 2 * tempLink.Cost;
                        }
                        else
                        {
                            newCost = tempLink.Cost;
                        }
                        cost = cost + newCost;


                        if (!AlreadyUsedLinks.Keys.Contains(tempLink.LinkType))
                        {
                            AlreadyUsedLinks.Add(tempLink.LinkType, 1);
                        }
                        else
                        {
                            AlreadyUsedLinks[tempLink.LinkType] += 1;
                        }

                        Result += $" Path Details. \n\n" +
                            $"{actualPath.ElementAt(0).Name}-> {type} (cost: {newCost}) -> {currentItem.Name}";

                        if (currentItem.Name == t)
                        {
                            Result += $"\n\n Cost: {cost}";
                            Result += $"\n Links used: ";
                            foreach (var l in AlreadyUsedLinks)
                            {
                                Result += $"\n {l.Key} x {l.Value} time/times";
                            }
                            break;
                        }
                    }
                    return ResultPath;
                }

                //if there are links to the current room
                if (Floor.GetLinkedRoomsWithoutStairs(tempRoom.Name).Count != 0)
                {
                    foreach (Room linked in Floor.GetLinkedRoomsWithoutStairs(tempRoom.Name))
                    {
                        if (!linked.isTested && !queue.Contains(linked))
                            queue.Add(linked);
                    }
                    tempRoom.isExpanded = true;
                }
                tempRoom.isTested = true;
                queue.Remove(queue.First<Room>());
            }
            Result = $"No path without stairs from {f} to {t} found.\nTry another way.";
            return SearchedPath;
        }

        // todo : algorithm with least walking effort

        // todo : algorithm with lift priority and doubled cost in case of climb 
        public string FindPathWithLift(string f, string t)
        {
            string ResultPath = "";
            string SearchedPath = "Rooms that are going to be checked: \n\n";

            List<Room> queue = new List<Room>();
            List<Room> actualPath = new List<Room>();

            int cost = 0;
            string typeOfLink = "";

            ClearFields();
            SetRooms(f, t);
            queue.Add(From);

            Room tempRoom = new Room();

            // while there are any rooms to queue 
            while (queue.Count > 0)
            {
                tempRoom = queue.First<Room>();
                actualPath.Add(tempRoom);

                if (tempRoom.Links.Count != 0)
                {
                    SearchedPath += $" > {tempRoom.Name} which has link to:";
                }
                else
                {
                    SearchedPath += $" > {tempRoom.Name} \n ";
                }

                foreach (var item in tempRoom.Links)
                {
                    // display the rooms linked to our temp room
                    SearchedPath += $" {item.To},";
                }
                SearchedPath = SearchedPath.TrimEnd(',');
                SearchedPath += " \n";

                // if current temp room equals the destination room, then we have found path (name shte e = to)
                if (tempRoom.Name == t)
                {
                    ResultPath += "I found path! \n\n";

                    // dokato na temp room imeto na roditelq e razlichno ot kudeto sme zapochnali

                    while (tempRoom.RoomParent.Name != f)
                    {
                        // add the parent room to the searching path and initialize temp room with it
                        actualPath.Add(tempRoom.RoomParent);
                        tempRoom = tempRoom.RoomParent;
                        if (tempRoom.RoomParent == null)
                        {
                            break; // ako nqmame parent shte izleze
                        }
                    }

                    actualPath.Add(tempRoom.RoomParent);
                    actualPath.Reverse(); // reverse temproom with its parent 

                    ResultPath += $"Your first selected Room is: \nRoom {actualPath.ElementAt(0).Name}";

                    foreach (var currentItem in actualPath)
                    {
                        if (actualPath.ElementAt(0) == currentItem)
                        {
                            continue;
                        }
                        List<Link> tempLinkList = new List<Link>();
                        tempLinkList = currentItem.RoomParent.Links.FindAll(x => x.To == currentItem.Name);

                        Link tempLink;
                        if ((tempLinkList.Find(x => x.LinkType == "lift") != null))
                        {
                            tempLink = tempLinkList.Find(x => x.LinkType == "lift");
                        }
                        else
                        {
                            tempLink = tempLinkList.ElementAt(0);
                        }
                        var type = tempLink.LinkType;

                        // udvoqvaneto na cost-a
                        int newCost = 0;
                        if (tempLink.LinkType == "climb")
                        {
                            newCost = 2 * tempLink.Cost;
                        }
                        else
                        {
                            newCost = tempLink.Cost;
                        }
                        cost = cost + newCost;


                        if (!AlreadyUsedLinks.Keys.Contains(tempLink.LinkType))
                        {
                            AlreadyUsedLinks.Add(tempLink.LinkType, 1);
                        }
                        else
                        {
                            AlreadyUsedLinks[tempLink.LinkType] += 1;
                        }

                        Result += $" Path Details. \n\n" +
                            $"{actualPath.ElementAt(0).Name}-> {type} (cost: {newCost}) -> {currentItem.Name}";

                        if (currentItem.Name == t)
                        {
                            Result += $"\n\n Cost: {cost}";
                            Result += $"\n Links used: ";
                            foreach (var l in AlreadyUsedLinks)
                            {
                                Result += $"\n {l.Key} x {l.Value} time/times";
                            }
                            break;
                        }
                    }
                    return ResultPath;
                }

                //if there are links to the current room
                if (Floor.GetLinkedRooms(tempRoom.Name).Count != 0)
                {
                    foreach (Room linked in Floor.GetLinkedRooms(tempRoom.Name))
                    {
                        if (!linked.isTested && !queue.Contains(linked))
                            queue.Add(linked);
                    }
                    tempRoom.isExpanded = true;
                }
                tempRoom.isTested = true;
                queue.Remove(queue.First<Room>());
            }
            Result = $"No path without stairs from {f} to {t} found.\nTry another way.";
            return SearchedPath;
        }


    }
}
