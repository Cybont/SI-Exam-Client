using SI_Exam_Client.Classes;
using System;
using System.Collections.Generic;

namespace SI_Exam_Client
{
    class Program
    {
        #region Booking requests
        public static void CreateBooking()
        {
            CreateBookingDTO createBooking = new CreateBookingDTO(
                new List<string>{ "323M" }, "123cjohn3", 5, DateTime.Parse("2020-12-12"), DateTime.Parse("2021-07-01"), false);

            Response response = new Response();

            Requests.PostBooking(response, createBooking);

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

            Requests.DeleteBooking(response, 0);

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

            Requests.GetBooking(response, 0);

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
