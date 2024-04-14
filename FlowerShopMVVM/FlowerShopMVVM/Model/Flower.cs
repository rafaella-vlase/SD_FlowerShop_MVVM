namespace FlowerShopMVVM.Model
{
    public class Flower
    {
        protected uint flowerID;
        protected uint floristID;
        protected string type;
        protected string color;
        protected float price;
        protected int stock;
        protected string isAvailable;

        public Flower()
        {
            flowerID = 1;
            floristID = 1;
            price = 15;
            stock = 20;
            isAvailable = "yes";
            color = "Red";
            type = "Rose";
        }

        public Flower(uint flowerID, uint floristID, string type, string color, float price, int stock, string isAvailable)
        {
            this.flowerID = flowerID;
            this.floristID = floristID;
            this.price = price;
            this.stock = stock;
            this.isAvailable = isAvailable;
            this.color = color;
            this.type = type;
        }

        public Flower(Flower flower)
        {
            flowerID = flower.flowerID;
            floristID = flower.floristID;
            price = flower.price;
            stock = flower.stock;
            isAvailable = flower.isAvailable;
            color = flower.color;
            type = flower.type;
        }

        public uint FlowerID
        {
            get { return flowerID; }
            set { flowerID = value; }
        }

        public uint FloristID
        {
            get { return floristID; }
            set { floristID = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public string IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public override string ToString()
        {
            string s = "Flower: " + type;
            s += "Flower ID: " + flowerID;
            s += " Florist: " + floristID;
            s += " Color: " + color;
            s += " Price: " + price;
            s += " Stock = " + stock;
            s += " Is Available? = " + isAvailable;
            return s;
        }
    }
}

