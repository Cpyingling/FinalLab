using System;
using System.Collections.Generic;

class Patron : Person {
  private List<Rental> RentalCart = new List<Rental>();
  //Auto Implemented properties
  public string LibraryId {get; set;}
  public DateTime StartDate {get; set;}
  public DateTime EndDate {get; set;}
  public bool IsAccountActive {get; set;}
  public double FineAmountDue {get; set;}
  
/*One constructor that takes first name, last name and id
o	(Hint) Any time you inherit, call the base class constructor*/
  public Patron(string fname, string lname, string LibraryId) : base(fname, lname) {
    //Set FineAmountDue to 0
    this.FineAmountDue = 0.0;
    this.LibraryId = LibraryId;
    //Set StartDate to Today’s date
    this.StartDate = DateTime.Today;
    //Set IsAccountActive to true
    this.IsAccountActive = true;
  }
  /*Method does not take any parameter
	Method does not return any value
	Displays a message (See example below)
Patron Id=1111 Name=Tim Smith*/
  public void Display() {
    Console.WriteLine($"Patron Id= {LibraryId} Name= {FirstName}{LastName}");
  }
/*AddToRentalCart
o	Method takes a book object and due date as input
o	Method does not return a value
o	Creates a new Rental object for the Book (input) and adds to the RentalCart list.
o	Method also displays a message (see example below)
Added to rental cart Harry Potter Book 1 for Patron TimSmith*/
  public void AddToRentalCart(Book Book, DateTime DateDue) {
    Rental Rental = new Rental(Book, DateTime.Today, DateTime.Today);
    RentalCart.Add(Rental);
    Console.WriteLine($"Added to rental cart {Book.Title} Book {Book.ISBN} for Patron {FirstName}{LastName}");
  }
  /*RemoveFromRentalCart
o	Method takes a book object as input
o	Method does not return a value
o	Method also displays a message (see example below)
Removed from rental cart Harry Potter Book 2 for Patron TimSmith*/
  public void RemoveFromRentalCart(Book Book) {
    Rental Rental = new Rental(Book, DateTime.Today, DateTime.Today);
    RentalCart.Remove(Rental);
    Console.WriteLine($"Removed from rental cart {Book.Title} Book {Book.ISBN} for Patron {FirstName}{LastName}");
  }
}