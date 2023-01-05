using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interface;
using RestaurantManager.Commands;

namespace RestaurantManager.ViewModels
{
    public class LoginViewModel : IViewModel
    {
        #region properties
        public Models.StatusModel StatusModel { get; set; }
        public Models.LoginModel LoginModel { get; set; }
        #endregion

        #region commands
        public ManagerRestaurantCommands LoginCommand { get; set; }
        #endregion

        public void Init_Model()
        {
            LoginModel = new Models.LoginModel();
            StatusModel = new Models.StatusModel();
        }

        public void OnLoadData()
        {

        }
        public LoginViewModel()
        {
            Init_Model();
            Init_Command();
        }

        public void Init_Command()
        {
            LoginCommand = new ManagerRestaurantCommands(OnLogincommand, CanLoginCommand);
        }

        private void OnLogincommand(object obj)
        {

        }

        private bool CanLoginCommand()
        {
            return true;
        }
    }
}
