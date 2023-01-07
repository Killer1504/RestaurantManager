using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RestaurantManager.Models
{
    public class MartAdressModel : INotifyPropertyChanged
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

        private string _adress;

        public string Adress
        {
            get => _adress;
            set
            {
                if (_adress != value)
                {
                    _adress = value;
                    RaisePropertyChanged(nameof(Adress));
                }
            }

        }

        private string _provinceOrCity;

        public string ProvinceOrCity
        {
            get => _provinceOrCity;
            set
            {
                if (_provinceOrCity != value)
                {
                    _provinceOrCity = value;
                    RaisePropertyChanged(nameof(ProvinceOrCity));
                }
            }
        }

        private string _district;

        public string District
        {
            get => _district;
            set
            {
                if (_district != value)
                {
                    _district = value;
                    RaisePropertyChanged(nameof(District));
                }
            }
        }

        private string _wards;

        public string Wards
        {
            get => _wards;
            set
            {
                if (_wards != value)
                {
                    _wards = value;
                    RaisePropertyChanged(nameof(Wards));
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
