using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RestaurantManager.Models
{
    public class CustomModel : INotifyPropertyChanged
    {
        private string _id;

        public string ID
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged(nameof(ID));
                }
            }
        }

        private string _phoneNumber;

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    RaisePropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged(nameof(Name));
                }
            }
        }

        private int _point;

        public int Point
        {
            get => _point;
            set
            {
                if (_point != value)
                {
                    _point = value;
                    RaisePropertyChanged(nameof(Point));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
