using System.Windows.Controls;

namespace Landmark.Dev4Good.WP
{
    public partial class SplashScreenControl : UserControl
    {
        public SplashScreenControl()
        {
            InitializeComponent();
            this.ProgressbarDataload.IsIndeterminate = true;
        }
    }
}
