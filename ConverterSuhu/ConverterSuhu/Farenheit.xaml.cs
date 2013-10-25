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
    public partial class Farenheit : PhoneApplicationPage
    {
        public Farenheit()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            celciusText.Text = (((double.Parse(farenheitText.Text) - 32.0) / 9.0) * 5.0).ToString();
            reamurText.Text = ((double.Parse(celciusText.Text) / 5.0) * 4.0).ToString();
            kelvinText.Text = (double.Parse(celciusText.Text) + 274.15).ToString();
        }
    }
}