using System;

namespace SI_Exam_Client
{
    class Program
    {
        #region Booking requests
        public static void CreateBooking()
        {
            Response response = new Response();

            Requests.PostBooking(response);

            bool hasPostedBooking = response.PostSucceded;

            if (hasPostedBooking)
            {
                Console.WriteLine("Booking has been created!");
            }
            else {
                Console.WriteLine(
                    "Booking request failed, you may receive a phone call shortly if we feel that we can help you book your room(s)"
                    );
            }
        }

        public static void CancelBooking() 
        { 
        }

        public static void FindBooking() 
        { 
        }

        #endregion

        #region Hotel requests
        public static void FindVacantHotels()
        {

        }
        #endregion

        #region Room requests
        public static void FindVacantRooms() 
        {

        }

        public static void MarkRoomAsReserved() 
        { 

        }
        #endregion

        #region Log resquest
        public static void GetLogs() 
        { 

        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CreateBooking();
        }
    }
}
