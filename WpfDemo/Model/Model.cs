using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemo
{
    public class Model : INotifyPropertyChanged
    {
        #region Properties

        private int _click;

        public int Click
        {
            get { return _click; }
            set
            {
                _click = value;
                OnPropertyChanged("Click");
            }
        }

        private int _resetCounterClick;

        public int ResetCounterClick
        {
            get { return _resetCounterClick; }
            set
            {
                _resetCounterClick = value;
                OnPropertyChanged("ResetCounterClick");
            }
        }


        #endregion

        #region Constructors

        public Model()
        {
            _click = 0;
            _resetCounterClick = 0;
        }

        #endregion

        #region Methods

        public void IncrementTextBox()
        {
            Click++;
        }

        public void ResetTextBox()
        {
            Click = 0;
            ResetCounterClick++;
        }

        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
