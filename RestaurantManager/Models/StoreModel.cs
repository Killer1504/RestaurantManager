using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using VfxLib.Models;

namespace RestaurantManager.Models
{
    public class StoreModel : BasePropertyChangedNotification
    {
        public ObservableCollection<Models.ProductModel> ProductModels
        {
            get => GetValue(() => ProductModels);
            set => SetValue(() => ProductModels, value);
        }

    }
}
