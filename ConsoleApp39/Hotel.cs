namespace ConsoleApp39
{
    internal class Hotel
    {
        public string Name { get; set; }
        private Room[]Rooms = new Room[10];
        public Hotel(string name)
        {
            Name = name;
            Rooms = new Room[10];
        }
        public void AddRoom(Room room)
        {
            for (int i = 0; i < Rooms.Length; i++)
            {
                if (Rooms[i] == null)
                {
                    Rooms[i] = room;
                    return;
                }
            }
            if (Rooms[Rooms.Length - 1] != null)
            {
                Room[]newRooms = new Room[Rooms.Length * 2];
                for (int i = 0; i < Rooms.Length; i++)
                {
                    newRooms[i] = Rooms[i];
                }
                Rooms = newRooms;
            }
        }
        public Room this[int index]
        {
            get
            {
                return Rooms[index];
            }
            set
            {
                Rooms[index] = value;
            }
        }
        public void ReserveRoom(int? roomId)
        {
            Room room = null;
            foreach (Room item in Rooms)
            {
                if (item != null && item.Id == roomId)
                {
                    room = item;
                    break;
                }
            }
            if (room == null)
            {
                throw new NotFoundException($"Room with Id {roomId} not found.");
            }
            if (!room.IsAvailable)
            {
                throw new AlreadyReservedException($"Room with Id {roomId} is already reserved.");
            }
            room.IsAvailable = false;
            Console.WriteLine($"Room with Id {roomId} has been reserved.");
        }
    }
}
