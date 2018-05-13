using RoomBooking.Domain.Contracts.Services;
using RoomBooking.Domain.Entities;
using System;

namespace RoomBooking.Console.Services
{
    public class BookService : IBookService
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void PlaceBook(DateTime startDate, DateTime endDate, Guid room)
        {
            //var book = new Book(room, DateTime.Now.AddHours(1), DateTime.Now.AddHours(2));

            //book.Cancel();

            //bookRepository.Save(book);
            //throw new NotImplementedException();
        }
    }
}
