using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VfxLib.Interface
{
    public interface IViewModel
    {
        void Init_Model();
        void Init_Command();
        void OnLoadData();
    }
}
