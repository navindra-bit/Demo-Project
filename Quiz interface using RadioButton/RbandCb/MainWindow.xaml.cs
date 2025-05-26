using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RbandCb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if(radioButton.Tag.ToString() == "C" )
            {
                count++;
                radioButton.Foreground = Brushes.Green;
            }
            else
            {
                radioButton.Foreground = Brushes.Red;
            }
            tl2.Text  = count.ToString();
            
            StackPanel stackPanel = (StackPanel)radioButton.Parent;
            stackPanel.IsEnabled = false;
            
        }
        
        private void sm_Click(object sender, RoutedEventArgs e)
        {
           
            ScorePage scorePage = new ScorePage(count);
            scorePage.Show();
            this.Close();
        }
    }
}