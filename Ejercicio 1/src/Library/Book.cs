using System;

namespace SRP
{
    public class Book
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public string Code { get; set; }

        public Location Location { get; }

        public Book(String title, String author, String code, Location location)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
            this.Location = location;

        }


    }

    /* El metodo de la ubicacion del libro no tiene que estar en la clase book,
    por el concepto de SRP*/



}

