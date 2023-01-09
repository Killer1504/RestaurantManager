using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VfxLib.Interface;
using VfxLib.Commands;

namespace RestaurantManager.ViewModels
{
    public class MainWindowViewModel : IViewModel
    {

        #region properties
        public Models.MainWindowModel MainWindowModel { get; set; }
        #endregion

        #region commands
        public VfxCommand TextChangedCommand { get; set; }
        #endregion

        public void Init_Model()
        {
            MainWindowModel = new Models.MainWindowModel();
        }

        public void OnLoadData()
        {

        }
        public MainWindowViewModel()
        {
            Init_Model();
            Init_Command();
        }

        public void Init_Command()
        {

        }

    }
}
