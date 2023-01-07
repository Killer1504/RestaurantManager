using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RestaurantManager.Models
{
    public class BillModel : INotifyPropertyChanged
    {
        private ObservableCollection<Models.ProductModel> _productModels;

        public ObservableCollection<Models.ProductModel> ProductModels
        {
            get => _productModels;
            set
            {
                if (_productModels != value)
                {
                    _productModels = value;
                    RaisePropertyChanged(nameof(ProductModels));
                }
            }
        }

        private double _amounttobePaid;

        public double AmoutToBePaid
        {
            get => _amounttobePaid;
            set
            {
                if (_amounttobePaid != value)
                {
                    _amounttobePaid = value;
                    RaisePropertyChanged(nameof(AmoutToBePaid));
                    AmoutReturn = AmoutCustomGive - AmoutToBePaid;
                }
            }
        }

        private double _amoutCustomGive;

        public double AmoutCustomGive
        {
            get => _amoutCustomGive;
            set
            {
                if (_amoutCustomGive != value)
                {
                    _amoutCustomGive = value;
                    RaisePropertyChanged(nameof(AmoutCustomGive));
                    AmoutReturn = AmoutCustomGive - AmoutToBePaid;
                }
            }
        }

        private double _amoutReturn;

        public double AmoutReturn
        {
            get => _amoutReturn;
            private set
            {
                if (_amoutReturn != value)
                {
                    _amoutReturn = value;
                    RaisePropertyChanged(nameof(AmoutReturn));
                }
            }
        }

        private string _datePaid;

        public string DatePaid
        {
            get => _datePaid;
            set
            {
                if (_datePaid != value)
                {
                    _datePaid = value;
                    RaisePropertyChanged(nameof(DatePaid));
                }
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public BillModel()
        {
            ProductModels = new ObservableCollection<ProductModel>();
        }
    }
}
