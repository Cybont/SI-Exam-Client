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

        public List<string> getRoomNumbers()
        {
            return roomNumbers;
        }

        public void setRoomNumbers(List<string> roomNumbers)
        {
            this.roomNumbers = roomNumbers;
        }

        public String getPassportNumber()
        {
            return passportNumber;
        }

        public void setPassportNumber(String passportNumber)
        {
            this.passportNumber = passportNumber;
        }

        public int getNumberOfGuests()
        {
            return numberOfGuests;
        }

        public void setNumberOfGuests(int numberOfGuests)
        {
            this.numberOfGuests = numberOfGuests;
        }

        public DateTime getArrival()
        {
            return arrival;
        }

        public void setArrival(DateTime arrival)
        {
            this.arrival = arrival;
        }

        public DateTime getDeparture()
        {
            return departure;
        }

        public void setDeparture(DateTime departure)
        {
            this.departure = departure;
        }

        public bool isLateArrival()
        {
            return lateArrival;
        }

        public void setLateArrival(bool lateArrival)
        {
            this.lateArrival = lateArrival;
        }
    }
}
