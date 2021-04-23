using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIS_Assignment4_Spring2021.Models
{
        public class Covid_Conditions
        {
        public int Id { get; set; }
        public List<Covid_Condition> data { get; set; }
        }

        public class Covid_Condition
        {
            public int Id { get; set; }
            public DateTime data_as_of { get; set; }
            public DateTime start_date { get; set; }
            public DateTime end_date { get; set; }
            public string group { get; set; }
            public string state { get; set; }
            public string condition_group { get; set; }
            public string condition { get; set; }
            public string icd10_codes { get; set; }
            public string age_group { get; set; }
            public string covid_19_deaths { get; set; }
            public string number_of_mentions { get; set; }
            public string flag { get; set; }
            public Covid_Conditions covid_conditions { get; set; }
        }
 }

