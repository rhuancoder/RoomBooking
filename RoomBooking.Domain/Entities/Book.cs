using RoomBooking.Domain.Enums;
using System;
using System.Collections.Generic;

namespace RoomBooking.Domain.Entities
{
    public class Book
    {

        public Book(Room room, DateTime startTime, DateTime endTime)
        {
            this.Id = Guid.NewGuid();
            this.Room = room;
            this.Status = EBookStatus.InProgress;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        public Guid Id { get; private set; }
        public Room Room { get; private set; }
        public EBookStatus Status { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        public void Confirm(IList<DateTime> holidays, IList<DateTime> booksForThisPeriod)
        {
            // Verificar se data inicio está na lista de feriados
            // Verificar se data inicio está na lista de reservas

            if (this.Status != EBookStatus.InProgress)
                throw new Exception("Error");

            this.Status = EBookStatus.Reserved;
        }

        public void MarkAsInProgress()
        {
            this.Status = EBookStatus.InUse;
        }

        public void Cancel()
        {
            if ((this.StartTime - DateTime.Now).Hours < 2)
                throw new Exception("Error");

            this.Status = EBookStatus.Canceled;
        }

        public void MarkAsCompleted()
        {
            this.Status = EBookStatus.Completed;
        }
    }
}
