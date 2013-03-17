using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Landmark.Dev4Good.WP.Models
{
    public class CustomerLandmarks : INotifyPropertyChanged
    {
        private int _landmarkId;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public int LandmarkId
        {
            get { return _landmarkId; }
            set
            {
                if (value != _landmarkId)
                {
                    _landmarkId = value;
                    NotifyPropertyChanged("LandmarkID");
                }
            }
        }

        private string _landmarkName;

        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string LandmarkName
        {
            get { return _landmarkName; }
            set
            {
                if (value != _landmarkName)
                {
                    _landmarkName = value;
                    NotifyPropertyChanged("LandmarkName");
                }
            }
        }

        private double _latitude;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public double Latitude
        {
            get { return _latitude; }
            set
            {
                if (value != _latitude)
                {
                    _latitude = value;
                    NotifyPropertyChanged("Latitude");
                }
            }
        }
        private double _longitude;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public double Longitude
        {
            get { return _longitude; }
            set
            {
                if (value != _longitude)
                {
                    _longitude = value;
                    NotifyPropertyChanged("Longitude");
                }
            }
        }

        private bool _isSelected;

        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (value != _isSelected)
                {
                    _isSelected = value;
                    NotifyPropertyChanged("IsSelected");
                }
            }
        }
        private bool _hasQuestion;

        public bool HasQuestion
        {
            get { return _hasQuestion; }
            set
            {
                if (value != _hasQuestion)
                {
                    _hasQuestion = value;
                    NotifyPropertyChanged("HasQuestion");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
