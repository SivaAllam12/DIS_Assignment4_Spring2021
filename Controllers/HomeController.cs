using DIS_Assignment4_Spring2021.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DIS_Assignment4_Spring2021.Controllers
{
    public class HomeController : Controller
    {
        static string api_link = "https://data.cdc.gov/resource/hk9y-quqm.json?$limit=2&state=Florida";

        HttpClient httpclient = new HttpClient();

        Covid_Conditions covid_conditions = new Covid_Conditions();
        public IActionResult Data()
        {
            httpclient.BaseAddress = new Uri(api_link);

            HttpResponseMessage response = httpclient.GetAsync(api_link).GetAwaiter().GetResult();

            string covidData = null;

            //var responseTask = httpclient.GetAsync(api_link);
            //responseTask.Wait();
            //var result = responseTask.Result;
            if (response.IsSuccessStatusCode)
            {
                covidData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            }
            if (!covidData.Equals(""))
            {
                // JsonConvert is part of the NewtonSoft.Json Nuget package
                covid_conditions.data = JsonConvert.DeserializeObject<List<Covid_Condition>>(covidData);
            }
            return View(covid_conditions);
        }
    }
}




