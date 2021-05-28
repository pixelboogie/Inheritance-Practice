using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            var album1 = new Album("Yellow Submarine", "The Beatles");
            var album2 = new Album("The Wall", "Pink Floyd");
            var album3 = new Album("Pet Sounds", "The Beach Boys");
            
            Console.WriteLine(album1.GetDisplayText());
            Console.WriteLine(album2.GetDisplayText());
            Console.WriteLine(album3.GetDisplayText());
            
            album1.Loan("Joe Smith");
            album2.Loan();
            
            Console.WriteLine(album1.GetDisplayText());
            Console.WriteLine(album2.GetDisplayText());
            
            album1.Return();
            album2.Return();
            
            Console.WriteLine(album1.GetDisplayText());
            Console.WriteLine(album2.GetDisplayText());
        }
    }
}