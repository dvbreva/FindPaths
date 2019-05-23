namespace Building.BuildingUtils
{
    public class Link
    {
        public string To { get; set; }
        public string LinkType { get; set; }
        public int Cost { get; set; }
        public bool Bidirectional { get; set; }

        public Link(string to, string linkType, int cost, bool bidirectional)
        {
            this.To = to;
            this.LinkType = linkType;
            this.Cost = cost;
            this.Bidirectional = bidirectional;
        }

    }
}
