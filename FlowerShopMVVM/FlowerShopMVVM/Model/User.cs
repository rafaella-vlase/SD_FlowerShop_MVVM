namespace FlowerShopMVVM.Model
{

    public class User
    {
        protected uint userID;
        protected string username;
        protected string password;
        protected string role;
        protected uint floristID;

        public User()
        {
            userID = 1;
            username = "ella";
            password = "stardew";
            role = "Administrator";
            floristID = 0;
        }

        public User(uint userID, string username, string password, string role, uint floristID)
        {
            this.userID = userID;
            this.username = username;
            this.password = password;
            this.role = role;
            this.floristID = floristID;
        }

        public User(User user)
        {
            userID = user.userID;
            username = user.username;
            password = user.password;
            role = user.role;
            floristID = user.floristID;
        }

        public uint UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public uint FloristID
        {
            get { return floristID; }
            set { floristID = value; }
        }

        public override string ToString()
        {
            string s = "Username: " + username;
            s += "\nPassword: " + password;
            s += "\nRole: " + role;
            s += "\nFloristID: " + floristID;
            return s;
        }
    }
}