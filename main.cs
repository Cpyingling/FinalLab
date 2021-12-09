using System;

class Program {
  public static void Main (string[] args) {
/*Create 2 authors (without creating books inside Authors)
a.	Call DisplayInfo for Author 1
b.	Call DisplayInfo for Author 2*/
    Author author1 = new Author("John", "Johnson");
    author1.Email = "jj@email.com";
    Author author2 = new Author("Adam", "Brown");
    author2.Email = "ab@email.com";
    author1.DisplayInfo();
    author2.DisplayInfo();
    /*Create 6 books*/
    //first constructor for the first 3
    Book book1 = new Book("1234", "book1", author1);
    Book book2 = new Book("5678", "book2", author2);
    Book book3 = new Book("9012", "book3", author1);
    //second constructor for the other 3 books
    Book book4 = new Book("3456", "book4", author2, new DateTime(1995,12,2), "123 book");
    Book book5 = new Book("7890", "book5", author1, new DateTime(2020,3,20), "456 book");
    Book book6 = new Book("1357", "book6", author2, new DateTime(1982,5,5), "789 book");
    /*Books 1,3,5 should be set to have AuthorInfo as  Author 1*/
    author1.AddBook(book1);
    author1.AddBook(book3);
    author1.AddBook(book5);
    //Display books of Author 1
    author1.DisplayBooks();
    /*Books 2,4,6 should be set to have AuthorInfo as  Author 2*/
    author2.AddBook(book2);
    author2.AddBook(book4);
    author2.AddBook(book6);
    //Display books of Author 2
    author2.DisplayBooks();
    //Remove book #1 from Author #1
    author1.RemoveBook("1234");
    //Display books of Author 1.
    author1.DisplayBooks();

  /*•	Create 5 patrons
•	Add book 1 to Patron 1’s rentalcart by calling the AddToRentalCart method
•	Remove book 3 from Patron 1’s rentalcart by calling the RemoveFromRentalCart method
•	Display patron info
*/
Patron patron1 = new Patron("John","Johnson","1");
Patron patron2 = new Patron("Adam","Brown","2");
Patron patron3 = new Patron("Betty","Marie","3");
Patron patron4 = new Patron("Eric","Gold","4");
Patron patron5 = new Patron("Leroy","Edwards","5");
patron1.AddToRentalCart(book1, new DateTime(2021,12,10));
patron1.RemoveFromRentalCart(book3);
patron1.Display();
  }
}