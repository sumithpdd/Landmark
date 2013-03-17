using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Navigation;
using System.Windows.Threading;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Landmark.Dev4Good.WP
{
    public partial class MainPage : PhoneApplicationPage
    {
        private DispatcherTimer _dispatcherTimer;
        private Popup _popup;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            ShowSplash();
            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
        }
        private void ShowSplash()
        {
           
            _popup = new Popup { Child = new SplashScreenControl(), IsOpen = true };
            _dispatcherTimer = new DispatcherTimer { Interval = new TimeSpan(0, 0, 2) };
            _dispatcherTimer.Tick += CheckTicks;
            _dispatcherTimer.Start();
        }

        private void CheckTicks(object sender, EventArgs e)
        {
            if (!App.IsDatabaseLoaded) return;
            App.ViewModel.LoadData();
            _popup.IsOpen = false;
            
            _dispatcherTimer.Stop();
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