using FlowerShopMVVM.Model;
using FlowerShopMVVM.Model.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVVM.ViewModel.CommandsManager
{
    public class OrderByCommand : ICommands
    {
        private VMManager vmManager;
        FlowerRepository flowerRepository = new FlowerRepository();

        public OrderByCommand(VMManager vmManager)
        {
            this.vmManager = vmManager;
        }

        public void Execute(string selectedOption)
        {
            try
            {
                if (vmManager.Flowers != null)
                    vmManager.Flowers.Rows.Clear();
                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "NONE")
                    {
                        //this.allCars();
                        vmManager.Flowers = flowerRepository.FlowerTable();
                    }
                    else if (selectedOption.ToUpper() == "COLOR AND PRICE")
                    {

                        if (vmManager.Flowers != null)
                            vmManager.Flowers.Rows.Clear();
                        List<Flower> list = this.flowerRepository.FlowerList_ColorPrice(0);
                        foreach (Flower flowers in list)
                        {
                            DataRow row = vmManager.Flowers.NewRow();

                            row["flowerID"] = flowers.FlowerID;
                            row["flowerName"] = flowers.FlowerName;
                            row["color"] = flowers.Color;
                            row["price"] = flowers.Price;
                            row["stock"] = flowers.Stock;
                            row["shopID"] = flowers.ShopID;

                            vmManager.Flowers.Rows.Add(row);
                        }
                    }
                }
                else MessageBox.Show("No item selected!");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Execute() { }
        public void Execute(int dontCare) { }
    }
}
