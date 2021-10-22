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
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DataModel.Counter++;
        }
    }
}
