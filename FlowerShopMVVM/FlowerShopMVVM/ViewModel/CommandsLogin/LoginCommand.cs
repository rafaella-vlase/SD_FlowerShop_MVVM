using FlowerShopMVVM.Model.Repository;
using FlowerShopMVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVVM.ViewModel.CommandsLogin
{
    public class LoginCommand : ICommands
    {
        private VMLogin vmLogin;
        private VLogin _vLogin;
        public LoginCommand(VMLogin vm, VLogin vLogin)
        {
            this.vmLogin = vm;
            _vLogin = vLogin;
        }

        public void Execute(int dontCare) { }
        public void Execute(string dontCare) { }

        public void Execute()
        {
            UserRepository userRepository = new UserRepository();
            try
            {
                string username = vmLogin.Username;
                string password = vmLogin.Password;

                if (username.Length != 0 && password.Length != 0)
                {
                    bool successfulLogin = userRepository.LoginUser(username, password);
                    if (successfulLogin)
                    {
                        string role = userRepository.GetRole(username, password);
                        if (role.Equals("Employee"))
                        {
                            _vLogin.Hide();
                            uint shopID = Convert.ToUInt32(userRepository.GetShopID(username));

                            VEmployee vEmployee = new VEmployee(shopID);
                            vEmployee.Show();
                        }
                        else if (role.Equals("Manager"))
                        {
                            _vLogin.Hide();

                            VManager vManager = new VManager();
                            vManager.Show();
                        }
                        else if (role.Equals("Administrator"))
                        {
                            _vLogin.Hide();

                            VAdministrator vAdministrator = new VAdministrator();
                            vAdministrator.Show();
                        }
                    }
                    else MessageBox.Show("Login failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
