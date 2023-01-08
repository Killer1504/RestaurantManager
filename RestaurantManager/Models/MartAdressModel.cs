using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RestaurantManager.Models
{
    public class MartAdressModel : BasePropertyChangedNotification
    {

        public string ID
        {
            get => GetValue(() => ID);
            set
            {
                SetValue(() => ID, value);
            }

        }


        public string Adress
        {
            get => GetValue(() => Adress);
            set
            {
                SetValue(() => Adress, value);
            }

        }


        public string ProvinceOrCity
        {
            get => GetValue(() => ProvinceOrCity);
            set
            {
                SetValue(() => ProvinceOrCity, value);
            }
        }


        public string District
        {
            get => GetValue(() => District);
            set
            {
                SetValue(() => District, value);
            }
        }


        public string Wards
        {
            get => GetValue(() => Wards);
            set
            {
                SetValue(() => Wards, value);
            }
        }

    }
}
