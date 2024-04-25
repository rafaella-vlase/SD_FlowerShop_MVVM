namespace FlowerShopMVVM.View
{
    partial class VLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VLogin));
            labelLoginFlowerShop = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // labelLoginFlowerShop
            // 
            labelLoginFlowerShop.AutoSize = true;
            labelLoginFlowerShop.BackColor = Color.Transparent;
            labelLoginFlowerShop.Font = new Font("Segoe Script", 40F, FontStyle.Bold | FontStyle.Italic);
            labelLoginFlowerShop.ForeColor = Color.DarkSlateBlue;
            labelLoginFlowerShop.Location = new Point(559, 196);
            labelLoginFlowerShop.Margin = new Padding(5, 0, 5, 0);
            labelLoginFlowerShop.Name = "labelLoginFlowerShop";
            labelLoginFlowerShop.Size = new Size(776, 177);
            labelLoginFlowerShop.TabIndex = 0;
            labelLoginFlowerShop.Text = "Flower Shop";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.Transparent;
            labelUsername.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(428, 580);
            labelUsername.Margin = new Padding(5, 0, 5, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(331, 90);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold);
            labelPassword.Location = new Point(428, 745);
            labelPassword.Margin = new Padding(5, 0, 5, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(323, 90);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.FromArgb(250, 254, 238);
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("Segoe Script", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(784, 589);
            textBoxUsername.Margin = new Padding(5, 6, 5, 6);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(632, 84);
            textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(250, 254, 238);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxPassword.Location = new Point(784, 771);
            textBoxPassword.Margin = new Padding(5, 6, 5, 6);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(632, 28);
            textBoxPassword.TabIndex = 4;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(1, 173, 97);
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.Black;
            buttonLogin.Location = new Point(759, 890);
            buttonLogin.Margin = new Padding(5, 6, 5, 6);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(333, 99);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // VLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loginBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1845, 1475);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelLoginFlowerShop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "VLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginGUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLoginFlowerShop;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogin;
    }
}