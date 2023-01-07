using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantManager.Utils
{
    public class GlobalVariable
    {
        public static GlobalVariable Instance { get; set; }
        public GlobalVariable()
        {
            if(Instance == null)
            {
                Instance = new GlobalVariable();
            }
        }
    }
}
