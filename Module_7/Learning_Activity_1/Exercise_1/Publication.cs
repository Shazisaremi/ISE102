using System;

namespace Exercise_1
{
    public abstract class Publication
    {
        // Defining The Fields
        private bool _published = false;
        private DateTime _datePublished;
        private int _totalPages;

        // Defining the Constructor
        public Publication(string title, string publisher, PublicationType type)
        {
            // Raise error if the publisher name was null 
            if (string.IsNullOrWhiteSpace(publisher))
                throw new ArgumentException("The publisher is required.");
            Publisher = publisher;
            // Raise Exception when the title of the publication was null
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("The title is required.");
            Title = title;
            Type = type;
        }

        // Defining the Properties.
        public string Publisher { get; }

        public string Title { get; }

        public PublicationType Type { get; } // Publication Type is an enum class which is inside the project files 

        public string? CopyrightName { get; private set; }

        public int CopyrightDate { get; private set; }

        // Get and set the pages of the books. and raise exception when the input pages less than zero
        public int Pages {
            get { return _totalPages; }
            set {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "The number of pages cannot be zero or negative.");
                _totalPages = value;
            }
        }

        // Define GetPublicationDate Method. 
        public string GetPublicationDate()
        {
            if (!_published)
                return "NYP";
            else
                return _datePublished.ToString("d");
        }

        // Define Publish Method to update the DatePublishe field for the specific book
        public void Publish(DateTime datePublished)
        {
            _published = true;
            _datePublished = datePublished;
        }

        // Set the copyright holder name and date
        public void Copyright(string copyrightName, int copyrightDate)
        {
            if (string.IsNullOrWhiteSpace(copyrightName))
                throw new ArgumentException("The name of the copyright holder is required.");
            CopyrightName = copyrightName;

            int currentYear = DateTime.Now.Year;
            if (copyrightDate < currentYear - 10 || copyrightDate > currentYear + 2)
                throw new ArgumentOutOfRangeException($"The copyright year must be between {currentYear - 10} and {currentYear + 1}");
            CopyrightDate = copyrightDate;
        }

        // Return the Title of publication
        public override string ToString() => Title;
    }
}
