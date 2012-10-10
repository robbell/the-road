namespace TheRoad.Tests
{
    public class Area
    {
        private Area north;
        private Area south;
        private Area east;
        private Area west;

        public Area North
        {
            get { return north; }
            set
            {
                north = value;
                if (value != null && value.South != this) value.South = this;
            }
        }

        public Area South
        {
            get { return south; }
            set
            {
                south = value;
                if (value != null && value.North != this) value.North = this;
            }
        }

        public Area East
        {
            get { return east; }
            set
            {
                east = value;
                if (value != null && value.West != this) value.West = this;
            }
        }

        public Area West
        {
            get { return west; }
            set
            {
                west = value;
                if (value != null && value.East != this) value.East = this;
            }
        }
    }
}