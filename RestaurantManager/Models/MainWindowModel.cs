using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManager.Models
{
    public class MainWindowModel : BasePropertyChangedNotification
    {
        [MaxLength(50, ErrorMessage ="Trường {0} không được quá {1} kí tự")]
        public string Title
        {
            get => GetValue(() => Title);
            set => SetValue(() => Title, value);
        }

        public MainWindowModel()
        {
            Title = "Quản lý cửa hàng";
        }
    }
}
