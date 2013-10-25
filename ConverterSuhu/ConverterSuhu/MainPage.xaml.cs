using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace ConverterSuhu
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void celciusButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Celcius.xaml", UriKind.Relative));
        }

        private void reamurButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Reamur.xaml", UriKind.Relative));
        }

        private void farenheitButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Farenheit.xaml", UriKind.Relative));
        }

        private void kelvinButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Kelvin.xaml", UriKind.Relative));
        }

        private void keluarButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}