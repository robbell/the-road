namespace TheRoad.Tests
{
    public class Area
    {
        private Area north;
        private Area south;

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
    }
}