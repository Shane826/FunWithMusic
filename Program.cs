namespace FunWithMusic
{
    internal class Program
    {
        enum Genre { Rock, Jazz, Pop, Classical, Tech }

        struct Song
        { 
            private string _Title;
            private string _Description;
            private string _Rating;
            private Genre? _Genre;

            public Song(string title, string description, string rating, Genre genre)
            {
                _Title = title;
                _Description = description;
                _Rating = rating;
                _Genre = genre;
            }

            public string Display()
            { 
                return "Title:" + _Title + "\nDescription:" + _Description + "\nRating: " + _Rating + "\nGenre: " + _Genre + "\n";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your song");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("What is the description of your song");
            string tempDescription = Console.ReadLine();
            Console.WriteLine("What is the rating of your song");
            string tempRating = Console.ReadLine();
            Console.WriteLine("What is the genre of your song (r = rock, j = jazz, p = pop, c = classical, t = tech)");
            Genre tempGenre=Genre.Rock;
            char g = char.Parse(Console.ReadLine());
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
            }
            Song song = new Song(tempTitle, tempDescription, tempRating, tempGenre);
            Console.WriteLine($"{song.Display()}");
        }
    }
}
