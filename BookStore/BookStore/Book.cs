using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Book:IComparable<Book>
    {
        private string title;
        private string author;
        private int year;
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
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Book(string author, string title, int year) 
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
        }
        public int CompareTo(Book other) 
        {
            int result = this.Year.CompareTo(other.Year);
            if (result == 0) 
            {
                result = this.Title.CompareTo(other.Title);
            }
            return result;
        }
        public void Print()
        {
            Console.WriteLine($"Title - {title}, Author - {author}, Year - {Year}");
        }
    }
}
