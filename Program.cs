namespace FunWithMusic
{
    internal class Program
    {
        enum Genre { Rock, Jazz, Pop, Classical, Tech }

        struct Song
        { 
            private string _Title;
            private string _Artist;
            private string _Album;
            private Genre? _Genre;
            private string _Length;

            //Constructor
            public Song(string title, string artist, string album, Genre genre, string length)
            {
                _Title = title;
                _Artist = artist;
                _Album = album;
                _Genre = genre;
                _Length = length;
            }
            //Setters
            public void SetTitle(string title)
            {
                _Title = title;
            }
            public void SetLength(string length)
            {
                _Length = length;
            }


            public string Display()
            { 
                return "Title:" + _Title + "\nAlbum: " + _Album + "\nArtist:" + _Artist + "\nLength: " + _Length + "\nGenre: " + _Genre;
            }
        }
        static void Main(string[] args)
        {
            //Song1
            Console.WriteLine("\nWhat is the title of your first song");
            string tempTitle = Console.ReadLine();

            Console.WriteLine("Who is the artist that made this song");
            string tempArtist = Console.ReadLine();

            Console.WriteLine("What album is this song from");
            string tempAlbum = Console.ReadLine();

            Console.WriteLine("What is the length of the song");
            string tempLength = Console.ReadLine();


            Console.WriteLine("What is the genre of your song (r = rock, j = jazz, p = pop, c = classical, t = tech)");
            Genre tempGenre;
            char g = char.ToUpper(char.Parse(Console.ReadLine()));
            switch(g)
            {
                case 'R':
                    tempGenre = Genre.Rock;
                    break;
                case 'J':
                    tempGenre = Genre.Jazz;
                    break;
                case 'P':
                    tempGenre = Genre.Pop;
                    break;
                case 'C':
                    tempGenre = Genre.Classical;
                    break;
                case 'T':
                    tempGenre = Genre.Tech;
                    break;
                default:
                    tempGenre = Genre.Rock;
                    break;
            }

            //Song2
            Console.WriteLine("What is the title of your second song");
            string tempTitle2 = Console.ReadLine();

            Console.WriteLine("Who is the artist that made this song");
            string tempArtist2 = Console.ReadLine();

            Console.WriteLine("What album is this song from");
            string tempAlbum2 = Console.ReadLine();

            Console.WriteLine("What is the length of the song");
            string tempLength2 = Console.ReadLine();


            Console.WriteLine("What is the genre of your song (r = rock, j = jazz, p = pop, c = classical, t = tech)");
            Genre tempGenre2;
            char z = char.ToUpper(char.Parse(Console.ReadLine()));
            switch (z)
            {
                case 'R':
                    tempGenre2 = Genre.Rock;
                    break;
                case 'J':
                    tempGenre2 = Genre.Jazz;
                    break;
                case 'P':
                    tempGenre2 = Genre.Pop;
                    break;
                case 'C':
                    tempGenre2 = Genre.Classical;
                    break;
                case 'T':
                    tempGenre2 = Genre.Tech;
                    break;
                default:
                   tempGenre2 = Genre.Rock;
                    break;
            }

            //Display song1
            Song song = new Song(tempTitle, tempArtist, tempAlbum, tempGenre, tempLength);
            Console.WriteLine($"{song.Display()}");

            //Display song2
            Song song2 = new Song(tempTitle2, tempArtist2, tempAlbum2, tempGenre2, tempLength2);
            Console.WriteLine($"{song2.Display()}");
        }
    }
}
