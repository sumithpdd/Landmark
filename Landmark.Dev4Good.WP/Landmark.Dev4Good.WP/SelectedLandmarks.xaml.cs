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
    public partial class SelectedLandmarks : PhoneApplicationPage
    {
        private SelectedLandmarksViewModel _viewModel = null;

        /// <summary>
        /// A static ViewModel used by the views to bind against.
        /// </summary>
        /// <returns>The SelectedLandmarksViewModel object.</returns>
        public SelectedLandmarksViewModel ViewModel
        {
            get
            {
                // Delay creation of the view model until necessary
                return _viewModel ?? (_viewModel = new SelectedLandmarksViewModel());
            }
        }
        public SelectedLandmarks()
        {
            InitializeComponent();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            ViewModel.LoadData();
            DataContext = ViewModel; 

        }
      

        //private void SelectedLandmarkList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
      

        private void SelectedLandmarkList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(
               new Uri(
                   "/QuizPage.xaml",
                   UriKind.Relative));
        }
    }
}