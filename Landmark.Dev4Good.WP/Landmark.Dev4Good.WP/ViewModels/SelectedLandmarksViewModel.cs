using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Landmark.Dev4Good.WP.Annotations;
using Landmark.Dev4Good.WP.Models;

namespace Landmark.Dev4Good.WP.ViewModels
{
    public class SelectedLandmarksViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<CustomerLandmarks> _customerLandmarks;


         public SelectedLandmarksViewModel()
        {
            this.SelectedCustomerLandmarks = new ObservableCollection<CustomerLandmarks>();

        }
        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<CustomerLandmarks> SelectedCustomerLandmarks
        {
            get { return _customerLandmarks; }
            private set
            {
                if (value != _customerLandmarks)
                {
                    _customerLandmarks = value;
                    NotifyPropertyChanged("SelectedCustomerLandmarks");
                }
            }
        }
         public void LoadData()

        {
             SelectedCustomerLandmarks.Add(new CustomerLandmarks(){LandmarkId=1, LandmarkName="kensington palace", IsSelected = false});
             SelectedCustomerLandmarks.Add(new CustomerLandmarks() { LandmarkId = 2, LandmarkName = "kensington palace 2", IsSelected = false });
             SelectedCustomerLandmarks.Add(new CustomerLandmarks() { LandmarkId = 3, LandmarkName = "kensington palace 3", IsSelected = false });
             SelectedCustomerLandmarks.Add(new CustomerLandmarks() { LandmarkId = 4, LandmarkName = "kensington palace 4", IsSelected = false });
            
        }
         public event PropertyChangedEventHandler PropertyChanged;
         public void NotifyPropertyChanged(String propertyName)
         {
             PropertyChangedEventHandler handler = PropertyChanged;
             if (null != handler)
             {
                 handler(this, new PropertyChangedEventArgs(propertyName));
             }
         }
    }
}
