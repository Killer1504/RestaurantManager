using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VfxLib.Models;

namespace RestaurantManager.Models
{
    public class LoginModel : BasePropertyChangedNotification
    {
        [MinLength(5)]
        [MaxLength(50)]
        public string UserName
        {
            get => GetValue(() => UserName);
            set
            {
                SetValue(() => UserName, value);
            }
        }
        [MinLength(8, ErrorMessage ="The filled Password must greater 8 charater")]
        [MaxLength(50)]
        public string Password
        {
            get => GetValue(() => Password);
            set
            {
                SetValue(() => Password, value);
            }
        }


        [MinLength(20)]
        [MaxLength(50)]
        public string ComputerID
        {
            get => GetValue(() => ComputerID);
            set
            {
                SetValue(() => ComputerID, value);
            }
        }

    }
}
