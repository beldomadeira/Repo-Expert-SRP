using System;

namespace Ucu.Poo.Expert
{
    public class Book
    {

        public string Title { get; }
        public string Author { get; }
        public string Code { get; }
        public string LibrarySector { get; set; }   //esto no
        public string LibraryShelve { get; set; }   //esto tampoco

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
        /* 
        Hasta esta línea considero que se cumple el principio SRP, el cambio que le aplicaría sería colocar la información que sigue sobre
        la ubicación del libro en una clase BookLocation por ejemplo y que esta se encargue de conocer la misma. 
        */
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

    }
}
