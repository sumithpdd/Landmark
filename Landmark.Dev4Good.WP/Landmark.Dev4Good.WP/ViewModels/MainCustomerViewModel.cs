using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Landmark.Dev4Good.WP.Classes;
using Landmark.Dev4Good.WP.Models;
using Landmark.Dev4Good.WP.Resources;

namespace Landmark.Dev4Good.WP.ViewModels
{
    public class MainCustomerViewModel : BaseViewModel
    {
        public MainCustomerViewModel()
        {
            this.Games = new ObservableCollection<Game>();
        }

        private string _customerName;

        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                if (value != _customerName)
                {
                    _customerName = value;
                    NotifyPropertyChanged("CustomerName");
                }
            }
        }

        /// <summary>
        /// A collection for Games objects.
        /// </summary>
        public ObservableCollection<Game> _games;

        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<Game> Games
        {
            get { return _games; }
            set
            {
                if (value != _games)
                {
                    _games = value;
                    NotifyPropertyChanged("Games");
                }
            }
        }

        private int _pointsAchieved;

        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public int PointsAchieved
        {
            get { return _pointsAchieved; }
            set
            {
                if (value != _pointsAchieved)
                {
                    _pointsAchieved = value;
                    NotifyPropertyChanged("PointsAchieved");
                }
            }
        }
        


        private bool _isDatabaseLoaded = false;

        public bool IsDatabaseLoaded
        {
            get { return _isDatabaseLoaded; }
            set
            {
                _isDatabaseLoaded = value;
                NotifyPropertyChanged("IsDatabaseLoaded");

            }
        }
      

       
        /// <summary>
        /// Sample property that returns a localized string
        /// </summary>
        public string LocalizedSampleProperty
        {
            get { return AppResources.SampleProperty; }
        }

        public bool IsDataLoaded { get; private set; }

        /// <summary>
        /// Loads the data from our "database" and populates the
        /// Items and Favorites properties
        /// </summary>
        public void LoadDatabaseData()
        {
            DbContext db = App.Db;


            if (db.DatabaseExists() == false)
            {
                Debug.WriteLine("Initializing Database from web");
                // Create the local database.
                db.CreateDatabase();
                LoadDataBaseFromWeb();
            }
            else
            {
                Debug.WriteLine("Database already exists");
                LoadDataBaseFromWeb();

                this.IsDatabaseLoaded = true;

            }
        }

        private void LoadDataBaseFromWeb()
        {

            var webClient = new WebClient();

            this.CustomerName = "Sumith";
            this.PointsAchieved = 30;
             this.Games.Clear();
            this.Games.Add(new Game(){ GameId = 1,GameName = "South Kensington", CompletedPercent = 20});
            this.Games.Add(new Game() { GameId = 2, GameName = "London Walking Trail", CompletedPercent = 75 });
            this.Games.Add(new Game() { GameId = 3, GameName = "Trip to Lake district", CompletedPercent = 40 });
            this.Games.Add(new Game() { GameId = 4, GameName = "A Great Day at dev4good", CompletedPercent = 95 });
        }

     

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            // Sample data; replace with real data
            LoadDataBaseFromWeb();
            this.IsDataLoaded = true;
        }

        public ObservableCollection<CustomerLandmarks> LoadAvailableLandmarks()
        {
            ObservableCollection<CustomerLandmarks> availalelandmarks = new ObservableCollection<CustomerLandmarks>();
            availalelandmarks.Add(new CustomerLandmarks() { LandmarkId = 1, LandmarkName = "Natural History Museum", IsSelected = false });
            availalelandmarks.Add(new CustomerLandmarks() { LandmarkId = 2, LandmarkName = "Science Museum", IsSelected = false });
            availalelandmarks.Add(new CustomerLandmarks() { LandmarkId = 3, LandmarkName = "The Royal Marsden", IsSelected = false });
            availalelandmarks.Add(new CustomerLandmarks() { LandmarkId = 4, LandmarkName = "Victoria and Albert Museum", IsSelected = false });
            availalelandmarks.Add(new CustomerLandmarks() { LandmarkId = 5, LandmarkName = "The National Army Museum", IsSelected = false });
            return availalelandmarks;

        }
    }

}