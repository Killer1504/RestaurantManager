using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VfxLib.Interface;
using VfxLib.Commands;

namespace RestaurantManager.ViewModels
{
    public class LoginViewModel : IViewModel
    {
        #region properties
        public VfxLib.Models.StatusModel StatusModel { get; set; }
        public Models.LoginModel LoginModel { get; set; }
        #endregion

        #region commands
        public VfxCommand LoginCommand { get; set; }
        #endregion

        public void Init_Model()
        {
            LoginModel = new Models.LoginModel();
            StatusModel = new VfxLib.Models.StatusModel();
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
            LoginCommand = new VfxCommand(OnLogincommand, CanLoginCommand);
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
