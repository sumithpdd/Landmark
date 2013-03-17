using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Landmark.Dev4Good.WP;
using Landmark.Dev4Good.WP.Models;
using Microsoft.Phone.Controls;

namespace BarGame
{
    public partial class QuizPage : PhoneApplicationPage
    {


        private List<QuizItem> _quizItem;
        private QuizItem _curQuizItem;
        private int _curQIndex;
        private int _currentPoints = 10;
        int _quizTime = 10;
        protected bool InputEnabled
        {
            get;
            set;
        }

        public QuizPage()
        {
            InitializeComponent();
            UpdateScore();
            var model = new QuizData();
            _quizItem = model.GetQuizItems();
            LoadNextQuiz();
            _sbBeginQuestion.Begin();

            InputEnabled = true;
        }
        private void LoadNextQuiz()
        {
            var max = _quizItem.Count();

            var idx = new Random().Next(1, max + 1);
            DisplayQuizItem(idx);

        }
        private void StartQuizTimer()
        {
            _quizTime = 60;
            _txtTime.Text = "60 sec(s) left";
            _scale.ScaleX = 0;
            _sbCountdown.Begin();
            _sbTimer.Begin();

            // EnableInputs();
        }
        private void DisplayQuizItem(int idx)
        {
            // Populate the current quiz data
            var q = _quizItem[idx - 1];
            _curQuizItem = q;
            _curQIndex = idx - 1;

            _txtQtn.Text = q.Question;
          

            _tA.Text = q.A;
            _tB.Text = q.B;
            _tC.Text = q.C;
            _tD.Text = q.D;
        }
        private void OnHover(object sender, MouseEventArgs e)
        {
            ((Rectangle)sender).Opacity = 1;
        }

        private void OnLeave(object sender, MouseEventArgs e)
        {
            ((Rectangle)sender).Opacity = 0.6;
        }

        private void OnChoiceSelected(object sender, MouseButtonEventArgs e)
        {
            if (InputEnabled == false)
                return;

            var n = ((Rectangle)sender).Name;
            var a = n.Split('_');

            if (a[1] == _curQuizItem.Answer)
            {
              //  App.UserSettingsViewModel.CurrentTotalScore += _currentPoints;
                ((Rectangle)sender).Fill = new SolidColorBrush { Color = Colors.Green };
                txtResult.Text = "  You scored : " + _currentPoints;
                txtResult.Foreground = new SolidColorBrush() { Color = Colors.Green };
                NavigationService.Navigate(new Uri(
                   "/Congrats.xaml",
                   UriKind.Relative));
            }
            else
            {
                ((Rectangle)sender).Fill = new SolidColorBrush() { Color = Colors.Red };
                txtResult.Text = "  Better luck next time.";
                txtResult.Foreground = new SolidColorBrush() { Color = Colors.Red };
            }

            DisableInputs();
            //ResetQuiz();
            UpdateScore();
        }
        private void ResetQuiz()
        {
            _sbCountdown.Stop();
            _sbTimer.Stop();

            _currentPoints = 10;
            // Hide the timer 
            _txtTime.Text = "";
            _scale.ScaleX = 0;

             
            // Remove the shown quiz from the array
            //TODO
            // Fade the UI away and reset the user interface interface
            //TODO
        }
        private void UpdateScore()
        {
            // Update the score area
           // _txtTotalScore.Text = App.UserSettingsViewModel.CurrentTotalScore.ToString();
        }

        private void _sbTimer_Completed(object sender, EventArgs e)
        {
            _quizTime--;
            if (_quizTime < 0)
            {
                DisableInputs();
                txtResult.Text = "  Times Up!!";
                txtResult.Foreground = new SolidColorBrush() { Color = Colors.Red };

                //ResetQuiz();
            }
            else
            {
                _currentPoints = _quizTime;
                _txtTime.Text = _quizTime + " sec(s) left";
                _sbTimer.Begin();
            }
        }

        private void DisableInputs()
        {

            if (!InputEnabled)
                return;
            InputEnabled = false;
            _sbCountdown.Stop();
            _sbTimer.Stop();
        }


        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            e.Cancel = true;

        }

        private void _sbBeginQuestion_Completed(object sender, EventArgs e)
        {
            StartQuizTimer();
        }
    }
}