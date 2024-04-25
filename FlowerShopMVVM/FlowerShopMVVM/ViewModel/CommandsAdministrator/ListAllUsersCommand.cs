using FlowerShopMVVM.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVVM.ViewModel.CommandsAdministrator
{
    public class ListAllUsersCommand : ICommands
    {
        private VMAdministrator vmAdministrator;
        UserRepository userRepository = new UserRepository();
        Repository repository = new Repository();

        public ListAllUsersCommand(VMAdministrator vmAdministrator)
        {
            this.vmAdministrator = vmAdministrator;
        }

        public void Execute()
        {
            try
            {
                if (vmAdministrator.Users != null)
                {
                    vmAdministrator.Users.Rows.Clear();
                    vmAdministrator.Users = this.repository.GetTable("SELECT * FROM [Users]");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Execute(int dontCare) { }

        public void Execute(string dontCare) { }
    }
}
