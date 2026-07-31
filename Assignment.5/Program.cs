namespace Assignment._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            ///*Add a private string password ="secret";field to a Book class.
            // try to print it from Main(outside the class).What happend and why?*/
            //Book book = new Book();
            ////Console.WriteLine(book.password);
            ///*It is a compile-time error because the private field is only accessable in 
            // the same class.*/
            #endregion
            #region Question02
            ///*Add an internal int copiesInStock=5;field to Book.Print it from Main.
            // Does it compile?why?*/
            //Console.WriteLine(book.copiesInStock);
            ///*Yes,it compiles,because the internal field is accessable in the whole same project.*/
            #endregion
            #region Question03
            ///*Add a public string title; field to Book.Set it from Main.*/
            //book.title = "Clean Code";
            //Console.WriteLine(book.title);
            #endregion
            #region Question04
            ///*Declare an enum Genre {Fiction,NonFiction,Science}.Add a Genre property to Book.
            // assign it Genre.Science, and print it.*/
            //book.Genre = Genre.Science;
            //Console.WriteLine(book.Genre); 
            #endregion
        }
    }
}
