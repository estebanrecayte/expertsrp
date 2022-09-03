using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034",new Location("A2","20"));
            Console.Write(book1);
            

        }
    }
}