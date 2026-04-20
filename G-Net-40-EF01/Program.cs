using G_Net_40_EF01.Book_Store_Core;

namespace G_Net_40_EF01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new BookStoreDbContext();
            Console.WriteLine("Database Created Successfully!");
        }
    }
}
