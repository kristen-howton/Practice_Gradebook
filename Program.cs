//need namespace to not conflict with MS
namespace Gradebook
{

    class Program
    {
        static void Main(string[] args)
        {

            //used to instantiate a class, contructor method
            var book = new Book("Gradebook");
            book.AddGrade(90.1);
            book.AddGrade(80.4);
            book.ShowStatistics();

        }

    }

}