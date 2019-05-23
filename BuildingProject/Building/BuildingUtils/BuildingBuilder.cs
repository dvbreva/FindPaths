using System.Collections.Generic;
using System.Windows.Forms;

namespace Building.BuildingUtils
{
    public class BuildingBuilder
    {
        Room From { get; set; }
        Room To { get; set; }

        public Floor Floor = new Floor();
        public Dictionary<string, int> AlreadyUsedLinks = new Dictionary<string, int>();

        public string Result = "";

        // methods to set the link between the rooms on the specific floor

        private void SetRooms(string fromString, string toString)
        {
            foreach(var item in Floor.Rooms)
            {
                if (item.Key == fromString)
                {
                    this.From = item.Value;
                }
                else
                {
                    this.From = From;
                }
             
                if(item.Key == toString)
                {
                    this.To = item.Value;
                }
                else
                {
                    this.To = To;
                }
            }

            if(this.From == null && this.To == null)
            {
                MessageBox.Show("I couldn't find these rooms.");
            }
        }

        // method to clear search

        // todo : algorithm with lift rather than climb 
        // todo : algorithm with least walking effort
        // todo : algorithm with lift priority and doubled cost in case of climb 
    }
}
