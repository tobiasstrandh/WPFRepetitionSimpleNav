using System.Windows.Controls;
using WPFRepetition.Models;

namespace WPFRepetition.UserControls
{
    /// <summary>
    /// Interaction logic for RightView.xaml
    /// </summary>
    public partial class RightView : UserControl
    {
        public DataModel DataModel { get; set; }
        
        public RightView()
        {
            InitializeComponent();
            DataModel = DataManager.DataModel;
            DataContext = DataModel;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DataModel.Counter++;
        }
    }
}
