//introoo Questions
#region Q01
//Requirements
//Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
//both title and upperTitle to show that title did not change.
//string title = "clean code";
//string upperTitle = title.ToUpper();
//Console.WriteLine(title);
//Console.WriteLine(upperTitle);
#endregion

#region Q02
//Requirements
//Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
//to check if they point to the same object in memory.
//string title01 = "Clean Code";
//string title02 = "Clean Code";
//Console.WriteLine(object.ReferenceEquals(title01, title02));
#endregion

#region Q03
//Requirements
//Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
//object.Print the final result.
//using System.Drawing;
//using System.Text;
//StringBuilder S1 = new StringBuilder();
//S1.Append("BookList");
//S1.Append(" - Updated");
//Console.WriteLine(S1);
#endregion

#region Q04
//Requirements
//Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".Print the result.
//S1.Replace("BookList","Library");
//Console.WriteLine(S1);
#endregion

#region Q05
//Requirements
//Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
//Pages: 464" using the + operator.
//int pages = 464;
//Console.WriteLine("Book:" + title + ", pages:" + pages);
#endregion

#region Q06
//Requirements
//Build the same sentence as above, but using string interpolation ($"...")
//Console.WriteLine($"Book: {title}, pages: {pages}");
#endregion

#region Q07
//Requirements
//Build the same sentence again, but using string.Format().
//Console.WriteLine("Book: {0}, pages: {1}",title,pages);
#endregion

#region Q08
//Requirements
//Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
//300, otherwise prints "Short Book".
//if(pages > 300)
//{
//    Console.WriteLine("logn Book");
//}
//else
//{
//    Console.WriteLine("short Book");
//}
#endregion

#region Q09
//Requirements
//Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
//greater than 300 and isAvailable is true. Use the && operator.
//bool isAvailable = true;
//if(pages > 300 && isAvailable == true)
//{
//    Console.WriteLine("You can borrow this book");
//}
//else
//{
//    Console.WriteLine("No can borrow this book");
//}
#endregion