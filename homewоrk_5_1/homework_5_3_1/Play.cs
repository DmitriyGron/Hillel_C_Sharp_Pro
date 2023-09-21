namespace homework_5_3_1
{
    public class Play : IDisposable
    {
        private string title;
        private string author;
        private string genre;
        private int year;
        private bool disposed = false;

        public Play(string title, string author, string genre, int year)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.year = year;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {title}");
            Console.WriteLine($"Автор: {author}");
            Console.WriteLine($"Жанр: {genre}");
            Console.WriteLine($"Год: {year}");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                }

                disposed = true;
            }
        }
        ~Play()
        {
            Dispose(false);
        }
    }
}
