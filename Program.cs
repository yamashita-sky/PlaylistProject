namespace PlaylistProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Available songs to choose from within an album
            /// </summary>
            /// <param name="PlaylistProject"></param>
            Album LevelUp = new Album("LevelUp");
            LevelUp.Songs.Add(new Song("0. Road Trip", "Ninja Sex Party", 3.06));
            LevelUp.Songs.Add(new Song("1. Attitude City", "Ninja Sex Party", 3.14));
            LevelUp.Songs.Add(new Song("2. Unicorn Wizard", "Ninja Sex Party", 3.35));
            LevelUp.Songs.Add(new Song("3. I Just Want To (Dance)", "Ninja Sex Party", 2.37));
            LevelUp.Songs.Add(new Song("4. Dragon Slayer", "Ninja Sex Party", 3.33));
            LevelUp.Songs.Add(new Song("5. NSP Theme Song", "Ninja Sex Party", 2.21));
            LevelUp.Songs.Add(new Song("6. Party of Three", "Ninja Sex Party", 3.06));
            LevelUp.Songs.Add(new Song("7. 6969", "Ninja Sex Party", 8.39));
            LevelUp.Songs.Add(new Song("8. Dinosuar Laser Fight", "Ninja Sex Party", 2.59));
            Console.WriteLine($"Album: {LevelUp.Name}");
            Console.WriteLine("Songs in the album:");
            foreach (Song song in LevelUp.Songs)
            {
                Console.WriteLine($"Title: {song.title}, Artist: {song.artist}, Duration: {song.runtime} minutes");
            }

            Playlist playlistA = new Playlist();
            int index;
            /// <summary>
            /// The choices you have to edit your playlist
            /// </summary>
            /// <param name="PlaylistProject"></param>
            while (true)
            {
                Console.WriteLine("\nYOUR CHOICES:");
                Console.WriteLine("1. Add song to your playlist");
                Console.WriteLine("2. Remove song from your playlist");
                Console.WriteLine("3. Shuffle your playlist");
                Console.WriteLine("4. Display Playlist");
                Console.WriteLine("5. Want a specifc song from the playlist?");
                Console.WriteLine("6. Exit\n");

                Console.Write("Enter your choice (1-6): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        do
                        {
                            Console.Write("\nEnter song index or type '-1' to go back. ");
                            if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index < LevelUp.Songs.Count)
                            {
                                playlistA.AddSong(LevelUp.Songs[index]);
                                Console.WriteLine("\nSongs Currently in your playlist\n");
                                foreach (var song in playlistA.Songs)
                                {
                                    Console.WriteLine($"Title: {song.title}, Artist: {song.artist}, Duration: {song.runtime} minutes");
                                }
                            }
                            else if (index != -1)
                            {
                                Console.WriteLine("\nInvalid index. Please enter a valid index or '-1' to go back.\n");
                            }

                        } while (index != -1);
                        Console.WriteLine("\nSongs Currently in your playlist\n");
                        foreach (var song in playlistA.Songs)
                        {
                            Console.WriteLine($"Title: {song.title}, Artist: {song.artist}, Duration: {song.runtime} minutes");
                        }
                            break;
                    case "2":
                        do
                        {
                            Console.Write("\nEnter song index or type '-1' to go back.\n");
                            if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index < LevelUp.Songs.Count)
                            {
                                playlistA.RemoveSong(LevelUp.Songs[index]);
                                Console.WriteLine("\nSongs Currently in your playlist\n");
                                foreach (var song in playlistA.Songs)
                                {
                                    Console.WriteLine($"Title: {song.title}, Artist: {song.artist}, Duration: {song.runtime} minutes");
                                }
                            }
                            else if (index != -1)
                            {
                                Console.WriteLine("\nInvalid index. Please enter a valid index or '-1' to stop.\n");
                            }

                        } while (index != -1);
                        Console.WriteLine("Songs Currently in your playlist\n");
                        foreach (var song in playlistA.Songs)
                        {
                            Console.WriteLine($"Title: {song.title}, Artist: {song.artist}, Duration: {song.runtime} minutes");
                        }
                        break;
                    case "3":
                        playlistA.Shuffle();
                        foreach (var song in playlistA.Songs)
                        {
                            Console.WriteLine($"Title: {song.title}, Artist: {song.artist}, Duration: {song.runtime} minutes");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Playlist:");

                        foreach (var song in playlistA.Songs)
                        {
                                Console.WriteLine($"Title: {song.title}, Artist: {song.artist}, Duration: {song.runtime} minutes");
                        }
                        break;
                    case "5":
                        Console.Write("Enter song index: ");
                        if (int.TryParse(Console.ReadLine(), out index))
                        {
                            playlistA.DisplayASong(LevelUp.Songs[index]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.\n");
                        }
                        break;
                    case "6":
                        Console.WriteLine("\nYOUR FINAL PLAYLIST\n");
                        foreach (var song in playlistA.Songs)
                        {
                            Console.WriteLine($"Title: {song.title}, Artist: {song.artist}, Duration: {song.runtime} minutes");
                        }
                        Console.WriteLine("\nWell it's been nice knowing ya! *explosion*");
                        return;
                    default:
                        Console.WriteLine("\nOkay Smartass, you can follow instructions right? Let's try again.");
                        break;

                }
            }
        }
    }
}
