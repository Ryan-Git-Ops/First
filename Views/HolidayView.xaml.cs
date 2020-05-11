using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ShoppingCartApp.ViewModels;
using RestSharp;
using Newtonsoft.Json;
using ShoppingCartApp.Models;

namespace ShoppingCartApp.Views
{
    /// <summary>
    /// Interaction logic for Api.xaml
    /// </summary>
    public partial class HolidayView : Window
    {
       
        public HolidayView()
        {
            InitializeComponent();

        }

        private async void  Button_Click(object sender, RoutedEventArgs e)
        {

            string country = Country.Text;
            int year = Convert.ToInt32(Year.Text);
             await LoadHoliday(country, year);
            
        }


       public async Task LoadHoliday(string country, int year)
        {
            
           var holidays = await HolidayViewModel.GetHoliday(country, year);


            HolidayBox.ItemsSource = holidays.ToString();

            
            
        }
    }

}
//IRestClient restClient = new RestClient();
//IRestRequest restRequest = new RestRequest($"https://calendarific.com/api/v2/holidays?api_key=83e943dbd01aa32c61f09e337f3ddca107a12c38&country={country}&year={year}");
//restRequest.AddHeader("Accept", "application/json");
////var request = new RestRequest($"holidays?api_key=83e943dbd01aa32c61f09e337f3ddca107a12c38&country={country}&year={year}");
//IRestResponse<HolidayModel> restResponse = restClient.Get<HolidayModel>(restRequest);

//Holiday.ItemsSource = restResponse.Content;
//var queryResult = client.Execute(request);
//var JHoliday = JsonConvert.DeserializeObject<HolidayView>(queryResult);

//Result.Text = queryResult.Content;
//string country = Country.Text;
//int year = Convert.ToInt32(Year.Text);

//await GetHoliday(country, year);