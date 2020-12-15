using Newtonsoft.Json;
using SI_Exam_Client.Classes;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static SI_Exam_Client.Program;

namespace SI_Exam_Client
{
    public static class Requests
    {
        #region Booking
        public static void PostBooking(Response responseObj, CreateBookingDTO createBooking)
        {
            var json = JsonConvert.SerializeObject(createBooking);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "http://localhost:9090/booking";

            using var client = new HttpClient();

            var response = client.PostAsync(url, data).Result;

            string result = response.Content.ReadAsStringAsync().Result;

            if (result == "false")
            {
                responseObj.Succeded = false;
            }
            else
            {
                responseObj.Succeded = true;
            }
        }

        public static void DeleteBooking(Response responseObj, int id)
        {
            var url = "http://localhost:9090/booking/" + id;

            using var client = new HttpClient();

            string result = (client.DeleteAsync(url).Result).Content.ReadAsStringAsync().Result;

            if (result == "false")
            {
                responseObj.Succeded = false;
            }
            else
            {
                responseObj.Succeded = true;
            }
        }

        public static void GetBooking(Response responseObj, int id) 
        {
            var url = "http://localhost:9090/booking/" + id;

            using var client = new HttpClient();

            string result = (client.GetAsync(url).Result).Content.ReadAsStringAsync().Result;

            responseObj.Text = result;
        }
        #endregion

        public static void GetVacantHotels(Response responseObj) 
        {
            var url = "http://localhost:9090/hotels";

            using var client = new HttpClient();

            string result = (client.GetAsync(url).Result).Content.ReadAsStringAsync().Result;

            responseObj.Text = result;
        }

        public static void GetVacantRooms(Response responseObj)
        {
            var url = "http://localhost:9090/rooms";

            using var client = new HttpClient();

            string result = (client.GetAsync(url).Result).Content.ReadAsStringAsync().Result;

            responseObj.Text = result;
        }
    }
}
