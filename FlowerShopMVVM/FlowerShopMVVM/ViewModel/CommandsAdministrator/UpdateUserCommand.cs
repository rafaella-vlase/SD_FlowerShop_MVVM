using FlowerShopMVVM.Model.Repository;
using FlowerShopMVVM.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVVM.ViewModel.CommandsAdministrator
{
    public class UpdateUserCommand : ICommands
    {
        private VMAdministrator vmAdministrator;
        UserRepository userRepository = new UserRepository();
        Repository repository = new Repository();

        public UpdateUserCommand(VMAdministrator vmAdministrator)
        {
            this.vmAdministrator = vmAdministrator;
        }

        public void Execute() { }
        public void Execute(string dontCare) { }

        public void Execute(int selectedUser)
        {

            try
            {
                if (Convert.ToBoolean(selectedUser))
                {
                    //uint selectedID = Convert.ToUInt32(this.iEmployeeGUI.GetSelectedCarID());
                    User user = this.validInformation();
                    if (user != null)
                    {
                        bool result = this.userRepository.UpdateUser(user);
                        if (result)
                        {
                            MessageBox.Show("Updating was completed successfully!");
                            vmAdministrator.UserID = 1;
                            vmAdministrator.Username = string.Empty;
                            vmAdministrator.Password = string.Empty;
                            vmAdministrator.Role = string.Empty;
                            vmAdministrator.ShopID = 1;
                            vmAdministrator.Users.Rows.Clear();
                            vmAdministrator.Users = repository.GetTable("SELECT * FROM [Users]");
                        }
                        else MessageBox.Show("Updating was ended with failure!");
                    }
                }
                else MessageBox.Show("No user has been selected to be updated!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }

        private User validInformation()
        {
            Debug.Print("User ID: " + vmAdministrator.UserID);
            if (vmAdministrator.UserID == 0)
            {
                MessageBox.Show("User ID must be non-zero natural number!");
                return null;
            }
            Debug.Print("Username: " + vmAdministrator.Username);
            if (vmAdministrator.Username == null || vmAdministrator.Username.Length == 0)
            {
                MessageBox.Show("Username is empty!");
                return null;
            }
            Debug.Print("Password: " + vmAdministrator.Password);
            if (vmAdministrator.Password == null || vmAdministrator.Password.Length == 0)
            {
                MessageBox.Show("Password is empty!");
                return null;
            }
            Debug.Print("Role: " + vmAdministrator.Role);
            if (vmAdministrator.Role == null || vmAdministrator.Role.Length == 0)
            {
                MessageBox.Show("Role is empty");
                return null;
            }
            if(vmAdministrator.ShopID == 0)
            {
                MessageBox.Show("Shop ID must be non-zero number!");
                return null;
            }
            return new User(vmAdministrator.UserID, vmAdministrator.Username, vmAdministrator.Password, vmAdministrator.Role, vmAdministrator.ShopID);
        }
    }
}
