﻿namespace GenericControlBox
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class ViewModel : INotifyPropertyChanged
    {
        private int intValue = 2;
        private double doubleValue = 2.1;

        public event PropertyChangedEventHandler PropertyChanged;

        public int IntValue
        {
            get
            {
                return this.intValue;
            }
            set
            {
                if (value == this.intValue) return;
                this.intValue = value;
                this.OnPropertyChanged();
            }
        }

        public double DoubleValue
        {
            get
            {
                return this.doubleValue;
            }
            set
            {
                if (value == this.doubleValue) return;
                this.doubleValue = value;
                this.OnPropertyChanged();
            }
        }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
