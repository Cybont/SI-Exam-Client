using System;
using System.Collections.Generic;
using System.Text;

namespace SI_Exam_Client.Classes
{
    public class CreateBookingDTO
    {
        private List<string> roomNumbers;
        private String passportNumber;
        private int numberOfGuests;
        private DateTime arrival;
        private DateTime departure;
        private bool lateArrival;

        public CreateBookingDTO(List<string> roomNumbers, String passportNumber, int numberOfGuests, DateTime arrival, DateTime departure, bool lateArrival)
        {
            this.roomNumbers = roomNumbers;
            this.passportNumber = passportNumber;
            this.numberOfGuests = numberOfGuests;
            this.arrival = arrival;
            this.departure = departure;
            this.lateArrival = lateArrival;
        }

        public CreateBookingDTO()
        {
        }

        public List<string> RoomNumbers => roomNumbers;

        public String PassportNumber => passportNumber;


        public int NumberOfGuests => numberOfGuests;

        public DateTime Arrival => arrival;


        public DateTime Departure => departure;


        public bool isLateArrival => lateArrival;


    }
}
