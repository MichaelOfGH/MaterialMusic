using ExtraTools;
using System.Windows;

namespace MaterialMusic
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogBox.Show("错误 404", "Unable to connect to the website.", "RETRY");
        }
    }
}
