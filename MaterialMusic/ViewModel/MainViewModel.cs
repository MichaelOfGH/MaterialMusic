using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using RestSharp;
using System.Threading.Tasks;
using System.Windows;

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
        public RelayCommand RequestCommand { get; set; }

        #region Public Member


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
                    var response = client.Execute(request);
                    MessageBox.Show(response.Content);
                    return;
                    App.Current.Dispatcher.Invoke(() =>
                    {
                    });
                });
            });
        }
        #endregion
    }
}