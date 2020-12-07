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
        public static async void PostBooking(Response responseObj) {
            var json = JsonConvert.SerializeObject(new object());
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "";

            using var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            string result = response.Content.ReadAsStringAsync().Result;

            responseObj.PostSucceded = true;
        }
    }
}
