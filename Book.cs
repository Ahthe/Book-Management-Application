/**
 * Ahthesham Ali Syed 
 * 02/25/2023
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManagementApp
{
    public class Book
    {

        private string title, author;
		private int numberOfPages;
		
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        } // Title

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        } // Author

		public int NumberOfPages
		{
			get
			{
				return numberOfPages;
			}
		} // numberOfPages

        public Book(string title,
                    string author,
                    int numberOfPages)
        {
            this.title = title;
            this.author = author;
			this.numberOfPages = numberOfPages;
        } // constructor

        public override string ToString()
        {
            return title + " by " + author + " has " + numberOfPages + " pages";
        } // ToString

    } // Book
	
} // namespace
