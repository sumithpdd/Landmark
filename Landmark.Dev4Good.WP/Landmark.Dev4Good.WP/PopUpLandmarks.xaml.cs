using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Landmark.Dev4Good.WP
{
    public partial class PopUpLandmarks : UserControl
    {
        public PopUpLandmarks()
        {
            InitializeComponent();
         this.DataContext =   App.ViewModel.LoadAvailableLandmarks();
        }
        private void BtnDone_Click(object sender, RoutedEventArgs e)
        {
            ClosePopup();
        }

        private void ClosePopup()
        {
            var landmarkPop = this.Parent as Popup;
            if (landmarkPop != null) landmarkPop.IsOpen = false;
        }
    }
}
