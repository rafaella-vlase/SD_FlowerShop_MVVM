using FlowerShopMVVM.Model.Repository;
using FlowerShopMVVM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVVM.ViewModel.CommandsAdministrator
{
    public class FilterByRoleCommand : ICommands
    {
        private VMAdministrator vmAdministrator;
        UserRepository userRepository = new UserRepository();
        Repository repository = new Repository();

        public FilterByRoleCommand(VMAdministrator vmAdministrator)
        {
            this.vmAdministrator = vmAdministrator;
        }

        public void Execute() { }
        public void Execute(int dontCare) { }

        public void Execute(string searchedRole)
        {
            try
            {
                if (vmAdministrator.Users != null)
                    vmAdministrator.Users.Rows.Clear();
                if (searchedRole != null && searchedRole.Length > 0)
                {
                    List<User> list = this.userRepository.SearchUserByRole(searchedRole);
                    foreach (User users in list)
                    {
                        DataRow row = vmAdministrator.Users.NewRow();

                        row["userID"] = users.UserID;
                        row["username"] = users.Username;
                        row["password"] = users.Password;
                        row["role"] = users.Role;
                        if (row["shopID"] == null)
                            row["shopID"] = 0;

                        vmAdministrator.Users.Rows.Add(row);
                    }
                }
                else MessageBox.Show("No role inserted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
