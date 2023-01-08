using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RestaurantManager.Models
{
    public class StaffModel : BasePropertyChangedNotification
    {

        public string ID
        {
            get => GetValue(() => ID);
            set
            {
                SetValue(() => ID, value);
            }
        }


        public string Name
        {
            get => GetValue(() => Name);
            set
            {
                SetValue(() => Name, value);
            }
        }


        public DateTime DateOfBirth
        {
            get => GetValue(() => DateOfBirth);
            set
            {
                SetValue(() => DateOfBirth, value);
            }
        }


        public string Province
        {
            get => GetValue(() => Province);
            set
            {
                SetValue(() => Province, value);
            }
        }




    }
}
