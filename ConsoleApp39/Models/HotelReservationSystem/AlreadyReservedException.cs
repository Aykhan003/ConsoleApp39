namespace ConsoleApp39.Models.HotelReservationSystem
{
    internal class AlreadyReservedException : Exception
    {
        public AlreadyReservedException(string message) : base(message)
        {
        }
    }
}
