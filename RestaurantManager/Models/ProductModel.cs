using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using VfxLib.Models;

namespace RestaurantManager.Models
{
    public class ProductModel : BasePropertyChangedNotification
    {

        public string Barcode
        {
            get => GetValue(() => Barcode);
            set => SetValue(() => Barcode, value);
        }



        public string Name
        {
            get => GetValue(() => Name);
            set
            {
                SetValue(() => Name, value);
            }
        }


        public string Category
        {
            get => GetValue(() => Category);
            set
            {
                SetValue(() => Category, value);
            }
        }

        [Range(0, int.MaxValue)]
        public int Quantity
        {
            get => GetValue(() => Quantity);
            set
            {
                SetValue(() => Quantity, value);
            }
        }



        [Range(0, double.MaxValue)]
        public double PriceOrigin
        {
            get => GetValue(() => PriceOrigin);
            set
            {
                SetValue(() => PriceOrigin, value);
            }
        }

        [Range(0.0, 1.0, ErrorMessage = "Phần trăm sale phải nằm trong khoảng {0} và {1}")]
        public double SalePercent
        {
            get => GetValue(() => SalePercent);
            set => SetValue(() => SalePercent, value);
        }

        [Range(0, double.MaxValue)]
        public double SaleMoney
        {
            get => GetValue(() => SaleMoney);
            set
            {
                if (value >= 0 && value <= PriceOrigin)
                {
                    SetValue(() => SaleMoney, value);
                }
            }
        }


        public DateTime DateOfManufactor
        {
            get => GetValue(() => DateOfManufactor);
            set => SetValue(() => DateOfManufactor, value);
        }


        public DateTime Expiry
        {
            get => GetValue(() => Expiry);
            set => SetValue(() => Expiry, value);
        }




    }
}
