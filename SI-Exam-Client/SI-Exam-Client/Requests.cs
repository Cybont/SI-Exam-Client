using Newtonsoft.Json;
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
        public static async void PostBooking(Response responseObj) {
            var json = JsonConvert.SerializeObject(new object());
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "";

            using var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            string result = response.Content.ReadAsStringAsync().Result;

            responseObj.Succeded = true;
        }

        public static async void DeleteBooking(Response response)
        {
            var url = "";

            using var client = new HttpClient();

            string result = (await client.DeleteAsync(url)).Content.ReadAsStringAsync().Result;

            response.Succeded = true;
        }

        public static async void GetBooking(Response response) 
        {
            var url = "";

            using var client = new HttpClient();

            string result = (await client.GetAsync(url)).Content.ReadAsStringAsync().Result;

            response.Text = result;
        }
        #endregion

        public static async void GetVacantHotels(Response response) 
        {
            var url = "";

            using var client = new HttpClient();

            string result = (await client.GetAsync(url)).Content.ReadAsStringAsync().Result;

            response.Text = result;
        }

        public static async void GetVacantRooms(Response response)
        {
            var url = "";

            using var client = new HttpClient();

            string result = (await client.GetAsync(url)).Content.ReadAsStringAsync().Result;

            response.Text = result;
        }
    }
}
