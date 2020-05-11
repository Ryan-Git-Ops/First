using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Models
{

    public class HolidayModel
    {
        public class Response
        {
            public List<Holidays> holidays;
        }

        public class Holidays
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public List<Country> Country { get; set; }
            public List<Date> Date { get; set; }
            public List<string> Type { get; set; }
        }

        public class Country
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        public class Date
        {
            public Date Iso { get; set; }
        }

    }
}






