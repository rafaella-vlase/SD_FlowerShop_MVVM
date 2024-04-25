using FlowerShopMVVM.Model.Repository;
using FlowerShopMVVM.View;
using FlowerShopMVVM.ViewModel.CommandsEmployee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVVM.ViewModel
{
    public class VMEmployee : INotifyPropertyChanged
    {
        private uint flowerID;
        private string flowerName;
        private string color;
        private float price;
        private int stock;
        private uint shopID;
        public DataTable Flowers;
        private VEmployee vEmployee;
        private Repository repository;
        public ICommands AddFlower, UpdateFlower, DeleteFlower;
        public ICommands ListFlowers;
        public ICommands FilterBy;
        public ICommands OrderBy;
        public ICommands SearchByName;
        public ICommands Logout;
        public ICommands SaveCSV, SaveJSON, SaveXML, SaveDOC;

        public event PropertyChangedEventHandler? PropertyChanged;

        public VMEmployee(VEmployee vEmployee, uint shopID)
        {
            this.flowerID = 1;
            this.flowerName = string.Empty;
            this.color = string.Empty;
            this.price = 0;
            this.stock = 0;
            this.shopID = shopID;
            this.repository = new Repository();
            this.Flowers = new FlowerRepository().FlowerTableEmployee(shopID);
            this.vEmployee = vEmployee;
            this.AddFlower = new AddFlowerCommand(this);
            this.UpdateFlower = new UpdateFlowerCommand(this);
            this.DeleteFlower = new DeleteFlowerCommand(this);
            this.ListFlowers = new ListAllFlowersCommand(this);
            this.FilterBy = new FilterByCommand(this);
            this.OrderBy = new OrderByCommand(this);
            this.SearchByName = new SearchByNameCommand(this);
            this.SaveCSV = new SaveCSVCommand(this);
            this.SaveJSON = new SaveJSONCommand(this);
            this.SaveXML = new SaveXMLCommand(this);
            this.SaveDOC = new SaveDOCEmployeeCommand(this);
            this.Logout = new LogoutEmployeeCommand(new VLogin(), vEmployee);

        }


        public uint FlowerID
        {
            get { return this.flowerID; }
            set { this.flowerID = value; }
        }

        public string FlowerName
        {
            get { return this.flowerName; }
            set { this.flowerName = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public float Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public int Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }

        public uint ShopID
        {
            get { return this.shopID; }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
