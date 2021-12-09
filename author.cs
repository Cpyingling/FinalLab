using System;
using System.Collections.Generic;

  class Author : Person {
    //Properties
      //Books (List of “Book” object) (declare as private)
      private List<Book> Books = new List<Book>();
    //Constructors
      //Use the same as person class and call the base
      public Author():base() {
          Books = new List<Book>();
          Console.WriteLine("Author constructor");
        }
        public Author(string fname, string lname):base(fname,lname) {
          Books = new List<Book>();
          Console.WriteLine("Author constructor");
        }
    //Methods
    /*1.	Method will not take parameters
2.	Method will not return a value
3.	Method will display the firstname, lastname and email*/
    public void DisplayInfo() {
      Console.WriteLine($"First: {FirstName} Last: {LastName} Email: {Email}");
    }
/*1.	Method will not take parameters
2.	Method will not return a value
3.	Method will loop through the Books list using foreach and call the Display method of Book class*/
    public void DisplayBooks() {
      foreach (Book book in Books) {
      book.Display();
    }
    }
      /*1.	Method takes 1 parameter of type Book
2.	Method will add the book to the Books list
3.	Method will set the book’s AuthorInfo (firstname and lastname) to the author’s firstname and lastname*/
    public void AddBook(Book book) {
      Books.Add(book);
    }
          /*1.	Method takes 1 parameter of type text (ISBN)
2.	Method will find the book using the Find method (matching the ISBN to the book’s ISBN)
3.	Then Method will Remove the book from the List.*/ 
    public void RemoveBook(string ISBN) {  
      Books.Remove(Books.Find(book => book.ISBN == ISBN));  
    }
  }

