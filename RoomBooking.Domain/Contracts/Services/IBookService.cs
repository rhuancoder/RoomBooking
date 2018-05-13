using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Domain.Contracts.Services
{
    public interface IBookService : IDisposable
    {
        void PlaceBook(DateTime startDate, DateTime endDate, Guid room);
    }
}
