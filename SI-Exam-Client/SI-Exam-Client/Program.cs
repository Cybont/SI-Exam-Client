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

            bool hasPostedBooking = response.Succeded;

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
            Response response = new Response();

            Requests.DeleteBooking(response);

            bool hasDeletedBooking = response.Succeded;
            
            if (hasDeletedBooking) 
            {
                Console.WriteLine("Booking has been deleted!");
            }
            else
            {
                Console.WriteLine("This booking doesn't exist in our system!");
            }
        }

        public static void FindBooking() 
        {
            Response response = new Response();

            Requests.GetBooking(response);

            if (response.Text != null)
            {
                Console.WriteLine(response.Text);
            }
            else
            {
                Console.WriteLine("This booking doesn't exist in our system!");
            }
        }

        #endregion

        #region Hotel requests
        public static void FindVacantHotels()
        {
            Response response = new Response();

            Requests.GetVacantHotels(response);

            if (response.Text != null)
            {
                Console.WriteLine(response.Text);
            }
            else
            {
                Console.WriteLine("Couldn't find any vacant hotels in our system!");
            }
        }
        #endregion

        #region Room requests
        public static void FindVacantRooms() 
        {
            Response response = new Response();

            Requests.GetVacantRooms(response);

            if (response.Text != null)
            {
                Console.WriteLine(response.Text);
            }
            else
            {
                Console.WriteLine("Couldn't find any vacant rooms in our system!");
            }
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
