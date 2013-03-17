using System;
using System.Windows.Controls;
using Microsoft.Phone.Controls;

namespace Landmark.Dev4Good.WP
{
	public partial class CreateQuestion : PhoneApplicationPage
	{
        public CreateQuestion()
		{
			InitializeComponent();
	 	}

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/SelectedLandmarksCreate.xaml", UriKind.Relative));
        }

	 
	}
}