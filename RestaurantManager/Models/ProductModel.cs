using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RestaurantManager.Models
{
    public class ProductModel : INotifyPropertyChanged
    {
        private string _code;

        public string Code
        {
            get => _code;
            set
            {
                if (_code != value)
                {
                    _code = value;
                    RaisePropertyChanged(nameof(Code));
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

        private string _category;

        public string Category
        {
            get => _category;
            set
            {
                if (_category != value)
                {
                    _category = value;
                    RaisePropertyChanged(nameof(Category));
                }
            }
        }


        private double _priceOrigin;

        public double PriceOrigin
        {
            get => _priceOrigin;
            set
            {
                if (_priceOrigin != value)
                {
                    _priceOrigin = value;
                    RaisePropertyChanged(nameof(PriceOrigin));
                }
            }
        }

        private double _salePercent;

        public double SalePercent
        {
            get => _salePercent;
            set
            {
                if (value >= 0 && value <= 1)
                {
                    if (_salePercent != value)
                    {
                        _salePercent = value;
                        RaisePropertyChanged(nameof(SalePercent));
                    }
                }

            }
        }

        private double _saleMoney;

        public double SaleMoney
        {
            get => _saleMoney;
            set
            {
                if (value >= 0 && value <= _priceOrigin)
                {
                    if (_saleMoney != value)
                    {
                        _saleMoney = value;
                        RaisePropertyChanged(nameof(SaleMoney));
                    }
                }
            }
        }

        private DateTime _dateOfManufacture;

        public DateTime DateOfManufactor
        {
            get => _dateOfManufacture;
            set
            {
                if (_dateOfManufacture != value)
                {
                    _dateOfManufacture = value;
                    RaisePropertyChanged(nameof(DateOfManufactor));
                }
            }
        }

        private DateTime _expiry;

        public DateTime Expiry
        {
            get => _expiry;
            set
            {
                if (_expiry != value)
                {
                    _expiry = value;
                    RaisePropertyChanged(nameof(Expiry));
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
