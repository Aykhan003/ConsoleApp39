using ConsoleApp39;
using ConsoleApp39.Models.BankAccountSystem;
using ConsoleApp39.Models.ParkingSystem;
using System.Numerics;

//MusicPlayer musicPlayer = new MusicPlayer("Sony", "Walkman", 50, "Song A", false, 75.0);
//while (true)
//{
//    Console.WriteLine();
//    Console.WriteLine("0 - Player haqqında məlumat");
//    Console.WriteLine("1 - Play");
//    Console.WriteLine("2 - Pause");
//    Console.WriteLine("3 - Səsi artır");
//    Console.WriteLine("4 - Səsi azalt");
//    Console.WriteLine("5 - Mahnını dəyiş");
//    Console.WriteLine("6 - Çıxış");

//    Console.Write("Seçim: ");
//    string choice = Console.ReadLine();

//    switch(choice)
//    {
//        case "0":
//            Console.WriteLine($"Brand: {musicPlayer.Brand}, Model: {musicPlayer.Model}, Volume: {musicPlayer.Volume}, Current Song: {musicPlayer.CurrentSong}, Is Playing: {musicPlayer.IsPlaying}, Battery Percent: {musicPlayer.BatteryPercent}");
//            break;
//        case "1":
//            musicPlayer.Play();
//            break;
//        case "2":
//            musicPlayer.Pause();
//            break;
//        case "3":
//            musicPlayer.IncreaseVolume();
//            break;
//        case "4":
//            musicPlayer.DecreaseVolume();
//            break;
//        case "5":
//            Console.Write("Yeni mahnı: ");
//            string song = Console.ReadLine();

//            musicPlayer.ChangeSong(song);
//            break;
//        case "6":
//            return;
//        default:
//            Console.WriteLine("Wrong choice. Please make a valid choice.");
//            break;
//    }
//}
//Bank bank = new Bank();
//while (true)
//{
//    Console.WriteLine();
//    Console.WriteLine("0 - Bütün account-ları göstər");
//    Console.WriteLine("1 - Yeni account yarat");
//    Console.WriteLine("2 - Deposit");
//    Console.WriteLine("3 - Withdraw");
//    Console.WriteLine("4 - Transfer");
//    Console.WriteLine("5 - Account məlumatlarını göstər");
//    Console.WriteLine("6 - Account məlumatlarını dəyiş");
//    Console.WriteLine("7 - Proqramdan çıx");

//    Console.Write("Seçim: ");
//    string choice = Console.ReadLine();

//    switch (choice)
//    {
//        case "0":
//            break;
//        case "1":
//            break;
//        case "2":
//            break;
//        case "3":
//            break;
//        case "4":
//            break;
//        case "5":
//            break;
//        case "6":
//            break;
//        case "7":
//            return;
//        default:
//            Console.WriteLine("Wrong choise");
//            break;
//    }
//}
ParkingSpot[] parkingSpots = new ParkingSpot[10];
while (true)
{
    Console.WriteLine();
    Console.WriteLine("0 - Bütün park yerlərini göstər");
    Console.WriteLine("1 - Yeni park yeri əlavə et");
    Console.WriteLine("2 - Park yerinə avtomobil yerləşdir");
    Console.WriteLine("3 - Park yerindən avtomobili çıxar");
    Console.WriteLine("4 - Boş park yerlərinin sayini göstər");
    Console.WriteLine("5 - Dolu park yerlərini sayini göstər");
    Console.WriteLine("6 - Parking yerini redakte et");
    Console.WriteLine("7 - Proqramdan çıx");
    Console.Write("Seçim: ");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "0":
            break;
        case "1":
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            break;
        case "6":
            break;
        case "7":
            return;
        default:
            Console.WriteLine("Wrong choise");
            break;
    }
}   