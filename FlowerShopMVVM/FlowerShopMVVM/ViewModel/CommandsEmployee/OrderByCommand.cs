using FlowerShopMVVM.Model;
using FlowerShopMVVM.Model.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVVM.ViewModel.CommandsEmployee
{
    public class OrderByCommand : ICommands
    {
        private VMEmployee vmEmployee;
        FlowerRepository flowerRepository = new FlowerRepository();

        public OrderByCommand(VMEmployee vmEmployee)
        {
            this.vmEmployee = vmEmployee;
        }

        public void Execute(string selectedOption)
        {
            try
            {
                if (vmEmployee.Flowers.Columns.Contains("shopID"))
                {
                    vmEmployee.Flowers.Columns.Remove("shopID");
                }
                if (vmEmployee.Flowers != null)
                    vmEmployee.Flowers.Rows.Clear();
                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "NONE")
                    {
                        //this.allCars();
                        vmEmployee.Flowers = flowerRepository.FlowerTableEmployee(vmEmployee.ShopID);
                    }
                    else if (selectedOption.ToUpper() == "COLOR AND PRICE")
                    {

                        if (vmEmployee.Flowers != null)
                            vmEmployee.Flowers.Rows.Clear();
                        List<Flower> list = this.flowerRepository.FlowerList_ColorPrice(vmEmployee.ShopID);
                        foreach (Flower flowers in list)
                        {
                            DataRow row = vmEmployee.Flowers.NewRow();

                            row["flowerID"] = flowers.FlowerID;
                            row["flowerName"] = flowers.FlowerName;
                            row["color"] = flowers.Color;
                            row["price"] = flowers.Price;
                            row["stock"] = flowers.Stock;

                            vmEmployee.Flowers.Rows.Add(row);
                        }
                    }
                }
                else MessageBox.Show("No item selected!");
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
