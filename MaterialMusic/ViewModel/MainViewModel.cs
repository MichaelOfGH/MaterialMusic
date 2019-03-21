using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using RestSharp;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MaterialMusic.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {

        #region Private Member

        #endregion

        /// <summary>
        /// «Î«ÛÕ¯¬Á (≤‚ ‘Command)
        /// </summary>
        public ICommand RequestCommand { get; set; }

        #region Public Member
        public RelayCommand<string> WindowCommand => new RelayCommand<string>((para) =>
        {
            if (string.IsNullOrWhiteSpace(para))
            {
                return;
            }

            MainWindow window = null;
            for (int i = 0; i < Application.Current.Windows.Count; i++)
            {
                if (Application.Current.Windows[i] is MainWindow)
                {
                    window = Application.Current.Windows[i] as MainWindow;
                }
            }

            switch (para)
            {
                case "0"://Close Window
                    window.Close();
                    break;
                case "1"://Max or recovery Window
                    if (window.WindowState == System.Windows.WindowState.Normal)
                    {
                        window.WindowState = System.Windows.WindowState.Maximized;//Maximized Window
                    }
                    else
                    {
                        window.WindowState = System.Windows.WindowState.Normal;//recovery
                    }
                    break;
                case "2"://Min Window
                    window.WindowState = System.Windows.WindowState.Normal;//Min window
                    break;
                default:
                    break;
            }
        });

        #endregion

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            InitialCommands();
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        #region ≥ı ºªØCommand
        private void InitialCommands()
        {
            RequestCommand = new RelayCommand(() =>
            {
                Task.Run(() =>
                {

                    var client = new RestClient("http://bing.com");
                    var request = new RestRequest("");
                    IRestResponse response = client.Execute(request);
                    App.Current.Dispatcher.Invoke(() =>
                    {
                        MessageBox.Show(response.Content);
                    });
                });
            });
        }
        #endregion
    }
}