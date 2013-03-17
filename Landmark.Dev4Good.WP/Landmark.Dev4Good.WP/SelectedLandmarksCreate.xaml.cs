using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Landmark.Dev4Good.WP.ViewModels;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Landmark.Dev4Good.WP
{
    public partial class SelectedLandmarksCreate : PhoneApplicationPage
    {
        
        public SelectedLandmarksCreate()
        {
            InitializeComponent();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
           
            DataContext = App.ViewModel.LoadAvailableLandmarks(); 

        }
      

        //private void SelectedLandmarkList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}y6
      

        private void SelectedLandmarkList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(
               new Uri("/CreateQuestion.xaml",UriKind.Relative));
        }
    }
}