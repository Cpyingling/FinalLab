using System;
class Rental {
  //Properties
  public Book Book;
  public DateTime DateRented;
  public DateTime DateDue;
  //One constructor that takes 3 parameters
  public Rental(Book Book, DateTime DateRented, DateTime DateDue) {
    this.Book = Book;
    this.DateRented = DateRented;
    this.DateDue = DateDue;
  }
}