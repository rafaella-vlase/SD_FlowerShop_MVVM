using FlowerShopMVVM.Model.Repository;
using FlowerShopMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FlowerShopMVVM.ViewModel.CommandsEmployee
{
    public class DeleteFlowerCommand : ICommands
    {
        private VMEmployee vmEmployee;
        FlowerRepository flowerRepository = new FlowerRepository();
        Repository repository = new Repository();

        public DeleteFlowerCommand(VMEmployee vMEmployee)
        {
            vmEmployee = vMEmployee;
        }

        public void Execute(int selectedFlower)
        {
            try
            {
                if (Convert.ToBoolean(selectedFlower))
                {
                    //uint flowerID = Convert.ToUInt32(vmEmployee.FlowerID);
                    bool result = this.flowerRepository.DeleteFlower(Convert.ToUInt32(selectedFlower), vmEmployee.ShopID);
                    //Debug.WriteLine("Selected Flower ID: " + Convert.ToUInt32(selectedFlower) + "\nFrom Shop ID: " + vmEmployee.ShopID);

                    if (true == true)
                    {
                        MessageBox.Show("Deleting was successful!");
                        vmEmployee.FlowerID = 1;
                        vmEmployee.FlowerName = string.Empty;
                        vmEmployee.Color = string.Empty;
                        vmEmployee.Price = 0;
                        vmEmployee.Stock = 0;

                        if (vmEmployee.Flowers.Columns.Contains("shopID"))
                        {
                            vmEmployee.Flowers.Columns.Remove("shopID");
                        }
                        if (vmEmployee.Flowers != null)
                            vmEmployee.Flowers.Rows.Clear();
                        vmEmployee.Flowers = flowerRepository.FlowerTableEmployee(vmEmployee.ShopID);

                        if (vmEmployee.Flowers == null)
                            MessageBox.Show("There is no flower in your table!");

                    }
                    else MessageBox.Show("Deletion ended with failure!");
                }
                else MessageBox.Show("No flower has been selected to be deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private Flower validInformation()
        {
            uint flowerID = vmEmployee.FlowerID;
            if (flowerID == 0)
            {
                MessageBox.Show("Flower ID must be non-zero natural number!");
                return null;
            }

            string flowerName = vmEmployee.FlowerName;
            if (flowerName == null || flowerName.Length == 0)
            {
                MessageBox.Show("Flower Name is empty!");
                return null;
            }

            string color = vmEmployee.Color;
            if (flowerName == null || flowerName.Length == 0)
            {
                MessageBox.Show("Color is empty!");
                return null;
            }

            float price = vmEmployee.Price;
            if (price <= 0)
            {
                MessageBox.Show("Price should be higher than 0!");
                return null;
            }

            int stock = vmEmployee.Stock;
            if (stock < 0)
            {
                MessageBox.Show("Stock should be at least 0!");
                return null;
            }

            uint shopID = vmEmployee.ShopID;
            if (shopID == 0)
            {
                MessageBox.Show("Shop ID must be non-zero natural number!");
                return null;
            }
            return new Flower(flowerID, shopID, flowerName, color, price, stock);
        }

        public void Execute() { }
        public void Execute(string dontCare) { }
    }
}
