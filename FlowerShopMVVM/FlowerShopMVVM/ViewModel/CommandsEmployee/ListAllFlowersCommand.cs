using FlowerShopMVVM.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVVM.ViewModel.CommandsEmployee
{
    public class ListAllFlowersCommand : ICommands
    {
        private VMEmployee vmEmployee;
        FlowerRepository flowerRepository = new FlowerRepository();

        public ListAllFlowersCommand(VMEmployee vmEmployee)
        {
            this.vmEmployee = vmEmployee;
        }

        public void Execute()
        {
            try
            {
                if (vmEmployee.Flowers != null)
                {
                    vmEmployee.Flowers.Rows.Clear();
                    if (vmEmployee.Flowers.Columns.Contains("shopID"))
                    {
                        vmEmployee.Flowers.Columns.Remove("shopID");
                    }
                    vmEmployee.Flowers = this.flowerRepository.FlowerTableEmployee(vmEmployee.ShopID);
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
