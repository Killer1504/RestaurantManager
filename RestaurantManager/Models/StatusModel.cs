using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RestaurantManager.Models
{
    public class StatusModel : BasePropertyChangedNotification
    {

        public string Status
        {
            get => GetValue(() => Status);
            set => SetValue(() => Status, value);
        }



        public System.Windows.Media.Brush StatusColor
        {
            get => GetValue(() => StatusColor);
            set => SetValue(() => StatusColor, value);
        }

    }
}
