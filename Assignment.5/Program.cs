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
        }
    }
}
