﻿namespace AuthApp.Data
{
    public class Book
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Isbn { get; set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
        }
    }
}
