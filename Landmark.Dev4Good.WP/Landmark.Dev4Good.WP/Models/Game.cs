using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Landmark.Dev4Good.WP.Models
{
    public class Game : INotifyPropertyChanged
    {
        private int _gameId;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public int GameId
        {
            get { return _gameId; }
            set
            {
                if (value != _gameId)
                {
                    _gameId = value;
                    NotifyPropertyChanged("GameID");
                }
            }
        }
        private string _gameName;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string GameName
        {
            get { return _gameName; }
            set
            {
                if (value != _gameName)
                {
                    _gameName = value;
                    NotifyPropertyChanged("GameName");
                }
            }
        }

        private string _gameDescription;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string GameDescription
        {
            get { return _gameDescription; }
            set
            {
                if (value != _gameDescription)
                {
                    _gameDescription = value;
                    NotifyPropertyChanged("GameDescription");
                }
            }
        }

        private int _Points;


        public int Points
        {
            get { return _Points; }
            set
            {
                if (value != _Points)
                {
                    _Points = value;
                    NotifyPropertyChanged("Points");
                }
            }
        }
        private int _completedPercent;


        public int CompletedPercent
        {
            get { return _completedPercent; }
            set
            {
                if (value != _completedPercent)
                {
                    _completedPercent = value;
                    NotifyPropertyChanged("CompletedPercent");
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
