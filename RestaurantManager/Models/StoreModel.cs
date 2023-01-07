using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RestaurantManager.Models
{
    public class StoreModel : INotifyPropertyChanged
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


        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
