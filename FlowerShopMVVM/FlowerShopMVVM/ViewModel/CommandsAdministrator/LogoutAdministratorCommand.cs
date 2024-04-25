using FlowerShopMVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVVM.ViewModel.CommandsAdministrator
{
    public class LogoutAdministratorCommand : ICommands
    {
        private VLogin _vLogin;
        private VAdministrator _vAdministrator;
        public LogoutAdministratorCommand(VLogin _vLogin, VAdministrator _vAdministrator)
        {
            this._vLogin = _vLogin;
            this._vAdministrator = _vAdministrator;
        }

        public void Execute(int dontCare) { }
        public void Execute(string dontCare) { }

        public void Execute()
        {
            try
            {
                _vLogin.Show();
                _vAdministrator.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
