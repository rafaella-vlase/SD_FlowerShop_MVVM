using FlowerShopMVVM.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVVM.ViewModel.CommandsManager
{
    public class ListAllFlowersCommand : ICommands
    {
        private VMManager vmManager;
        FlowerRepository flowerRepository = new FlowerRepository();

        public ListAllFlowersCommand(VMManager vmManager)
        {
            this.vmManager = vmManager;
        }

        public void Execute()
        {
            try
            {
                if(vmManager.Flowers != null)
                {
                    vmManager.Flowers.Rows.Clear();
                    vmManager.Flowers = this.flowerRepository.FlowerTable();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Execute(int dontCare) { }
        public void Execute(string dontCare) { }

    }
}
