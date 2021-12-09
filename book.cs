using System;
using System.Collections.Generic;
using System.Linq;

  class Book {
    //Auto-implemented properties
    /*i.	ISBN (text)
ii.	Title (text)
iii.	AuthorInfo (Author)
iv.	PublishedOn(date)
v.	PublishedBy(text)*/
        public string ISBN { get; set; }
        public string Title { get; set; }
        public DateTime PublishedOn { get; set; }
        public string PublishedBy { get; set; }
        public Author AuthorInfo { get; set; }
/*b.	Constructor
i.	One constructor that takes ISBN, Title and AuthorInfo. 
1.	Sets PublishedOn to current date and PublishedBy to Unknown */
public Book(string isbn, string title, Author authorinfo):this(isbn, title, authorinfo, DateTime.Today, "Unknown") { 
}
/*ii.	One constructor that takes ISBN, Title, AuthorInfo, PublishedOn and PublishedBy
iii.	When using multiple constructors, use “constructor chaining”*/
public Book(string isbn, string title, Author authorinfo, DateTime publishedon, string publishedby) {
    ISBN = isbn;
    Title = title;
    AuthorInfo = authorinfo;
    PublishedOn = publishedon;
    PublishedBy = publishedby;    
  }
  /*1.	Method takes no arguments
2.	Method displays book info*/
public void Display() {
  Console.WriteLine("Book '{0}' was written by {1} {2} and published on {3}", Title, AuthorInfo.FirstName, AuthorInfo.LastName, PublishedOn.ToString("d"));
}
  }