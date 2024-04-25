using FlowerShopMVVM.Model.Repository;
using FlowerShopMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FlowerShopMVVM.ViewModel.CommandsEmployee
{
    public class SearchByNameCommand : ICommands
    {
        private VMEmployee vmEmployee;
        FlowerRepository flowerRepository = new FlowerRepository();

        public SearchByNameCommand(VMEmployee vmEmployee)
        {
            this.vmEmployee = vmEmployee;
        }

        public void Execute(string searchedFlower)
        {
            try
            {
                if (vmEmployee.Flowers != null)
                {
                    vmEmployee.Flowers.Rows.Clear();
                    vmEmployee.Flowers.Columns.Add("shopID", typeof(uint));
                }
                if (searchedFlower != null && searchedFlower.Length > 0)
                {
                    List<Flower> list = this.flowerRepository.SearchFlowerByType(searchedFlower);
                    if (list != null && list.Count > 0)
                    {
                        foreach (Flower f in list)
                        {
                            DataRow row = vmEmployee.Flowers.NewRow();

                            row["flowerID"] = f.FlowerID;
                            row["flowerName"] = f.FlowerName;
                            row["color"] = f.Color;
                            row["price"] = f.Price;
                            row["stock"] = f.Stock;
                            row["shopID"] = f.ShopID;

                            vmEmployee.Flowers.Rows.Add(row);
                        }
                    }
                    else MessageBox.Show("There is no flower with desired name!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Execute() { }
        public void Execute(int dontCare) { }
    }
}
