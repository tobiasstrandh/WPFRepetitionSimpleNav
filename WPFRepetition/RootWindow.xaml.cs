using System.Windows;
using System.Windows.Controls;
using WPFRepetition.Models;

namespace WPFRepetition
{
    /// <summary>
    /// Interaction logic for RootWindow.xaml
    /// </summary>
    public partial class RootWindow : Window
    {
        public RootWindow()
        {
            InitializeComponent();
            var dataModel = new DataModel();
            DataContext = dataModel;
            LeftViewFld.DataModel = dataModel;
            RightViewFld.DataModel = dataModel;
            CenterViewFld.DataModel = dataModel;
        }
        
        private void ShowLeft_Click(object sender, RoutedEventArgs e)
        {
            if (LeftViewFld.Visibility != Visibility.Visible)
            {
                LeftViewFld.Visibility = Visibility.Visible;
                RightViewFld.Visibility = Visibility.Collapsed;
                CenterViewFld.Visibility = Visibility.Collapsed;
            }
        }

        private void ShowCenter_Click(object sender, RoutedEventArgs e)
        {
            if (CenterViewFld.Visibility != Visibility.Visible)
            {
                CenterViewFld.Visibility = Visibility.Visible;
                LeftViewFld.Visibility = Visibility.Collapsed;
                RightViewFld.Visibility = Visibility.Collapsed;
            }
        }

        private void ShowRight_Click(object sender, RoutedEventArgs e)
        {
            if (RightViewFld.Visibility != Visibility.Visible)
            {
                RightViewFld.Visibility = Visibility.Visible;
                CenterViewFld.Visibility = Visibility.Collapsed;
                LeftViewFld.Visibility = Visibility.Collapsed;
            }
        }
    }
}
