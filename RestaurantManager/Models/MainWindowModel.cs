using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManager.Models
{
    public class MainWindowModel : PropertyChangedNotification
    {
        [MinLength(5)]
        [MaxLength(50)]
        public string Title
        {
            get { return GetValue(() => Title); }
            set { SetValue(() => Title, value); }
        }

        public MainWindowModel()
        {
            Title = "Quản lý cửa hàng";
        }
    }
}
