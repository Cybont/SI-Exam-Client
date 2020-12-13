using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SI_Exam_Client.Classes
{
    public class CreateBookingDTO
    {
        private List<string> roomNumbers;
        private string passportNumber;
        private int numberOfGuests;
        private DateTime arrival;
        private DateTime departure;
        private bool lateArrival;

        public CreateBookingDTO(List<string> roomNumbers, string passportNumber, int numberOfGuests, DateTime arrival, DateTime departure, bool lateArrival)
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

        [JsonProperty("roomNumbers")]
        public List<string> RoomNumbers => roomNumbers;

        [JsonProperty("passportNumber")]
        public string PassportNumber => passportNumber;

        [JsonProperty("numberOfGuests")]
        public int NumberOfGuests => numberOfGuests;
        [JsonProperty("arrival")]
        public DateTime Arrival => arrival;

        [JsonProperty("departure")]
        public DateTime Departure => departure;

        [JsonProperty("lateArrival")]
        public bool isLateArrival => lateArrival;


    }
}
