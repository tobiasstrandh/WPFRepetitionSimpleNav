using System.Windows.Controls;
using WPFRepetition.Models;

namespace WPFRepetition.UserControls
{
    /// <summary>
    /// Interaction logic for LeftView.xaml
    /// </summary>
    public partial class LeftView : UserControl
    {
        public DataModel DataModel { get; set; }

        public LeftView()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DataModel.Counter--;
        }
    }
}
