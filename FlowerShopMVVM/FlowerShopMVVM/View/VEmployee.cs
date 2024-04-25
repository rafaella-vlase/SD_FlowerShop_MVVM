using FlowerShopMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShopMVVM.View
{
    public partial class VEmployee : Form
    {
        private VMEmployee vm;
        public uint shopID;

        public VEmployee(uint shopID)
        {
            InitializeComponent();
            this.vm = new VMEmployee(this, shopID);

            this.numericUpDownFlowerID.DataBindings.Add("Text", this.vm, "FlowerID", false, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxFlowerName.DataBindings.Add("Text", this.vm, "FlowerName", false, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxColor.DataBindings.Add("Text", this.vm, "Color", false, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxPrice.DataBindings.Add("Text", this.vm, "Price", false, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxStock.DataBindings.Add("Text", this.vm, "Stock", false, DataSourceUpdateMode.OnPropertyChanged);

            this.dataGridViewFlowers.DataSource = this.vm.Flowers;
            this.dataGridViewFlowers.SelectionChanged += DataGridViewFlowers_SelectionChanged;

            this.buttonSaveJSON.Click += delegate { vm.SaveJSON.Execute(); };
            this.buttonSaveXML.Click += delegate { vm.SaveXML.Execute(); };
            this.buttonSaveCSV.Click += delegate { vm.SaveCSV.Execute(); };
            this.buttonSaveDOC.Click += delegate { vm.SaveDOC.Execute(); };

            this.buttonAdd.Click += delegate { vm.AddFlower.Execute(); this.dataGridViewFlowers.DataSource = this.vm.Flowers; };
            this.buttonUpdate.Click += delegate { vm.UpdateFlower.Execute(); this.dataGridViewFlowers.DataSource = this.vm.Flowers; };
            this.buttonDelete.Click += delegate { int flowerID = (int)numericUpDownFlowerID.Value; vm.DeleteFlower.Execute(flowerID); this.dataGridViewFlowers.DataSource = this.vm.Flowers; };

            this.buttonSearch.Click += delegate { string searchedFlower = textBoxSearch.Text; vm.SearchByName.Execute(searchedFlower); this.dataGridViewFlowers.DataSource = this.vm.Flowers; };
            this.buttonViewAll.Click += delegate { vm.ListFlowers.Execute(); this.dataGridViewFlowers.DataSource = this.vm.Flowers; };
            this.buttonLogout.Click += delegate { vm.Logout.Execute(); };
            this.shopID = shopID;
        }

        private void ButtonSaveJSON_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBoxOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOrderOption = this.comboBoxOrderBy.SelectedItem.ToString();
            vm.OrderBy.Execute(selectedOrderOption);
            this.dataGridViewFlowers.DataSource = this.vm.Flowers;
        }

        private void comboBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilterOption = this.comboBoxFilterBy.SelectedItem.ToString();
            vm.FilterBy.Execute(selectedFilterOption);
            this.dataGridViewFlowers.DataSource = this.vm.Flowers;
        }

        private void DataGridViewFlowers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewFlowers.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                int flowerID = int.Parse(dataGridViewFlowers.SelectedRows[0].Cells["FlowerID"].Value + string.Empty);
                string flowerName = dataGridViewFlowers.SelectedRows[0].Cells["FlowerName"].Value + string.Empty;
                string color = dataGridViewFlowers.SelectedRows[0].Cells["Color"].Value + string.Empty;
                float price = float.Parse(dataGridViewFlowers.SelectedRows[0].Cells["Price"].Value + string.Empty);
                int stock = int.Parse(dataGridViewFlowers.SelectedRows[0].Cells["Stock"].Value + string.Empty);


                numericUpDownFlowerID.Value = flowerID;
                textBoxFlowerName.Text = flowerName;
                textBoxColor.Text = color;
                textBoxPrice.Text = price.ToString();
                textBoxStock.Text = stock.ToString();
            }
        }
    }
}
