using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Landmark.Dev4Good.WP
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void CreateGame_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                 new Uri(
                     "/MapView.xaml",
                     UriKind.Relative));
           
        }

        private void CurrentGameList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(
               new Uri(
                   "/SelectedLandmarks.xaml",
                   UriKind.Relative));
        }
    }
}