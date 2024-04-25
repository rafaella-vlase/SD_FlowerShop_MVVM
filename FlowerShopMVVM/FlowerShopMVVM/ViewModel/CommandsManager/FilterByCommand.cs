using FlowerShopMVVM.Model.Repository;
using FlowerShopMVVM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVVM.ViewModel.CommandsManager
{
    public class FilterByCommand : ICommands
    {
        private VMManager vmManager;
        FlowerRepository flowerRepository = new FlowerRepository();

        public FilterByCommand(VMManager vmManager)
        {
            this.vmManager = vmManager;
        }

        public void Execute(string selectedOption)
        {
            // shopID -> Flower Shop
            // stock -> Availability
            // color -> Color
            // price -> Price
            // stock -> Quantity

            try
            {
                if (vmManager.Flowers != null)
                    vmManager.Flowers.Rows.Clear();
                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "AVAILABILITY")
                    {
                        vmManager.Flowers.Rows.Clear();
                        List<Flower> list = this.flowerRepository.FlowerList_Availability(0);
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
                    else if (selectedOption.ToUpper() == "PRICE")
                    {
                        vmManager.Flowers.Rows.Clear();
                        List<Flower> list = this.flowerRepository.FlowerList_Price(vmManager.Price.ToString(), 0);
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
                    else if (selectedOption.ToUpper() == "COLOR")
                    {
                        vmManager.Flowers.Rows.Clear();
                        List<Flower> list = this.flowerRepository.FlowerList_Color(vmManager.Color, 0);
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
                    else if (selectedOption.ToUpper() == "QUANTITY")
                    {
                        vmManager.Flowers.Rows.Clear();
                        List<Flower> list = this.flowerRepository.FlowerList_Stock(vmManager.Stock.ToString(), 0);
                        if (list == null)
                            Debug.WriteLine("Lista nula");
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
                    else if(selectedOption.ToUpper() == "FLOWER SHOP")
                    {
                        vmManager.Flowers.Rows.Clear();
                        List<Flower> list = this.flowerRepository.FlowerList_FlowerShop(vmManager.ShopID);
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
                    else MessageBox.Show("The cars from desired filter is empty!");

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }
        public void Execute(int dontCare) { }
        public void Execute() { }
    }
}
