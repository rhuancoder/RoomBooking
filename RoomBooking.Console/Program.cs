using RoomBooking.Console.Repositories;
using RoomBooking.Console.Services;
using RoomBooking.Domain.Contracts.Repositories;
using RoomBooking.Domain.Contracts.Services;
using RoomBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using Unity;
using Unity.Lifetime;

namespace RoomBooking.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //var container = new UnityContainer();

            //container.RegisterType<IBookRepository, BookRepository>(new HierarchicalLifetimeManager());
            //container.RegisterType<IBookService, BookService>(new HierarchicalLifetimeManager());

            //var bookRepository = container.Resolve<IBookRepository>();
            //var bookService = container.Resolve<IBookService>();

            //var room = new Room(DateTime.Now, DateTime.Now.AddHours(8), "Sala 1");

            //bookService.PlaceBook(DateTime.Now.AddHours(2), DateTime.Now.AddHours(3), room.Id);

            var room = new Room(DateTime.Now.AddHours(2), DateTime.Now.AddHours(8), "Sala 1");
            System.Console.WriteLine("Criando uma sala");

            var book = new Book(room, DateTime.Now.AddHours(4), DateTime.Now.AddHours(5));
            System.Console.WriteLine("Iniciando uma reserva");

            book.Confirm(new List<DateTime>(), new List<DateTime>());
            System.Console.WriteLine("Status da reserva: " + book.Status);

            book.MarkAsInProgress();
            System.Console.WriteLine("Status da reserva: " + book.Status);

            book.MarkAsCompleted();
            System.Console.WriteLine("Status da reserva: " + book.Status);

            System.Console.Read();
        }
    }
}
