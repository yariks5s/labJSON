namespace Task5_WinformsApp
{
    partial class Form1
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
            this.addBook1Button = new System.Windows.Forms.Button();
            this.addBook2Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addProduct1Button = new System.Windows.Forms.Button();
            this.addProduct2Button = new System.Windows.Forms.Button();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.deleteFirstButton = new System.Windows.Forms.Button();
            this.deleteLastButton = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxDateOfPack = new System.Windows.Forms.TextBox();
            this.textBoxQuantityOfPage = new System.Windows.Forms.TextBox();
            this.textBoxPublishHouse = new System.Windows.Forms.TextBox();
            this.textBoxAuthors = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxExpDate = new System.Windows.Forms.TextBox();
            this.textBoxUnits = new System.Windows.Forms.TextBox();
            this.showCustomTextBoxButton = new System.Windows.Forms.Button();
            this.hideInputButton = new System.Windows.Forms.Button();
            this.acceptInputButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addBook1Button
            // 
            this.addBook1Button.Location = new System.Drawing.Point(16, 419);
            this.addBook1Button.Name = "addBook1Button";
            this.addBook1Button.Size = new System.Drawing.Size(145, 59);
            this.addBook1Button.TabIndex = 1;
            this.addBook1Button.Text = "Add Book1";
            this.addBook1Button.UseVisualStyleBackColor = true;
            this.addBook1Button.Click += new System.EventHandler(this.AddBook1ButtonClick);
            // 
            // addBook2Button
            // 
            this.addBook2Button.Location = new System.Drawing.Point(180, 419);
            this.addBook2Button.Name = "addBook2Button";
            this.addBook2Button.Size = new System.Drawing.Size(143, 59);
            this.addBook2Button.TabIndex = 2;
            this.addBook2Button.Text = "Add Book2";
            this.addBook2Button.UseVisualStyleBackColor = true;
            this.addBook2Button.Click += new System.EventHandler(this.AddBook2ButtonClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1516, 271);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // addProduct1Button
            // 
            this.addProduct1Button.Location = new System.Drawing.Point(341, 419);
            this.addProduct1Button.Name = "addProduct1Button";
            this.addProduct1Button.Size = new System.Drawing.Size(141, 59);
            this.addProduct1Button.TabIndex = 4;
            this.addProduct1Button.Text = "Add Product1";
            this.addProduct1Button.UseVisualStyleBackColor = true;
            this.addProduct1Button.Click += new System.EventHandler(this.AddItem1ButtonClick);
            // 
            // addProduct2Button
            // 
            this.addProduct2Button.Location = new System.Drawing.Point(502, 419);
            this.addProduct2Button.Name = "addProduct2Button";
            this.addProduct2Button.Size = new System.Drawing.Size(140, 59);
            this.addProduct2Button.TabIndex = 5;
            this.addProduct2Button.Text = "Add Product2";
            this.addProduct2Button.UseVisualStyleBackColor = true;
            this.addProduct2Button.Click += new System.EventHandler(this.AddItem2ButtonClick);
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.Location = new System.Drawing.Point(648, 419);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(133, 59);
            this.deleteSelectedButton.TabIndex = 6;
            this.deleteSelectedButton.Text = "Delete selected";
            this.deleteSelectedButton.UseVisualStyleBackColor = true;
            this.deleteSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButtonClick);
            // 
            // deleteFirstButton
            // 
            this.deleteFirstButton.Location = new System.Drawing.Point(798, 419);
            this.deleteFirstButton.Name = "deleteFirstButton";
            this.deleteFirstButton.Size = new System.Drawing.Size(127, 59);
            this.deleteFirstButton.TabIndex = 7;
            this.deleteFirstButton.Text = "Delete first";
            this.deleteFirstButton.UseVisualStyleBackColor = true;
            this.deleteFirstButton.Click += new System.EventHandler(this.RemoveFirstButtonClick);
            // 
            // deleteLastButton
            // 
            this.deleteLastButton.Location = new System.Drawing.Point(942, 419);
            this.deleteLastButton.Name = "deleteLastButton";
            this.deleteLastButton.Size = new System.Drawing.Size(125, 59);
            this.deleteLastButton.TabIndex = 8;
            this.deleteLastButton.Text = "Delete last";
            this.deleteLastButton.UseVisualStyleBackColor = true;
            this.deleteLastButton.Click += new System.EventHandler(this.RemoveLastButtonClick);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(76, 87);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(208, 87);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 10;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(341, 87);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(100, 22);
            this.textBoxCountry.TabIndex = 11;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(482, 87);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 22);
            this.textBoxDescription.TabIndex = 12;
            // 
            // textBoxDateOfPack
            // 
            this.textBoxDateOfPack.Location = new System.Drawing.Point(627, 87);
            this.textBoxDateOfPack.Name = "textBoxDateOfPack";
            this.textBoxDateOfPack.Size = new System.Drawing.Size(100, 22);
            this.textBoxDateOfPack.TabIndex = 13;
            // 
            // textBoxQuantityOfPage
            // 
            this.textBoxQuantityOfPage.Location = new System.Drawing.Point(751, 87);
            this.textBoxQuantityOfPage.Name = "textBoxQuantityOfPage";
            this.textBoxQuantityOfPage.Size = new System.Drawing.Size(100, 22);
            this.textBoxQuantityOfPage.TabIndex = 14;
            // 
            // textBoxPublishHouse
            // 
            this.textBoxPublishHouse.Location = new System.Drawing.Point(881, 87);
            this.textBoxPublishHouse.Name = "textBoxPublishHouse";
            this.textBoxPublishHouse.Size = new System.Drawing.Size(100, 22);
            this.textBoxPublishHouse.TabIndex = 15;
            // 
            // textBoxAuthors
            // 
            this.textBoxAuthors.Location = new System.Drawing.Point(1009, 87);
            this.textBoxAuthors.Name = "textBoxAuthors";
            this.textBoxAuthors.Size = new System.Drawing.Size(100, 22);
            this.textBoxAuthors.TabIndex = 16;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(1134, 87);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 22);
            this.textBoxQuantity.TabIndex = 17;
            // 
            // textBoxExpDate
            // 
            this.textBoxExpDate.Location = new System.Drawing.Point(1267, 87);
            this.textBoxExpDate.Name = "textBoxExpDate";
            this.textBoxExpDate.Size = new System.Drawing.Size(100, 22);
            this.textBoxExpDate.TabIndex = 18;
            // 
            // textBoxUnits
            // 
            this.textBoxUnits.Location = new System.Drawing.Point(1403, 87);
            this.textBoxUnits.Name = "textBoxUnits";
            this.textBoxUnits.Size = new System.Drawing.Size(100, 22);
            this.textBoxUnits.TabIndex = 19;
            // 
            // showCustomTextBoxButton
            // 
            this.showCustomTextBoxButton.Location = new System.Drawing.Point(12, 22);
            this.showCustomTextBoxButton.Name = "showCustomTextBoxButton";
            this.showCustomTextBoxButton.Size = new System.Drawing.Size(113, 59);
            this.showCustomTextBoxButton.TabIndex = 20;
            this.showCustomTextBoxButton.Text = "Add custom data";
            this.showCustomTextBoxButton.UseVisualStyleBackColor = true;
            this.showCustomTextBoxButton.Click += new System.EventHandler(this.ShowCustomTextBoxButtonClick);
            // 
            // hideInputButton
            // 
            this.hideInputButton.Location = new System.Drawing.Point(138, 22);
            this.hideInputButton.Name = "hideInputButton";
            this.hideInputButton.Size = new System.Drawing.Size(126, 58);
            this.hideInputButton.TabIndex = 21;
            this.hideInputButton.Text = "Hide input";
            this.hideInputButton.UseVisualStyleBackColor = true;
            this.hideInputButton.Click += new System.EventHandler(this.HideCustomTextBoxButtonClick);
            // 
            // acceptInputButton
            // 
            this.acceptInputButton.Location = new System.Drawing.Point(293, 22);
            this.acceptInputButton.Name = "acceptInputButton";
            this.acceptInputButton.Size = new System.Drawing.Size(121, 58);
            this.acceptInputButton.TabIndex = 22;
            this.acceptInputButton.Text = "Accept input";
            this.acceptInputButton.UseVisualStyleBackColor = true;
            this.acceptInputButton.Click += new System.EventHandler(this.AddCustomDataButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1515, 511);
            this.Controls.Add(this.acceptInputButton);
            this.Controls.Add(this.hideInputButton);
            this.Controls.Add(this.showCustomTextBoxButton);
            this.Controls.Add(this.textBoxUnits);
            this.Controls.Add(this.textBoxExpDate);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxAuthors);
            this.Controls.Add(this.textBoxPublishHouse);
            this.Controls.Add(this.textBoxQuantityOfPage);
            this.Controls.Add(this.textBoxDateOfPack);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.deleteLastButton);
            this.Controls.Add(this.deleteFirstButton);
            this.Controls.Add(this.deleteSelectedButton);
            this.Controls.Add(this.addProduct2Button);
            this.Controls.Add(this.addProduct1Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addBook2Button);
            this.Controls.Add(this.addBook1Button);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button acceptInputButton;

        private System.Windows.Forms.Button hideInputButton;

        private System.Windows.Forms.Button showCustomTextBoxButton;

        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxDateOfPack;
        private System.Windows.Forms.TextBox textBoxQuantityOfPage;
        private System.Windows.Forms.TextBox textBoxPublishHouse;
        private System.Windows.Forms.TextBox textBoxAuthors;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxExpDate;
        private System.Windows.Forms.TextBox textBoxUnits;

        private System.Windows.Forms.Button deleteLastButton;

        private System.Windows.Forms.Button deleteFirstButton;

        private System.Windows.Forms.Button deleteSelectedButton;

        private System.Windows.Forms.Button addProduct2Button;

        private System.Windows.Forms.Button addProduct1Button;

        private System.Windows.Forms.Button addBook2Button;

        private System.Windows.Forms.Button addBook1Button;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}