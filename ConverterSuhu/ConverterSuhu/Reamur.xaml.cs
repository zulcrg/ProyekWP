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
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            celciusText.Text = ((double.Parse(reamurText.Text) / 4.0) * 5.0).ToString();
            farenheitText.Text = (((double.Parse(reamurText.Text) / 4.0) * 9.0) + 32.0).ToString();
            kelvinText.Text = (double.Parse(celciusText.Text) + 274.15).ToString();
        }
    }
}