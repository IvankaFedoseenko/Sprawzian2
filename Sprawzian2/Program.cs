namespace Sprawzian2
{
    public struct Point3d
    {
        public double X;
        public double Y;
        public double Z;
        public Point3d(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public double GetDistanceFromOrigin(Point3d item)
        {
            double x = this.X;
            double y = this.Y;
            double z = this.Z;
            double result = Math.Sqrt(x * x + y * y + z * z);
            return result;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            Point3d point = new Point3d(1.5, 5.75, -7.0);
            point.GetDistanceFromOrigin(point);
            Console.WriteLine(point.GetDistanceFromOrigin(point));

            //Zadanie 4
            Human adult = new Adult();
            Human child = new Child();
            Human[] humans = { new Adult(), new Child() };
            foreach (var h in humans)
            {
                h.Sing();
            }
            // Zadanie 6
            Book ulysses = new Book("Ulysses", "James Joyce", 1922);
            Book lolita = new Book("Lolita", "Vladimir Nabokov", 1955);
            Book gatsby = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925);
            Book lostTime = new Book("In Search of Lost Time", "Marcel Proust", 1913);


            List<Book> books = new List<Book>();
            books.Add(ulysses);
            books.Add(lolita);
            books.Add(gatsby);
            books.Add(lostTime);
            
            foreach(var book in books)
            {
                Console.WriteLine(book.Author);
            }
          books.Add(new Book("Martin Eden", "Jack London", 1909));
            books.Any(x => x.YearPublished > 100 );
            bool newBook = books.Any(x => x.YearPublished > 100);
            if (newBook)
            {
                Console.WriteLine(books.Title);
            }


        }
    }
}
