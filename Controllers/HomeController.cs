using DIS_Assignment4_Spring2021.DataAccess;
using DIS_Assignment4_Spring2021.Domain;
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
        public ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        static string api_link = "https://data.cdc.gov/resource/hk9y-quqm.json";
        //static string api_link = "https://data.cdc.gov/resource/hk9y-quqm.json?$limit=2&state=Florida";

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

            //add the data to db
            DbDomain d = new DbDomain(_context);
            d.covidConditionPost(covid_conditions);

            //READ Operation
            //var cov1 = d._context.Covid_Conditions_data.Select(element => new
            //{
            //    data = element.condition_group
            //});
           

            //var results = from p in d._context.Covid_Conditions_data
            //              group p by p.condition_group into g
            //              select new { condition_group = g.Key, covid_19_deaths = g.Sum(c => Convert.ToInt64(c.covid_19_deaths))};

            //List<Covid_Condition> cov1 = d._context.Covid_Conditions_data.GroupBy(p => p.condition_group).Select(c1=>new 
            //Covid_Condition
            //{
            //    condition_group = c1.First().condition_group,
            //    covid_19_deaths = c1.Sum().ToString(),
            //});
            //}

            return View(d._context.Covid_Conditions_data.ToList());
        }
    }
}




