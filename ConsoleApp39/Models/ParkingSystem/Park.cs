namespace ConsoleApp39.Models.ParkingSystem
{
    internal class Park
    {
        private ParkingSpot[] _parkingSpots;
        public void AddSpot(ParkingSpot spot)
        {
            if (_parkingSpots == null)
            {
                _parkingSpots = new ParkingSpot[1];
                _parkingSpots[0] = spot;
            }
            else
            {
                Array.Resize(ref _parkingSpots, _parkingSpots.Length + 1);
                _parkingSpots[_parkingSpots.Length - 1] = spot;
            }
        }
        public void ParkVehicle(int spotNumber, string vehiclePlate, string vehicleType)
        {
            ParkingSpot spot = null;
            foreach (var item in _parkingSpots)
            {
                if (item != null && item.SpotNumber == spotNumber)
                {
                    spot = item;
                    break;
                }
            }
            if (spot == null)
            {
                throw new NotFoundException($"Parking spot with number {spotNumber} not found.");
            }
            if (spot.IsOccupied)
            {
                throw new SpotOccupiedException($"Parking spot with number {spotNumber} is already occupied.");
            }
            spot.VehiclePlate = vehiclePlate;
            spot.VehicleType = vehicleType;
            spot.IsOccupied = true;
        }
        public void RemoveVehicle(int spotId)
        {
            ParkingSpot spot = null;
            foreach (var item in _parkingSpots)
            {
                if (item != null && item.Id == spotId)
                {
                    spot = item;
                    break;
                }
            }
            if (spot == null)
            {
                throw new NotFoundException($"Parking spot with number {spotId} not found.");
            }
            if (!spot.IsOccupied)
            {
                throw new NotFoundException($"Parking spot with number {spotId} is not occupied.");
            }
            spot.VehiclePlate = null;
            spot.VehicleType = null;
            spot.IsOccupied = false;
        }
        public void GetAvailableSpots()
        {
            foreach (var item in _parkingSpots)
            {
                if (item != null && !item.IsOccupied)
                {
                    Console.WriteLine($"Spot Number: {item.SpotNumber}, Vehicle Plate: {item.VehiclePlate}, Vehicle Type: {item.VehicleType}");
                }
            }
        }
        public void GetOccupiedSpots()
        {
            foreach (var item in _parkingSpots)
            {
                if (item != null && item.IsOccupied)
                {
                    Console.WriteLine($"Spot Number: {item.SpotNumber}, Vehicle Plate: {item.VehiclePlate}, Vehicle Type: {item.VehicleType}");
                }
            }
        }
        public Park(ParkingSpot[] parkingSpots)
        {
            this._parkingSpots  = parkingSpots;
        }
        public ParkingSpot this[int index]
        {
            get
            {
                return _parkingSpots[index];
            }
            set
            {
                _parkingSpots[index] = value;
            }
        }
    }

    [Serializable]
    internal class AlreadyReservedException : Exception
    {
        public AlreadyReservedException()
        {
        }

        public AlreadyReservedException(string? message) : base(message)
        {
        }

        public AlreadyReservedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }

    [Serializable]
    internal class NotFoundException : Exception
    {
        public NotFoundException()
        {
        }

        public NotFoundException(string? message) : base(message)
        {
        }

        public NotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
