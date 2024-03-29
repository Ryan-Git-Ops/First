﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ShoppingCartApp.ViewModels;


namespace ShoppingCartApp.Views
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : Window
    {
        public ShellView()
        {
            InitializeComponent();
            
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {

            ShellViewModel data = new ShellViewModel();
            Data.Visibility = Visibility.Visible;
            Data.Text = data.GetData(); 

        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            var Holiday = new HolidayView();
            Holiday.Show();
        }
    }
}
