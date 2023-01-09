using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VfxLib.Commands;
using VfxLib.Interface;

namespace RestaurantManager.ViewModels
{
    public class StoreViewModel : IViewModel
    {
        #region properties
        public VfxLib.Models.StatusModel StatusModel { get; set; }
        public Models.StoreModel StoreModel { get; set; }
        #endregion

        #region commands
        public VfxCommand LoadedCommand { get; set; }
        #endregion


        public void Init_Model()
        {

        }

        public void OnLoadData()
        {
            throw new NotImplementedException();
        }
        public StoreViewModel()
        {
            Init_Model();
            Init_Command();
        }
        public void Init_Command()
        {
            LoadedCommand = new VfxCommand(OnLoadedCommand, () => true);
        }

        private void OnLoadedCommand(object obj)
        {
            if (obj is Views.StoreUC uc)
            {

            }
        }
    }
}
