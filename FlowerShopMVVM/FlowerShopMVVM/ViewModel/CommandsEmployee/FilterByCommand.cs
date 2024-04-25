using FlowerShopMVVM.Model.Repository;
using FlowerShopMVVM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVVM.ViewModel.CommandsEmployee
{
    public class FilterByCommand : ICommands
    {
        private VMEmployee vmEmployee;
        FlowerRepository flowerRepository = new FlowerRepository();

        public FilterByCommand(VMEmployee vmEmployee)
        {
            this.vmEmployee = vmEmployee;
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
                if (vmEmployee.Flowers.Columns.Contains("shopID"))
                {
                    vmEmployee.Flowers.Columns.Remove("shopID");
                }
                if (vmEmployee.Flowers != null)
                    vmEmployee.Flowers.Rows.Clear();
                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "AVAILABILITY")
                    {
                        vmEmployee.Flowers.Rows.Clear();
                        if (vmEmployee.Flowers.Columns.Contains("shopID"))
                        {
                            vmEmployee.Flowers.Columns.Remove("shopID");
                        }
                        List<Flower> list = this.flowerRepository.FlowerList_Availability(vmEmployee.ShopID);
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
                    else if (selectedOption.ToUpper() == "PRICE")
                    {
                        vmEmployee.Flowers.Rows.Clear();
                        if (vmEmployee.Flowers.Columns.Contains("shopID"))
                        {
                            vmEmployee.Flowers.Columns.Remove("shopID");
                        }
                        List<Flower> list = this.flowerRepository.FlowerList_Price(vmEmployee.Price.ToString(), vmEmployee.ShopID);
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
                    else if (selectedOption.ToUpper() == "COLOR")
                    {
                        vmEmployee.Flowers.Rows.Clear();
                        if (vmEmployee.Flowers.Columns.Contains("shopID"))
                        {
                            vmEmployee.Flowers.Columns.Remove("shopID");
                        }
                        List<Flower> list = this.flowerRepository.FlowerList_Color(vmEmployee.Color, vmEmployee.ShopID);
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
                    else if (selectedOption.ToUpper() == "STOCK")
                    {
                        vmEmployee.Flowers.Rows.Clear();
                        if (vmEmployee.Flowers.Columns.Contains("shopID"))
                        {
                            vmEmployee.Flowers.Columns.Remove("shopID");
                        }
                        List<Flower> list = this.flowerRepository.FlowerList_Stock(vmEmployee.Stock.ToString(), vmEmployee.ShopID);
                        if (list == null)
                            Debug.WriteLine("Lista nula");
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
                    else MessageBox.Show("The flowers from desired filter is empty!");

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
