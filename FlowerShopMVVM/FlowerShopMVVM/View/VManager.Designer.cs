namespace FlowerShopMVVM.View
{
    partial class VManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VManager));
            dataGridViewFlowers = new DataGridView();
            buttonSearch = new Button();
            buttonViewAll = new Button();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            labelFilterBy = new Label();
            comboBoxFilterBy = new ComboBox();
            labelOrderBy = new Label();
            comboBoxOrderBy = new ComboBox();
            buttonSaveCSV = new Button();
            buttonSaveJSON = new Button();
            buttonSaveXML = new Button();
            buttonSaveDOC = new Button();
            buttonLogout = new Button();
            textBoxColor = new TextBox();
            textBoxPrice = new TextBox();
            textBoxStock = new TextBox();
            textBoxFlowerName = new TextBox();
            numericUpDownFlowerID = new NumericUpDown();
            labelFlowerName = new Label();
            labelColor = new Label();
            labelPrice = new Label();
            labelStock = new Label();
            labelFlowerID = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            numericUpDownShopID = new NumericUpDown();
            labelShopID = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFlowers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFlowerID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShopID).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFlowers
            // 
            dataGridViewFlowers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFlowers.BackgroundColor = Color.MistyRose;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MistyRose;
            dataGridViewCellStyle1.Font = new Font("Segoe Script", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewFlowers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewFlowers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MistyRose;
            dataGridViewCellStyle2.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewFlowers.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewFlowers.Location = new Point(109, 852);
            dataGridViewFlowers.Margin = new Padding(5, 6, 5, 6);
            dataGridViewFlowers.Name = "dataGridViewFlowers";
            dataGridViewFlowers.RowHeadersWidth = 62;
            dataGridViewFlowers.Size = new Size(1755, 662);
            dataGridViewFlowers.TabIndex = 57;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.MistyRose;
            buttonSearch.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            buttonSearch.Location = new Point(1517, 748);
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
            buttonViewAll.Location = new Point(1704, 748);
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
            labelSearch.Location = new Point(962, 718);
            labelSearch.Margin = new Padding(5, 0, 5, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(528, 67);
            labelSearch.TabIndex = 54;
            labelSearch.Text = "Search Flower By Name";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.MistyRose;
            textBoxSearch.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxSearch.Location = new Point(962, 782);
            textBoxSearch.Margin = new Padding(5, 6, 5, 6);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(532, 35);
            textBoxSearch.TabIndex = 53;
            // 
            // labelFilterBy
            // 
            labelFilterBy.AutoSize = true;
            labelFilterBy.BackColor = Color.Transparent;
            labelFilterBy.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            labelFilterBy.ForeColor = Color.LightSalmon;
            labelFilterBy.Location = new Point(521, 718);
            labelFilterBy.Margin = new Padding(5, 0, 5, 0);
            labelFilterBy.Name = "labelFilterBy";
            labelFilterBy.Size = new Size(219, 67);
            labelFilterBy.TabIndex = 52;
            labelFilterBy.Text = "Filter By";
            // 
            // comboBoxFilterBy
            // 
            comboBoxFilterBy.BackColor = Color.MistyRose;
            comboBoxFilterBy.Font = new Font("Microsoft Sans Serif", 9F);
            comboBoxFilterBy.FormattingEnabled = true;
            comboBoxFilterBy.Items.AddRange(new object[] { "", "Quantity", "Price", "Color", "Availability", "Flower Shop" });
            comboBoxFilterBy.Location = new Point(523, 782);
            comboBoxFilterBy.Margin = new Padding(5, 6, 5, 6);
            comboBoxFilterBy.Name = "comboBoxFilterBy";
            comboBoxFilterBy.Size = new Size(377, 37);
            comboBoxFilterBy.TabIndex = 51;
            comboBoxFilterBy.SelectedIndexChanged += comboBoxFilterBy_SelectedIndexChanged;
            // 
            // labelOrderBy
            // 
            labelOrderBy.AutoSize = true;
            labelOrderBy.BackColor = Color.Transparent;
            labelOrderBy.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            labelOrderBy.ForeColor = Color.LightSalmon;
            labelOrderBy.Location = new Point(109, 718);
            labelOrderBy.Margin = new Padding(5, 0, 5, 0);
            labelOrderBy.Name = "labelOrderBy";
            labelOrderBy.Size = new Size(223, 67);
            labelOrderBy.TabIndex = 50;
            labelOrderBy.Text = "Order By";
            // 
            // comboBoxOrderBy
            // 
            comboBoxOrderBy.BackColor = Color.MistyRose;
            comboBoxOrderBy.Font = new Font("Microsoft Sans Serif", 9F);
            comboBoxOrderBy.FormattingEnabled = true;
            comboBoxOrderBy.Items.AddRange(new object[] { "", "None", "Color and Price" });
            comboBoxOrderBy.Location = new Point(110, 782);
            comboBoxOrderBy.Margin = new Padding(5, 6, 5, 6);
            comboBoxOrderBy.Name = "comboBoxOrderBy";
            comboBoxOrderBy.Size = new Size(377, 37);
            comboBoxOrderBy.TabIndex = 49;
            comboBoxOrderBy.SelectedIndexChanged += comboBoxOrderBy_SelectedIndexChanged;
            // 
            // buttonSaveCSV
            // 
            buttonSaveCSV.BackColor = Color.MistyRose;
            buttonSaveCSV.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            buttonSaveCSV.Location = new Point(1446, 124);
            buttonSaveCSV.Margin = new Padding(5, 6, 5, 6);
            buttonSaveCSV.Name = "buttonSaveCSV";
            buttonSaveCSV.Size = new Size(186, 73);
            buttonSaveCSV.TabIndex = 48;
            buttonSaveCSV.Text = "SAVE CSV";
            buttonSaveCSV.UseVisualStyleBackColor = false;
            // 
            // buttonSaveJSON
            // 
            buttonSaveJSON.BackColor = Color.MistyRose;
            buttonSaveJSON.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            buttonSaveJSON.Location = new Point(1678, 127);
            buttonSaveJSON.Margin = new Padding(5, 6, 5, 6);
            buttonSaveJSON.Name = "buttonSaveJSON";
            buttonSaveJSON.Size = new Size(186, 73);
            buttonSaveJSON.TabIndex = 47;
            buttonSaveJSON.Text = "SAVE JSON";
            buttonSaveJSON.UseVisualStyleBackColor = false;
            // 
            // buttonSaveXML
            // 
            buttonSaveXML.BackColor = Color.MistyRose;
            buttonSaveXML.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            buttonSaveXML.Location = new Point(1446, 234);
            buttonSaveXML.Margin = new Padding(5, 6, 5, 6);
            buttonSaveXML.Name = "buttonSaveXML";
            buttonSaveXML.Size = new Size(186, 73);
            buttonSaveXML.TabIndex = 46;
            buttonSaveXML.Text = "SAVE XML";
            buttonSaveXML.UseVisualStyleBackColor = false;
            // 
            // buttonSaveDOC
            // 
            buttonSaveDOC.BackColor = Color.MistyRose;
            buttonSaveDOC.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            buttonSaveDOC.Location = new Point(1678, 234);
            buttonSaveDOC.Margin = new Padding(5, 6, 5, 6);
            buttonSaveDOC.Name = "buttonSaveDOC";
            buttonSaveDOC.Size = new Size(186, 73);
            buttonSaveDOC.TabIndex = 45;
            buttonSaveDOC.Text = "SAVE DOC";
            buttonSaveDOC.UseVisualStyleBackColor = false;
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
            // textBoxColor
            // 
            textBoxColor.BackColor = Color.MistyRose;
            textBoxColor.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxColor.Location = new Point(1000, 301);
            textBoxColor.Margin = new Padding(5, 6, 5, 6);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(338, 35);
            textBoxColor.TabIndex = 40;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = Color.MistyRose;
            textBoxPrice.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxPrice.Location = new Point(1000, 388);
            textBoxPrice.Margin = new Padding(5, 6, 5, 6);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(338, 35);
            textBoxPrice.TabIndex = 39;
            // 
            // textBoxStock
            // 
            textBoxStock.BackColor = Color.MistyRose;
            textBoxStock.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxStock.Location = new Point(1000, 476);
            textBoxStock.Margin = new Padding(5, 6, 5, 6);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(338, 35);
            textBoxStock.TabIndex = 38;
            // 
            // textBoxFlowerName
            // 
            textBoxFlowerName.BackColor = Color.MistyRose;
            textBoxFlowerName.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxFlowerName.Location = new Point(1000, 209);
            textBoxFlowerName.Margin = new Padding(5, 6, 5, 6);
            textBoxFlowerName.Name = "textBoxFlowerName";
            textBoxFlowerName.Size = new Size(338, 35);
            textBoxFlowerName.TabIndex = 37;
            // 
            // numericUpDownFlowerID
            // 
            numericUpDownFlowerID.BackColor = Color.MistyRose;
            numericUpDownFlowerID.Font = new Font("Microsoft Sans Serif", 9F);
            numericUpDownFlowerID.Location = new Point(1000, 125);
            numericUpDownFlowerID.Margin = new Padding(5, 6, 5, 6);
            numericUpDownFlowerID.Maximum = new decimal(new int[] { 4000000, 0, 0, 0 });
            numericUpDownFlowerID.Name = "numericUpDownFlowerID";
            numericUpDownFlowerID.Size = new Size(342, 35);
            numericUpDownFlowerID.TabIndex = 36;
            // 
            // labelFlowerName
            // 
            labelFlowerName.AutoSize = true;
            labelFlowerName.BackColor = Color.Transparent;
            labelFlowerName.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            labelFlowerName.ForeColor = Color.LightSalmon;
            labelFlowerName.Location = new Point(693, 201);
            labelFlowerName.Margin = new Padding(5, 0, 5, 0);
            labelFlowerName.Name = "labelFlowerName";
            labelFlowerName.Size = new Size(307, 67);
            labelFlowerName.TabIndex = 35;
            labelFlowerName.Text = "Flower Name";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.BackColor = Color.Transparent;
            labelColor.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            labelColor.ForeColor = Color.LightSalmon;
            labelColor.Location = new Point(693, 288);
            labelColor.Margin = new Padding(5, 0, 5, 0);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(144, 67);
            labelColor.TabIndex = 34;
            labelColor.Text = "Color";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.BackColor = Color.Transparent;
            labelPrice.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            labelPrice.ForeColor = Color.LightSalmon;
            labelPrice.Location = new Point(693, 378);
            labelPrice.Margin = new Padding(5, 0, 5, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(140, 67);
            labelPrice.TabIndex = 33;
            labelPrice.Text = "Price";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.BackColor = Color.Transparent;
            labelStock.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            labelStock.ForeColor = Color.LightSalmon;
            labelStock.Location = new Point(693, 465);
            labelStock.Margin = new Padding(5, 0, 5, 0);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(140, 67);
            labelStock.TabIndex = 32;
            labelStock.Text = "Stock";
            // 
            // labelFlowerID
            // 
            labelFlowerID.AutoSize = true;
            labelFlowerID.BackColor = Color.Transparent;
            labelFlowerID.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            labelFlowerID.ForeColor = Color.LightSalmon;
            labelFlowerID.Location = new Point(693, 118);
            labelFlowerID.Margin = new Padding(5, 0, 5, 0);
            labelFlowerID.Name = "labelFlowerID";
            labelFlowerID.Size = new Size(234, 67);
            labelFlowerID.TabIndex = 31;
            labelFlowerID.Text = "Flower ID";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.manager_bubble;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(129, 166);
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
            pictureBox1.Location = new Point(71, 301);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 284);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // numericUpDownShopID
            // 
            numericUpDownShopID.BackColor = Color.MistyRose;
            numericUpDownShopID.Font = new Font("Microsoft Sans Serif", 9F);
            numericUpDownShopID.Location = new Point(1000, 561);
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
            labelShopID.Location = new Point(693, 553);
            labelShopID.Margin = new Padding(5, 0, 5, 0);
            labelShopID.Name = "labelShopID";
            labelShopID.Size = new Size(197, 67);
            labelShopID.TabIndex = 58;
            labelShopID.Text = "Shop ID";
            // 
            // VManager
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            BackgroundImage = Properties.Resources.defaultBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1529);
            Controls.Add(numericUpDownShopID);
            Controls.Add(labelShopID);
            Controls.Add(dataGridViewFlowers);
            Controls.Add(buttonSearch);
            Controls.Add(buttonViewAll);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(labelFilterBy);
            Controls.Add(comboBoxFilterBy);
            Controls.Add(labelOrderBy);
            Controls.Add(comboBoxOrderBy);
            Controls.Add(buttonSaveCSV);
            Controls.Add(buttonSaveJSON);
            Controls.Add(buttonSaveXML);
            Controls.Add(buttonSaveDOC);
            Controls.Add(buttonLogout);
            Controls.Add(textBoxColor);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxStock);
            Controls.Add(textBoxFlowerName);
            Controls.Add(numericUpDownFlowerID);
            Controls.Add(labelFlowerName);
            Controls.Add(labelColor);
            Controls.Add(labelPrice);
            Controls.Add(labelStock);
            Controls.Add(labelFlowerID);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "VManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerGUI";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFlowers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFlowerID).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShopID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewFlowers;
        private Button buttonSearch;
        private Button buttonViewAll;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private Label labelFilterBy;
        private ComboBox comboBoxFilterBy;
        private Label labelOrderBy;
        private ComboBox comboBoxOrderBy;
        private Button buttonSaveCSV;
        private Button buttonSaveJSON;
        private Button buttonSaveXML;
        private Button buttonSaveDOC;
        private Button buttonLogout;
        private TextBox textBoxColor;
        private TextBox textBoxPrice;
        private TextBox textBoxStock;
        private TextBox textBoxFlowerName;
        private NumericUpDown numericUpDownFlowerID;
        private Label labelFlowerName;
        private Label labelColor;
        private Label labelPrice;
        private Label labelStock;
        private Label labelFlowerID;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private NumericUpDown numericUpDownShopID;
        private Label labelShopID;
    }
}