using System;

namespace Exercise_1
{
    class Program
    {
        public static void Main()
        {
            var book = new Book("The Tempest", "0971655819", "Shakespeare, William",
                                "Public Domain Press"); // Create a Book object with initial values
            ShowPublicationInfo(book); // Using the ShowPublicationInfo function that defined below
                                       // which get book object as input and return the publication date of book 
            book.Publish(new DateTime(2016, 8, 18)); // Using Publish method to set the publish date for this book
            ShowPublicationInfo(book); // Returns the new publication date of the book. 

            var book2 = new Book("The Tempest", "Classic Works Press", "Shakespeare, William"); // Create a Book object with initial values
            Console.Write($"{book.Title} and {book2.Title} are the same publication: " +
                  $"{((Publication)book).Equals(book2)}");
        }

        public static void ShowPublicationInfo(Publication pub)
        {
            string pubDate = pub.GetPublicationDate(); // Book Class is inherited from Publication Class
                                                       // so this function has access to publication date of the books. 
            Console.WriteLine($"{pub.Title}, " +
                      $"{(pubDate == "NYP" ? "Not Yet Published" : "published on " + pubDate):d} by {pub.Publisher}");
        }
    }
}
