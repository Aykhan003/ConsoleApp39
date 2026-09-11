namespace ConsoleApp39.Models.ParkingSystem
{
    internal class ParkingSpot
    {
        private static int _id;
        public int Id { get; }
        public int SpotNumber { get; set; }
        public bool IsOccupied { get; set; } = false;
        public string VehiclePlate { get; set; }
        public string VehicleType { get; set; }
        public ParkingSpot(int spotNumber, string vehiclePlate, string vehicleType)
        {
            _id++;
            Id = _id;
            SpotNumber = spotNumber;
            VehiclePlate = vehiclePlate;
            VehicleType = vehicleType;
        }
    }
}
