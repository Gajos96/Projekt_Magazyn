using DevExpress.Xpf.Editors.Filtering;
using Projekt_Magazyn.Service;
using System.Windows.Controls;
using System;
using System.Windows.Input;


namespace Projekt_Magazyn.ViewModel
{
    class ConnectingBaseVM : ObservableObject
    {
        #region Variable
        Połaczenie connect = new Połaczenie();
        public string servername
        {
            get
            {
                return connect?.Nazwa_servera;
            }
            set
            {
                connect.Nazwa_servera = value;
                OnPropertyChanged(servername);
            }
        }

        public string dataname
        {
            get
            {
                return connect?.Nazwa_Bazy;
            }
            set
            {
                connect.Nazwa_Bazy = value;
                OnPropertyChanged(dataname);
            }
        }

        public string username
        {
            get
            {
                if()
                 return connect?.Login;
            }
            set
            {
                if (value != null && _saveAskPassword == true)
                {
                    connect.Login = value;
                    OnPropertyChanged(username);
                }
                
            }
        }

        public object password
        {
            get
            {
                return connect?.Password;
            }
            set
            {
                if (value != null && _saveAskPassword != true)
                {
                    connect.Password = value;
                    SaveStateSevice.Zapisz(connect);
                }
                OnPropertyChanged(password);
                
            }
        }



        private bool _saveAskPassword;
        public bool SaveAskPassword
        {
            get { return _saveAskPassword; }
            set { _saveAskPassword = value; }
        }

        #endregion

        public ICommand Save
        {
            get
            {
                return new RelayCommand(o =>
                {
                    //Przy zapisie jeśli zapisuje zawsze baze danych
                    if (_saveAskPassword == true)
                    {
                        SaveStateSevice.Zapisz(connect);
                    }
                    else SaveStateSevice.Clear(connect);
                    OnPropertyChanged(servername,dataname,password,username);
                    
                });
            }
        }

        #region Trigger
        //W czasie załadowania strony

        public ICommand Odczytjson
        {
            get
            {
                return new RelayCommand(p =>
                {
                    connect = SaveStateSevice.Odczytaj();
                    
                    OnPropertyChanged(servername, dataname, password, username);
                });
            }
        }

        private ICommand _passwordCommand;
        public ICommand PasswordCommand
        {
            get
            {
                if (_passwordCommand == null)
                {
                    _passwordCommand = new RelayCommand(PasswordClick);
                }
                return _passwordCommand;
            }
        }

        private void PasswordClick(object p)
        {
            var password = p as PasswordBox;
            Console.WriteLine("Password is: {0}", password.Password);
        }

        #endregion




    }
}
