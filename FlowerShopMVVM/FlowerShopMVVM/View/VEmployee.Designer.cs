namespace FlowerShopMVVM.View
{
    partial class VEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VEmployee));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            labelFlowerID = new Label();
            labelStock = new Label();
            labelPrice = new Label();
            labelColor = new Label();
            labelFlowerName = new Label();
            numericUpDownFlowerID = new NumericUpDown();
            textBoxFlowerName = new TextBox();
            textBoxStock = new TextBox();
            textBoxPrice = new TextBox();
            textBoxColor = new TextBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonLogout = new Button();
            buttonSaveDOC = new Button();
            buttonSaveXML = new Button();
            buttonSaveJSON = new Button();
            buttonSaveCSV = new Button();
            comboBoxOrderBy = new ComboBox();
            labelOrderBy = new Label();
            labelFilterBy = new Label();
            comboBoxFilterBy = new ComboBox();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            buttonSearch = new Button();
            buttonViewAll = new Button();
            dataGridViewFlowers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFlowerID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFlowers).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.avatar;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(4, 281);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(344, 318);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.employee_bubble;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(86, 137);
            pictureBox2.Margin = new Padding(5, 6, 5, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(545, 132);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // labelFlowerID
            // 
            labelFlowerID.AutoSize = true;
            labelFlowerID.BackColor = Color.Transparent;
            labelFlowerID.Font = new Font("Segoe Script", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFlowerID.ForeColor = Color.LightSalmon;
            labelFlowerID.Location = new Point(637, 132);
            labelFlowerID.Margin = new Padding(5, 0, 5, 0);
            labelFlowerID.Name = "labelFlowerID";
            labelFlowerID.Size = new Size(234, 67);
            labelFlowerID.TabIndex = 2;
            labelFlowerID.Text = "Flower ID";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.BackColor = Color.Transparent;
            labelStock.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            labelStock.ForeColor = Color.LightSalmon;
            labelStock.Location = new Point(637, 480);
            labelStock.Margin = new Padding(5, 0, 5, 0);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(140, 67);
            labelStock.TabIndex = 3;
            labelStock.Text = "Stock";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.BackColor = Color.Transparent;
            labelPrice.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            labelPrice.ForeColor = Color.LightSalmon;
            labelPrice.Location = new Point(637, 393);
            labelPrice.Margin = new Padding(5, 0, 5, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(140, 67);
            labelPrice.TabIndex = 4;
            labelPrice.Text = "Price";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.BackColor = Color.Transparent;
            labelColor.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            labelColor.ForeColor = Color.LightSalmon;
            labelColor.Location = new Point(637, 303);
            labelColor.Margin = new Padding(5, 0, 5, 0);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(144, 67);
            labelColor.TabIndex = 5;
            labelColor.Text = "Color";
            // 
            // labelFlowerName
            // 
            labelFlowerName.AutoSize = true;
            labelFlowerName.BackColor = Color.Transparent;
            labelFlowerName.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            labelFlowerName.ForeColor = Color.LightSalmon;
            labelFlowerName.Location = new Point(637, 215);
            labelFlowerName.Margin = new Padding(5, 0, 5, 0);
            labelFlowerName.Name = "labelFlowerName";
            labelFlowerName.Size = new Size(307, 67);
            labelFlowerName.TabIndex = 6;
            labelFlowerName.Text = "Flower Name";
            // 
            // numericUpDownFlowerID
            // 
            numericUpDownFlowerID.BackColor = Color.MistyRose;
            numericUpDownFlowerID.Font = new Font("Microsoft Sans Serif", 9F);
            numericUpDownFlowerID.Location = new Point(944, 141);
            numericUpDownFlowerID.Margin = new Padding(5, 6, 5, 6);
            numericUpDownFlowerID.Maximum = new decimal(new int[] { 4000000, 0, 0, 0 });
            numericUpDownFlowerID.Name = "numericUpDownFlowerID";
            numericUpDownFlowerID.Size = new Size(342, 35);
            numericUpDownFlowerID.TabIndex = 7;
            // 
            // textBoxFlowerName
            // 
            textBoxFlowerName.BackColor = Color.MistyRose;
            textBoxFlowerName.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxFlowerName.Location = new Point(944, 224);
            textBoxFlowerName.Margin = new Padding(5, 6, 5, 6);
            textBoxFlowerName.Name = "textBoxFlowerName";
            textBoxFlowerName.Size = new Size(338, 35);
            textBoxFlowerName.TabIndex = 8;
            // 
            // textBoxStock
            // 
            textBoxStock.BackColor = Color.MistyRose;
            textBoxStock.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxStock.Location = new Point(944, 490);
            textBoxStock.Margin = new Padding(5, 6, 5, 6);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(338, 35);
            textBoxStock.TabIndex = 9;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = Color.MistyRose;
            textBoxPrice.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxPrice.Location = new Point(944, 403);
            textBoxPrice.Margin = new Padding(5, 6, 5, 6);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(338, 35);
            textBoxPrice.TabIndex = 10;
            // 
            // textBoxColor
            // 
            textBoxColor.BackColor = Color.MistyRose;
            textBoxColor.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxColor.Location = new Point(944, 316);
            textBoxColor.Margin = new Padding(5, 6, 5, 6);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(338, 35);
            textBoxColor.TabIndex = 11;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.MistyRose;
            buttonAdd.Font = new Font("Segoe Script", 10F, FontStyle.Bold);
            buttonAdd.Location = new Point(637, 612);
            buttonAdd.Margin = new Padding(5, 6, 5, 6);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(160, 73);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.MistyRose;
            buttonDelete.Font = new Font("Segoe Script", 10F, FontStyle.Bold);
            buttonDelete.Location = new Point(1126, 612);
            buttonDelete.Margin = new Padding(5, 6, 5, 6);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(160, 73);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.MistyRose;
            buttonUpdate.Font = new Font("Segoe Script", 10F, FontStyle.Bold);
            buttonUpdate.Location = new Point(905, 612);
            buttonUpdate.Margin = new Padding(5, 6, 5, 6);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(160, 73);
            buttonUpdate.TabIndex = 14;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.MistyRose;
            buttonLogout.Font = new Font("Segoe Script", 10F, FontStyle.Bold);
            buttonLogout.Location = new Point(82, 612);
            buttonLogout.Margin = new Padding(5, 6, 5, 6);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(160, 73);
            buttonLogout.TabIndex = 15;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = false;
            // 
            // buttonSaveDOC
            // 
            buttonSaveDOC.BackColor = Color.MistyRose;
            buttonSaveDOC.Font = new Font("Segoe Script", 10F, FontStyle.Bold);
            buttonSaveDOC.Location = new Point(1589, 248);
            buttonSaveDOC.Margin = new Padding(5, 6, 5, 6);
            buttonSaveDOC.Name = "buttonSaveDOC";
            buttonSaveDOC.Size = new Size(194, 73);
            buttonSaveDOC.TabIndex = 16;
            buttonSaveDOC.Text = "SAVE DOC";
            buttonSaveDOC.UseVisualStyleBackColor = false;
            // 
            // buttonSaveXML
            // 
            buttonSaveXML.BackColor = Color.MistyRose;
            buttonSaveXML.Font = new Font("Segoe Script", 10F, FontStyle.Bold);
            buttonSaveXML.Location = new Point(1347, 248);
            buttonSaveXML.Margin = new Padding(5, 6, 5, 6);
            buttonSaveXML.Name = "buttonSaveXML";
            buttonSaveXML.Size = new Size(194, 73);
            buttonSaveXML.TabIndex = 17;
            buttonSaveXML.Text = "SAVE XML";
            buttonSaveXML.UseVisualStyleBackColor = false;
            // 
            // buttonSaveJSON
            // 
            buttonSaveJSON.BackColor = Color.MistyRose;
            buttonSaveJSON.Font = new Font("Segoe Script", 10F, FontStyle.Bold);
            buttonSaveJSON.Location = new Point(1589, 141);
            buttonSaveJSON.Margin = new Padding(5, 6, 5, 6);
            buttonSaveJSON.Name = "buttonSaveJSON";
            buttonSaveJSON.Size = new Size(194, 73);
            buttonSaveJSON.TabIndex = 18;
            buttonSaveJSON.Text = "SAVE JSON";
            buttonSaveJSON.UseVisualStyleBackColor = false;
            // 
            // buttonSaveCSV
            // 
            buttonSaveCSV.BackColor = Color.MistyRose;
            buttonSaveCSV.Font = new Font("Segoe Script", 10F, FontStyle.Bold);
            buttonSaveCSV.Location = new Point(1347, 141);
            buttonSaveCSV.Margin = new Padding(5, 6, 5, 6);
            buttonSaveCSV.Name = "buttonSaveCSV";
            buttonSaveCSV.Size = new Size(194, 73);
            buttonSaveCSV.TabIndex = 19;
            buttonSaveCSV.Text = "SAVE CSV";
            buttonSaveCSV.UseVisualStyleBackColor = false;
            // 
            // comboBoxOrderBy
            // 
            comboBoxOrderBy.BackColor = Color.MistyRose;
            comboBoxOrderBy.Font = new Font("Microsoft Sans Serif", 9F);
            comboBoxOrderBy.FormattingEnabled = true;
            comboBoxOrderBy.Items.AddRange(new object[] { "", "None", "Color and Price" });
            comboBoxOrderBy.Location = new Point(55, 806);
            comboBoxOrderBy.Margin = new Padding(5, 6, 5, 6);
            comboBoxOrderBy.Name = "comboBoxOrderBy";
            comboBoxOrderBy.Size = new Size(377, 37);
            comboBoxOrderBy.TabIndex = 20;
            comboBoxOrderBy.SelectedIndexChanged += comboBoxOrderBy_SelectedIndexChanged;
            // 
            // labelOrderBy
            // 
            labelOrderBy.AutoSize = true;
            labelOrderBy.BackColor = Color.Transparent;
            labelOrderBy.Font = new Font("Microsoft Sans Serif", 15F);
            labelOrderBy.ForeColor = Color.LightSalmon;
            labelOrderBy.Location = new Point(53, 742);
            labelOrderBy.Margin = new Padding(5, 0, 5, 0);
            labelOrderBy.Name = "labelOrderBy";
            labelOrderBy.Size = new Size(179, 46);
            labelOrderBy.TabIndex = 21;
            labelOrderBy.Text = "Order By";
            // 
            // labelFilterBy
            // 
            labelFilterBy.AutoSize = true;
            labelFilterBy.BackColor = Color.Transparent;
            labelFilterBy.Font = new Font("Microsoft Sans Serif", 15F);
            labelFilterBy.ForeColor = Color.LightSalmon;
            labelFilterBy.Location = new Point(465, 742);
            labelFilterBy.Margin = new Padding(5, 0, 5, 0);
            labelFilterBy.Name = "labelFilterBy";
            labelFilterBy.Size = new Size(166, 46);
            labelFilterBy.TabIndex = 23;
            labelFilterBy.Text = "Filter By";
            // 
            // comboBoxFilterBy
            // 
            comboBoxFilterBy.BackColor = Color.MistyRose;
            comboBoxFilterBy.Font = new Font("Microsoft Sans Serif", 9F);
            comboBoxFilterBy.FormattingEnabled = true;
            comboBoxFilterBy.Items.AddRange(new object[] { "", "Stock", "Price", "Color", "Availability" });
            comboBoxFilterBy.Location = new Point(468, 806);
            comboBoxFilterBy.Margin = new Padding(5, 6, 5, 6);
            comboBoxFilterBy.Name = "comboBoxFilterBy";
            comboBoxFilterBy.Size = new Size(377, 37);
            comboBoxFilterBy.TabIndex = 22;
            comboBoxFilterBy.SelectedIndexChanged += comboBoxFilterBy_SelectedIndexChanged;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.MistyRose;
            textBoxSearch.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxSearch.Location = new Point(906, 806);
            textBoxSearch.Margin = new Padding(5, 6, 5, 6);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(532, 35);
            textBoxSearch.TabIndex = 24;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.BackColor = Color.Transparent;
            labelSearch.Font = new Font("Microsoft Sans Serif", 15F);
            labelSearch.ForeColor = Color.LightSalmon;
            labelSearch.Location = new Point(906, 742);
            labelSearch.Margin = new Padding(5, 0, 5, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(453, 46);
            labelSearch.TabIndex = 25;
            labelSearch.Text = "Search Flower By Name";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.MistyRose;
            buttonSearch.Font = new Font("Segoe Script", 10F, FontStyle.Bold);
            buttonSearch.Location = new Point(1461, 785);
            buttonSearch.Margin = new Padding(5, 6, 5, 6);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(160, 73);
            buttonSearch.TabIndex = 27;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // buttonViewAll
            // 
            buttonViewAll.BackColor = Color.MistyRose;
            buttonViewAll.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            buttonViewAll.Location = new Point(1648, 785);
            buttonViewAll.Margin = new Padding(5, 6, 5, 6);
            buttonViewAll.Name = "buttonViewAll";
            buttonViewAll.Size = new Size(160, 73);
            buttonViewAll.TabIndex = 26;
            buttonViewAll.Text = "VIEW ALL";
            buttonViewAll.UseVisualStyleBackColor = false;
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
            dataGridViewFlowers.GridColor = Color.DarkGray;
            dataGridViewFlowers.Location = new Point(55, 870);
            dataGridViewFlowers.Margin = new Padding(5, 6, 5, 6);
            dataGridViewFlowers.Name = "dataGridViewFlowers";
            dataGridViewFlowers.RowHeadersWidth = 62;
            dataGridViewFlowers.Size = new Size(1754, 644);
            dataGridViewFlowers.TabIndex = 28;
            dataGridViewFlowers.SelectionChanged += DataGridViewFlowers_SelectionChanged;
            // 
            // VEmployee
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            BackgroundImage = Properties.Resources.defaultBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1529);
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
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
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
            Name = "VEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeGUI";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFlowerID).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFlowers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelFlowerID;
        private Label labelStock;
        private Label labelPrice;
        private Label labelColor;
        private Label labelFlowerName;
        private NumericUpDown numericUpDownFlowerID;
        private TextBox textBoxFlowerName;
        private TextBox textBoxStock;
        private TextBox textBoxPrice;
        private TextBox textBoxColor;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonLogout;
        private Button buttonSaveDOC;
        private Button buttonSaveXML;
        private Button buttonSaveJSON;
        private Button buttonSaveCSV;
        private ComboBox comboBoxOrderBy;
        private Label labelOrderBy;
        private Label labelFilterBy;
        private ComboBox comboBoxFilterBy;
        private TextBox textBoxSearch;
        private Label labelSearch;
        private Button buttonSearch;
        private Button buttonViewAll;
        private DataGridView dataGridViewFlowers;
    }
}