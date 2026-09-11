namespace ConsoleApp39
{
    internal class MusicPlayer
    {
        public MusicPlayer(string brand, string model, int volume, string currentSong, bool isPlaying, double batteryPercent)
        {
            Brand = brand;
            Model = model;
            Volume = volume;
            CurrentSong = currentSong;
            IsPlaying = isPlaying;
            BatteryPercent = batteryPercent;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Volume { get; set; }
        public string CurrentSong { get; set; }
        public bool IsPlaying { get; set; }
        public double BatteryPercent { get; set; }
        public void Play()
        {
            if (string.IsNullOrEmpty(CurrentSong))
            {
                Console.WriteLine("No song selected.");
                return;
            }
            if (IsPlaying)
            {
                Console.WriteLine("Music is already playing.");
                return;
            }
            IsPlaying = true;
            Console.WriteLine($"Playing '{CurrentSong}'...");
        }
        public void Pause()
        {
            if (!IsPlaying)
            {
                Console.WriteLine("Music is already paused.");
                return;
            }
            IsPlaying = false;
            Console.WriteLine($"Paused '{CurrentSong}'.");
        }
        public void IncreaseVolume()
        {
            if (Volume < 100)
            {
                Volume++;
                Console.WriteLine($"Volume increased to {Volume}.");
            }
            else
            {
                Console.WriteLine("Volume is already at maximum.");
            }
        }
        public void DecreaseVolume()
        {
            if (Volume > 0)
            {
                Volume--;
                Console.WriteLine($"Volume decreased to {Volume}.");
            }
            else
            {
                Console.WriteLine("Volume is already at minimum.");
            }
        }
        public void ChangeSong(string newSong)
        {
            CurrentSong = newSong;
            Console.WriteLine($"Changed song to '{CurrentSong}'.");
        }
        public string ShowInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Volume: {Volume}, Current Song: {CurrentSong}, Is Playing: {IsPlaying}, Battery: {BatteryPercent}%";
        }
        public override string ToString()
        {
            return ShowInfo().ToString();
        }
    }
}
