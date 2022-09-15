namespace DesignPatterns.Flyweight
{
    public class PointOnMap
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        private readonly PointIcon _pointIcon;
        public string Draw()
        {
            return $"drawing {_pointIcon} on the map";
        }

        public PointOnMap(int latitude, int longitude, PointIcon pointIcon)
        {
            Latitude = latitude;
            Longitude = longitude;
            _pointIcon = pointIcon;
        }
    }
}