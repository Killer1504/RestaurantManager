using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RestaurantManager.Models
{
    public class BillModel : BasePropertyChangedNotification
    {

        public ObservableCollection<Models.ProductModel> ProductModels
        {
            get => GetValue(() => ProductModels);
            set
            {
                SetValue(() => ProductModels, value);
            }
        }


        public double AmoutToBePaid
        {
            get => GetValue(() => AmoutToBePaid);
            set
            {
                SetValue(() => AmoutToBePaid, value);
                AmoutReturn = AmountCustomGive - AmoutToBePaid;
            }
        }


        public double AmountCustomGive
        {
            get => GetValue(() => AmountCustomGive);
            set
            {
                SetValue(() => AmountCustomGive, value);
                AmoutReturn = AmountCustomGive - AmoutToBePaid;

            }
        }


        public double AmoutReturn
        {
            get => GetValue(() => AmoutReturn);
            private set
            {
                SetValue(() => AmoutReturn, value);
            }
        }


        public DateTime DatePayment
        {
            get => GetValue(() => DatePayment);
            set
            {
                SetValue(() => DatePayment, value);
            }
        }



        public BillModel()
        {
            ProductModels = new ObservableCollection<ProductModel>();
        }
    }
}
