using System;

namespace SI_Exam_Client
{
    class Program
    {
        public static void CreateBooking()
        {
            bool hasPostedBooking = Requests.PostBooking();

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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CreateBooking();
        }
    }
}
