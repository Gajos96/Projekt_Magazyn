using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Magazyn
{
    class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Można również nameof nie ma znaczenia
        /// </summary>
        /// <param name="name"></param>
        protected void OnPropertyChanged(params object[] nazwywłasnosci)
        {
            if (PropertyChanged != null)
                foreach (string nazwawłasnosci in nazwywłasnosci)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nazwawłasnosci));
                }
        }
    }
}
