using System;

namespace CSharp_Inheritance
{
    class Program
    {
        static void Main()
        {

            try
            {
                var album1 = new Album("Yellow Submarine", "The Beatles");
                var book1 = new Book("On The Road", "Jack Kerouac");
                var movie1 = new Movie("Titanic", "James Cameron");
                // var album2 = new Album(null, "Null Artist");
                // var album3 = new Album("", "Empty Artist");



                Console.WriteLine(album1.GetDisplayText());
                Console.WriteLine(book1.GetDisplayText());
                // Console.WriteLine(movie1.GetDisplayText());
                // Console.WriteLine(album2.GetDisplayText());
                // Console.WriteLine(album3.GetDisplayText());

                album1.Loan("Joe Smith");
                book1.Loan("Book Girl");
                movie1.Loan("Movie Dude");

                Console.WriteLine(". . . . . Display after loaned out");

                Console.WriteLine(album1.GetDisplayText());
                Console.WriteLine(book1.GetDisplayText());
                Console.WriteLine(movie1.GetDisplayText());

                album1.Return();
                book1.Return();
                movie1.Return();

                Console.WriteLine(". . . . . Display after return");

                Console.WriteLine(album1.GetDisplayText());
                Console.WriteLine(book1.GetDisplayText());
                Console.WriteLine(movie1.GetDisplayText());

                DetectMediaType(album1);
                DetectMediaType(book1);
                DetectMediaType(movie1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

        }

        static void DetectMediaType(MediaType item)
        {
            if (item is Movie)
            {
                Console.WriteLine(item.Title + " is a Movie");
            }
            else if (item is Album)
            {
                Console.WriteLine(item.Title + " is a Album");
            }

            else if(item is Book){
                Console.WriteLine(item.Title + " is a Book");
            }

            else
            {
                throw new Exception("Unexpected media subtype encountered.");
            }
        }

    }
}
