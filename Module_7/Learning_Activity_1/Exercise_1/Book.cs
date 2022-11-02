using System;

namespace Exercise_1
{
    public sealed class Book : Publication // Inheriting frm Publication Class
    {
        public Book(string title, string author, string publisher) :
               this(title, string.Empty, author, publisher) // Useing this constructor
                                                            // when Creating a new book object without a isbn code
                                                            // it calls the below constructor when isbn is null
        { }

        public Book(string title, string isbn, string author, string publisher) : base(title, publisher, PublicationType.Book)
        {
            // isbn argument must be a 10- or 13-character numeric string without "-" characters.
            // We could also determine whether the ISBN is valid by comparing its checksum digit
            // with a computed checksum.
            //
            if (!string.IsNullOrEmpty(isbn))
            {
                // Determine if ISBN length is correct.
                if (!(isbn.Length == 10 | isbn.Length == 13)) // Check the isbn length is equal to 10 or 13
                    throw new ArgumentException("The ISBN must be a 10- or 13-character numeric string.");
                if (!ulong.TryParse(isbn, out _))
                    throw new ArgumentException("The ISBN can consist of numeric characters only.");
            }
            ISBN = isbn; // Set the ISBN Property 

            Author = author; // Set the Author Property 
        }

        public string ISBN { get; } // Defining ISBN Property

        public string Author { get; } // Defining Author Property

        public decimal Price { get; private set; } // Defining Price Property

        // A three-digit ISO currency symbol.
        public string? Currency { get; private set; } // Defining Currency Property

        // Returns the old price, and sets a new price.
        public decimal SetPrice(decimal price, string currency)
        {
            if (price < 0) // Throw an exception when the price is lower than 0 which is not acceptable
                throw new ArgumentOutOfRangeException(nameof(price), "The price cannot be negative.");
            decimal oldValue = Price; // Store price before changing it to a variable named oldValue
            Price = price;

            if (currency.Length != 3) // Currencty length should be 3
                throw new ArgumentException("The ISO currency symbol is a 3-character string.");
            Currency = currency;

            return oldValue; // Return the old price
        }

        public override bool Equals(object? obj) // Overriding new method to publication class
            // return ISBN of the book if the input object was a book. 
        {
            if (obj is not Book book)
                return false;
            else
                return ISBN == book.ISBN;
        }

        public override int GetHashCode() => ISBN.GetHashCode(); // return hash code of the ISBN

        public override string ToString() => $"{(string.IsNullOrEmpty(Author) ? "" : Author + ", ")}{Title}";//
        // Showing up the book descriptions : author + title
    }
}
