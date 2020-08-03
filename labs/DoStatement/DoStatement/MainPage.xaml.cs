﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DoStatement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void showStepsClick(object sender, RoutedEventArgs e)
        {
            int amount = int.Parse(number.Text);
            steps.Text = "";
            string current = "";
            calcOctol(amount);

            //do
            //{
            //    int nextDigit = amount % 8;
            //    amount = amount / 8;
            //    int digitCode = '0' + nextDigit;
            //    //int digitCode = 48 + nextDigit;
            //    char digit = Convert.ToChar(digitCode);
            //    current = digit + current;
            //    steps.Text += current + "\n";
            //}
            //while (amount != 0);
        }

        private void calcOctol(int amount)
        {
            int remainder = 0;
            int place = 1;
            int result = 0;
            while(amount > 0)
            {
                remainder = amount % 8;
                remainder *= place;
                place *= 10;
                result += remainder;
                steps.Text += result.ToString() + "\n";
                amount /= 8;
            }
        }
    }
}
