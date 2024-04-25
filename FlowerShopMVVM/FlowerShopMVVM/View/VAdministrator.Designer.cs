namespace FlowerShopMVVM.View
{
    partial class VAdministrator
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VAdministrator));
            dataGridViewUsers = new DataGridView();
            buttonSearch = new Button();
            buttonViewAll = new Button();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            buttonLogout = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonAdd = new Button();
            textBoxPassword = new TextBox();
            textBoxRole = new TextBox();
            textBoxUsername = new TextBox();
            numericUpDownUserID = new NumericUpDown();
            labelUsername = new Label();
            labelPassword = new Label();
            labelRole = new Label();
            labelUserID = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            numericUpDownShopID = new NumericUpDown();
            labelShopID = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUserID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShopID).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = Color.MistyRose;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MistyRose;
            dataGridViewCellStyle1.Font = new Font("Segoe Script", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MistyRose;
            dataGridViewCellStyle2.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewUsers.Location = new Point(57, 754);
            dataGridViewUsers.Margin = new Padding(5, 6, 5, 6);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 62;
            dataGridViewUsers.Size = new Size(1815, 755);
            dataGridViewUsers.TabIndex = 57;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.MistyRose;
            buttonSearch.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            buttonSearch.Location = new Point(970, 607);
            buttonSearch.Margin = new Padding(5, 6, 5, 6);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(160, 73);
            buttonSearch.TabIndex = 56;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // buttonViewAll
            // 
            buttonViewAll.BackColor = Color.MistyRose;
            buttonViewAll.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            buttonViewAll.Location = new Point(1158, 607);
            buttonViewAll.Margin = new Padding(5, 6, 5, 6);
            buttonViewAll.Name = "buttonViewAll";
            buttonViewAll.Size = new Size(160, 73);
            buttonViewAll.TabIndex = 55;
            buttonViewAll.Text = "VIEW ALL";
            buttonViewAll.UseVisualStyleBackColor = false;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.BackColor = Color.Transparent;
            labelSearch.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            labelSearch.ForeColor = Color.LightSalmon;
            labelSearch.Location = new Point(415, 564);
            labelSearch.Margin = new Padding(5, 0, 5, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(449, 67);
            labelSearch.TabIndex = 54;
            labelSearch.Text = "Search User By Role";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.MistyRose;
            textBoxSearch.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxSearch.Location = new Point(415, 628);
            textBoxSearch.Margin = new Padding(5, 6, 5, 6);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(532, 35);
            textBoxSearch.TabIndex = 53;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.MistyRose;
            buttonLogout.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            buttonLogout.Location = new Point(138, 598);
            buttonLogout.Margin = new Padding(5, 6, 5, 6);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(160, 73);
            buttonLogout.TabIndex = 44;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.MistyRose;
            buttonUpdate.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            buttonUpdate.Location = new Point(1533, 607);
            buttonUpdate.Margin = new Padding(5, 6, 5, 6);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(160, 73);
            buttonUpdate.TabIndex = 43;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.MistyRose;
            buttonDelete.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            buttonDelete.Location = new Point(1712, 607);
            buttonDelete.Margin = new Padding(5, 6, 5, 6);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(160, 73);
            buttonDelete.TabIndex = 42;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.MistyRose;
            buttonAdd.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            buttonAdd.Location = new Point(1353, 607);
            buttonAdd.Margin = new Padding(5, 6, 5, 6);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(160, 73);
            buttonAdd.TabIndex = 41;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.MistyRose;
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxPassword.Location = new Point(1000, 301);
            textBoxPassword.Margin = new Padding(5, 6, 5, 6);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(338, 35);
            textBoxPassword.TabIndex = 40;
            // 
            // textBoxRole
            // 
            textBoxRole.BackColor = Color.MistyRose;
            textBoxRole.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxRole.Location = new Point(1000, 388);
            textBoxRole.Margin = new Padding(5, 6, 5, 6);
            textBoxRole.Name = "textBoxRole";
            textBoxRole.Size = new Size(338, 35);
            textBoxRole.TabIndex = 39;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.MistyRose;
            textBoxUsername.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxUsername.Location = new Point(1000, 209);
            textBoxUsername.Margin = new Padding(5, 6, 5, 6);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(338, 35);
            textBoxUsername.TabIndex = 37;
            // 
            // numericUpDownUserID
            // 
            numericUpDownUserID.BackColor = Color.MistyRose;
            numericUpDownUserID.Font = new Font("Microsoft Sans Serif", 9F);
            numericUpDownUserID.Location = new Point(1000, 125);
            numericUpDownUserID.Margin = new Padding(5, 6, 5, 6);
            numericUpDownUserID.Maximum = new decimal(new int[] { 4000000, 0, 0, 0 });
            numericUpDownUserID.Name = "numericUpDownUserID";
            numericUpDownUserID.Size = new Size(342, 35);
            numericUpDownUserID.TabIndex = 36;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.Transparent;
            labelUsername.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            labelUsername.ForeColor = Color.LightSalmon;
            labelUsername.Location = new Point(693, 201);
            labelUsername.Margin = new Padding(5, 0, 5, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(234, 67);
            labelUsername.TabIndex = 35;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            labelPassword.ForeColor = Color.LightSalmon;
            labelPassword.Location = new Point(693, 288);
            labelPassword.Margin = new Padding(5, 0, 5, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(228, 67);
            labelPassword.TabIndex = 34;
            labelPassword.Text = "Password";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.BackColor = Color.Transparent;
            labelRole.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            labelRole.ForeColor = Color.LightSalmon;
            labelRole.Location = new Point(693, 378);
            labelRole.Margin = new Padding(5, 0, 5, 0);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(122, 67);
            labelRole.TabIndex = 33;
            labelRole.Text = "Role";
            // 
            // labelUserID
            // 
            labelUserID.AutoSize = true;
            labelUserID.BackColor = Color.Transparent;
            labelUserID.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            labelUserID.ForeColor = Color.LightSalmon;
            labelUserID.Location = new Point(693, 118);
            labelUserID.Margin = new Padding(5, 0, 5, 0);
            labelUserID.Name = "labelUserID";
            labelUserID.Size = new Size(182, 67);
            labelUserID.TabIndex = 31;
            labelUserID.Text = "User ID";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.admin_bubble;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(121, 136);
            pictureBox2.Margin = new Padding(5, 6, 5, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(545, 132);
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.avatar;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(51, 272);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 313);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // numericUpDownShopID
            // 
            numericUpDownShopID.BackColor = Color.MistyRose;
            numericUpDownShopID.Font = new Font("Microsoft Sans Serif", 9F);
            numericUpDownShopID.Location = new Point(1000, 471);
            numericUpDownShopID.Margin = new Padding(5, 6, 5, 6);
            numericUpDownShopID.Maximum = new decimal(new int[] { 4000000, 0, 0, 0 });
            numericUpDownShopID.Name = "numericUpDownShopID";
            numericUpDownShopID.Size = new Size(342, 35);
            numericUpDownShopID.TabIndex = 59;
            // 
            // labelShopID
            // 
            labelShopID.AutoSize = true;
            labelShopID.BackColor = Color.Transparent;
            labelShopID.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            labelShopID.ForeColor = Color.LightSalmon;
            labelShopID.Location = new Point(693, 463);
            labelShopID.Margin = new Padding(5, 0, 5, 0);
            labelShopID.Name = "labelShopID";
            labelShopID.Size = new Size(197, 67);
            labelShopID.TabIndex = 58;
            labelShopID.Text = "Shop ID";
            // 
            // VAdministrator
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.defaultBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1529);
            Controls.Add(numericUpDownShopID);
            Controls.Add(labelShopID);
            Controls.Add(dataGridViewUsers);
            Controls.Add(buttonSearch);
            Controls.Add(buttonViewAll);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonLogout);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxRole);
            Controls.Add(textBoxUsername);
            Controls.Add(numericUpDownUserID);
            Controls.Add(labelUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelRole);
            Controls.Add(labelUserID);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "VAdministrator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdministratorGUI";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUserID).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShopID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Button buttonSearch;
        private Button buttonViewAll;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private Button buttonLogout;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonAdd;
        private TextBox textBoxPassword;
        private TextBox textBoxRole;
        private TextBox textBoxUsername;
        private NumericUpDown numericUpDownUserID;
        private Label labelUsername;
        private Label labelPassword;
        private Label labelRole;
        private Label labelUserID;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private NumericUpDown numericUpDownShopID;
        private Label labelShopID;
    }
}