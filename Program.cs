// Jeremy Gallen's sample program to demonstrate exceptions

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare array of fantasy authors
            string[] authors = { "J.K. Rowling", "Terry Goodkind", "Robert Jordan", "Anne McCaffrey", "Terry Brooks" };

            // Output authors
            for(int i = 0; i < authors.Length; i++)
            {
                Console.WriteLine(authors[i]);
            }

            // Attempt to print value out of array range
            try
            {
                Console.WriteLine(authors[7]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("An exception has occurred: {0}", e.Message);
            }
        }
    }
}