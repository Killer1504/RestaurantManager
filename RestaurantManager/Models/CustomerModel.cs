using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RestaurantManager.Models
{
    public class CustomerModel : BasePropertyChangedNotification
    {

        public string ID
        {
            get => GetValue(() => ID);
            set => SetValue(() => ID, value);
        }

        [MinLength(8, ErrorMessage ="Số điện thoại ít nhất là 8 kí tự")]
        public string PhoneNumber
        {
            get => GetValue(() => PhoneNumber);
            set => SetValue(() => PhoneNumber, value);
        }


        public string Name
        {
            get => GetValue(() => Name);
            set => SetValue(() => Name, value);
        }


        [Range(0.0, double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public int PointReward
        {
            get => GetValue(() => PointReward);
            set => SetValue(() => PointReward, value);
        }



    }
}
