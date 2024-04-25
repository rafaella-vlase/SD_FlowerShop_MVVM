using FlowerShopMVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVVM.ViewModel.CommandsEmployee
{
    public class LogoutEmployeeCommand : ICommands
    {
        private VLogin _vLogin;
        private VEmployee _vEmployee;
        public LogoutEmployeeCommand(VLogin _vLogin, VEmployee _vEmployee)
        {
            this._vLogin = _vLogin;
            this._vEmployee = _vEmployee;
        }

        public void Execute(int dontCare) { }
        public void Execute(string dontCare) { }

        public void Execute()
        {
            try
            {
                _vLogin.Show();
                _vEmployee.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
