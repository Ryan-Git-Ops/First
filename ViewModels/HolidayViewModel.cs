using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCartApp.Models;
using Caliburn.Micro;


namespace ShoppingCartApp.ViewModels
{
    public class HolidayViewModel
    {




        public static async Task<HolidayModel> GetHoliday(string country, int year)
        {
            string thiscountry = country;
            int thisyear = year;

           
            var holiday = await ApiProcessor.LoadHoliday(country, year);

            return holiday;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Type { get; set; }

        //private int _year;
        //private string _country;


        //public int Year
        //{
        //    get { return _year; }
        //    set { _year = value; }
        //}

        //public string Country
        //{
        //    get { return _country; }
        //    set
        //    {
        //        _country = value;


        //    }
        //}


    } 
}





