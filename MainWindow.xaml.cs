﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, int> drinks = new Dictionary<string, int>
        {
            {" 紅茶大杯", 60},
            {" 紅茶小杯", 40},
            {" 綠茶大杯", 60},
            {" 綠茶小杯", 40},
            {" 可樂大杯", 50},
            {" 可樂小杯", 30}
        };
        public MainWindow()
        {
            InitializeComponent();

            DisplayDrinkMenu(drinks);
        }

        private void DisplayDrinkMenu(Dictionary<string, int> drinks)
        {
            foreach (var drink in drinks)
            {
                var sp = new StackPanel
                {
                    Orientation = Orientation.Horizontal,
                    Margin = new Thickness(3),
                    Height = 40,
                    VerticalAlignment = VerticalAlignment.Center,
                    Background = Brushes.AliceBlue
                };

                var cb = new CheckBox
                {
                    Content = $"{drink.Key} {drink.Value}元",
                    FontFamily = new FontFamily("微軟正黑體"),
                    FontSize = 18,
                    Foreground = Brushes.Blue,
                    Margin = new Thickness(10, 0, 50, 0),
                    VerticalAlignment = VerticalAlignment.Center
                };

                var sl = new Slider
                {
                    Width = 150,
                    Value = 0,
                    Minimum = 0,
                    Maximum = 10,
                    IsSnapToTickEnabled = true,
                    VerticalAlignment = VerticalAlignment.Center
                };

                var tb = new Label
                {
                    Width = 30,
                    Content = "0",
                    FontFamily = new FontFamily("微軟正黑體"),
                    FontSize=18,
                };

                sp.Children.Add(cb);
                sp.Children.Add(sl);

                stackpanel_DrinkMenu.Children.Add(sp);
            }
        }
    }
}