using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Commands;
using RestaurantManager.Interface;

namespace RestaurantManager.ViewModels
{
    public class StoreViewModel : IViewModel
    {
        #region properties
        public Models.StatusModel StatusModel { get; set; }
        public Models.StoreModel StoreModel { get; set; }
        #endregion

        #region commands

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

        }
    }
}
