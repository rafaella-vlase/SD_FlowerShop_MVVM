using FlowerShopMVVM.Model.Repository;
using FlowerShopMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FlowerShopMVVM.ViewModel.CommandsManager
{
    public class SearchByNameCommand : ICommands
    {
        private VMManager vmManager;
        FlowerRepository flowerRepository = new FlowerRepository();

        public SearchByNameCommand(VMManager vmManager)
        {
            this.vmManager = vmManager;
        }

        public void Execute(string searchedFlower)
        {
            try
            {
                if(vmManager.Flowers != null)
                    vmManager.Flowers.Rows.Clear();
                if(searchedFlower != null && searchedFlower.Length > 0)
                {
                    List<Flower> list = this.flowerRepository.SearchFlowerByType(searchedFlower);
                    if (list != null && list.Count > 0)
                    {
                        foreach (Flower f in list)
                        {
                            DataRow row = vmManager.Flowers.NewRow();

                            row["flowerID"] = f.FlowerID;
                            row["flowerName"] = f.FlowerName;
                            row["color"] = f.Color;
                            row["price"] = f.Price;
                            row["stock"] = f.Stock;
                            row["shopID"] = f.ShopID;

                            vmManager.Flowers.Rows.Add(row);
                        }
                    }
                    else MessageBox.Show("There is no flower with desired name!");
                }
            } catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Execute() { }
        public void Execute(int dontCare) { }
    }
}
