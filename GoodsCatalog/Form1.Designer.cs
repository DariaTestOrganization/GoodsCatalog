
namespace GoodsCatalog
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCatItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCatItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCatItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProducerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProducerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProducerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProductItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.producerBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.productQuantity = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.stonesToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.programToolStripMenuItem.Text = "&Program";
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(93, 22);
            this.exitItem.Text = "Exit";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCatItem,
            this.updateCatItem,
            this.deleteCatItem});
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.categoriesToolStripMenuItem.Text = "&Categories";
            // 
            // createCatItem
            // 
            this.createCatItem.Name = "createCatItem";
            this.createCatItem.Size = new System.Drawing.Size(161, 22);
            this.createCatItem.Text = "&Create category";
            // 
            // updateCatItem
            // 
            this.updateCatItem.Name = "updateCatItem";
            this.updateCatItem.Size = new System.Drawing.Size(161, 22);
            this.updateCatItem.Text = "&Update category";
            // 
            // deleteCatItem
            // 
            this.deleteCatItem.Name = "deleteCatItem";
            this.deleteCatItem.Size = new System.Drawing.Size(161, 22);
            this.deleteCatItem.Text = "&Delete category";
            // 
            // stonesToolStripMenuItem
            // 
            this.stonesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProducerItem,
            this.updateProducerItem,
            this.deleteProducerItem});
            this.stonesToolStripMenuItem.Name = "stonesToolStripMenuItem";
            this.stonesToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.stonesToolStripMenuItem.Text = "&Producers";
            // 
            // createProducerItem
            // 
            this.createProducerItem.Name = "createProducerItem";
            this.createProducerItem.Size = new System.Drawing.Size(163, 22);
            this.createProducerItem.Text = "&Create producer";
            // 
            // updateProducerItem
            // 
            this.updateProducerItem.Name = "updateProducerItem";
            this.updateProducerItem.Size = new System.Drawing.Size(163, 22);
            this.updateProducerItem.Text = "&Update producer";
            // 
            // deleteProducerItem
            // 
            this.deleteProducerItem.Name = "deleteProducerItem";
            this.deleteProducerItem.Size = new System.Drawing.Size(163, 22);
            this.deleteProducerItem.Text = "&Delete producer";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProductItem,
            this.updateProductItem,
            this.deleteProductItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.productsToolStripMenuItem.Text = "&Products";
            // 
            // createProductItem
            // 
            this.createProductItem.Name = "createProductItem";
            this.createProductItem.Size = new System.Drawing.Size(157, 22);
            this.createProductItem.Text = "&Create product";
            // 
            // updateProductItem
            // 
            this.updateProductItem.Name = "updateProductItem";
            this.updateProductItem.Size = new System.Drawing.Size(157, 22);
            this.updateProductItem.Text = "&Update product";
            // 
            // deleteProductItem
            // 
            this.deleteProductItem.Name = "deleteProductItem";
            this.deleteProductItem.Size = new System.Drawing.Size(157, 22);
            this.deleteProductItem.Text = "&Delete product";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // aboutUsItem
            // 
            this.aboutUsItem.Name = "aboutUsItem";
            this.aboutUsItem.Size = new System.Drawing.Size(122, 22);
            this.aboutUsItem.Text = "&About us";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoodsCatalog.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(141, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Автоматизированная система \r\nуправления каталогом товаров";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectButton);
            this.groupBox1.Controls.Add(this.priceBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.producerBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.categoryBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Size = new System.Drawing.Size(187, 246);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры выборки товаров";
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(45, 208);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(97, 23);
            this.selectButton.TabIndex = 6;
            this.selectButton.Text = "Применить";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // priceBox
            // 
            this.priceBox.FormattingEnabled = true;
            this.priceBox.Location = new System.Drawing.Point(13, 166);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(114, 25);
            this.priceBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Цена";
            // 
            // producerBox
            // 
            this.producerBox.FormattingEnabled = true;
            this.producerBox.Location = new System.Drawing.Point(13, 110);
            this.producerBox.Name = "producerBox";
            this.producerBox.Size = new System.Drawing.Size(114, 25);
            this.producerBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Производитель";
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(13, 52);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(114, 25);
            this.categoryBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Категория";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.productsListView);
            this.groupBox2.Location = new System.Drawing.Point(205, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 246);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список товаров";
            // 
            // productsListView
            // 
            this.productsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.productsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsListView.HideSelection = false;
            this.productsListView.Location = new System.Drawing.Point(3, 20);
            this.productsListView.Name = "productsListView";
            this.productsListView.Size = new System.Drawing.Size(563, 223);
            this.productsListView.TabIndex = 0;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            this.productsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Наименование";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Цена";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Количество";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ед измерения";
            this.columnHeader4.Width = 104;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Срок хранения";
            this.columnHeader5.Width = 96;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Доставка";
            this.columnHeader6.Width = 68;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buyButton);
            this.groupBox3.Controls.Add(this.productQuantity);
            this.groupBox3.Controls.Add(this.productPrice);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.productName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 416);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(762, 80);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация о товаре";
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(624, 32);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(122, 23);
            this.buyButton.TabIndex = 7;
            this.buyButton.Text = "Заказать товар";
            this.buyButton.UseVisualStyleBackColor = true;
            // 
            // productQuantity
            // 
            this.productQuantity.Location = new System.Drawing.Point(506, 31);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(87, 24);
            this.productQuantity.TabIndex = 6;
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(310, 30);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(87, 24);
            this.productPrice.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Цена";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(111, 31);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(130, 24);
            this.productName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Наименование:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 506);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автоматизированный каталог товаров";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCatItem;
        private System.Windows.Forms.ToolStripMenuItem updateCatItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCatItem;
        private System.Windows.Forms.ToolStripMenuItem stonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProducerItem;
        private System.Windows.Forms.ToolStripMenuItem updateProducerItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProducerItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProductItem;
        private System.Windows.Forms.ToolStripMenuItem updateProductItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.ComboBox priceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox producerBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.ListView productsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.TextBox productQuantity;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.ToolStripMenuItem aboutUsItem;
    }
}

