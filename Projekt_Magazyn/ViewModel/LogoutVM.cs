using System.Threading;
using System.Windows;
using System.Windows.Input;
using Projekt_Magazyn.Main_Window;
using Projekt_Magazyn.View;

namespace Projekt_Magazyn.ViewModel
{
    class LogoutVM : ObservableObject
    {
        #region Variable

        private ConnectingBaseVM _sqlConnect = null;
        public ConnectingBaseVM SqlConnect
        {
            get => _sqlConnect;
            set
            {
                _sqlConnect = value;
                OnPropertyChanged(SqlConnect);
            }
        }

        #endregion

        #region Command
        private ICommand _zaloguj;
        public ICommand Zaloguj
        {
            get
            {
                if (_zaloguj == null)
                {
                    _zaloguj = new RelayCommand(o =>
                {

                });
                }
                return _zaloguj;
            }
        }

        private ICommand _offwindow;
        public ICommand Offwindow
        {
            get
            {
                if (_offwindow == null)
                {
                    _offwindow = new RelayCommand(o =>
                {

                });
                }
                return _offwindow;
            }
        }

        private ICommand _changeBase;
        public ICommand ChangeBase
        {
            get
            {
                if (_changeBase == null)
                {
                    _changeBase = new RelayCommand(o =>
                    {
                        
                        var connection = new ConnetingSql();
                        connection.Owner = Application.Current.MainWindow;
                        connection.Show();
                    });
                }
                return _changeBase;
            }
        }



    }
}
#endregion