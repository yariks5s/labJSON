using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5_WinformsApp
{
    
    public partial class Form1 : Form
    {
        // Creating a different items
        private Products _burger = new Products()
        {
            _name = "Burger", _country = "Ukraine",
            _description = "Burger made from meat, burger buns, tomato and pickles",
            _price = "50", _quantity = "1", _units = "item", _expirationDate = "5-10-2022",
            _dateOfPackaging = "02-10-2022"
        };

        private Products _pizza = new Products()
        {
            _name = "Pizza", _country = "Ukraine",
            _description = "Pizza made from pizza dough, tomato sauce, meat and cheese",
            _price = "65", _quantity = "1", _units = "item", _expirationDate = "6/10/2022",
            _dateOfPackaging = "02/10/2022"
        };
        
        private Books _annaKarenina = new Books()
        {
            _name = "Anna Karenina", _country = "Ukraine", _authors = "Lev Tolstoy",
            _description =
                "Anna Karenina is a novel by the Russian author Leo Tolstoy, first published in book form in 1878. Widely considered to be one of the greatest works of literature ever written, Tolstoy himself called it his first true novel.",
            _price = "150", _publishingHouse = "FreshBooks", _dateOfPackaging = "23/05/2019", _quatnityOfPages = "230"
        };

        private Books _kobzar = new Books()
        {
            _name = "Kobzar", _country = "Ukraine", _authors = "Taras Shevchenko",
            _description =
                "This is a book of poems by Ukrainian poet and painter Taras Shevchenko, first published by him in 1840 in Saint Petersburg, Russia. Taras Shevchenko was nicknamed The Kobzar after the publishing of this book. From that time on this title has been applied to Shevchenko's poetry in general and acquired a symbolic meaning of the Ukrainian national and literary revival.",
            _price = "230", _publishingHouse = "Freshbooks", _dateOfPackaging = "13/02/2020", _quatnityOfPages = "400"
        };

        // Making some code templates
        void Headers()
        {
            dataGridView1.ColumnCount = 11;
            dataGridView1.Columns[0].Name = "Product Name";
            dataGridView1.Columns[1].Name = "Product Price";
            dataGridView1.Columns[2].Name = "Product Country";
            dataGridView1.Columns[3].Name = "Product Description";
            dataGridView1.Columns[4].Name = "Product Date Of Packaging (dd/mm/yyyy)";
            dataGridView1.Columns[5].Name = "Product Quantity Of Pages";
            dataGridView1.Columns[6].Name = "Product Publishing House";
            dataGridView1.Columns[7].Name = "Product Authors";
            dataGridView1.Columns[8].Name = "Product Quantity";
            dataGridView1.Columns[9].Name = "Product Expiration Date";
            dataGridView1.Columns[10].Name = "Product Units";
            textBoxName.Visible = false;
            textBoxPrice.Visible = false;
            textBoxCountry.Visible = false;
            textBoxDescription.Visible = false;
            textBoxDateOfPack.Visible = false;
            textBoxQuantityOfPage.Visible = false;
            textBoxPublishHouse.Visible = false;
            textBoxAuthors.Visible = false;
            textBoxQuantity.Visible = false;
            textBoxExpDate.Visible = false;
            textBoxUnits.Visible = false;
            hideInputButton.Visible = false;
            acceptInputButton.Visible = false;
        }
        void EmptyTextBox()
        {
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxCountry.Text = "";
            textBoxDescription.Text = "";
            textBoxDateOfPack.Text = "";
            textBoxQuantityOfPage.Text = "";
            textBoxPublishHouse.Text = "";
            textBoxAuthors.Text = "";
            textBoxQuantity.Text = "";
            textBoxExpDate.Text = "";
            textBoxUnits.Text = "";
        }
        
        
        public Form1()
        {
            InitializeComponent();
            Headers();
        }
        
        
        // Actions for different Buttons
        private void AddBook1ButtonClick(object sender, EventArgs e)
        {

            object[] row = _annaKarenina.GetData();
            dataGridView1.Rows.Add(row);
        }

        private void AddBook2ButtonClick(object sender, EventArgs e)
        {
            {
                object[] row = _kobzar.GetData();
                dataGridView1.Rows.Add(row);
            }
        }

        private void AddItem1ButtonClick(object sender, EventArgs e)
        {
            {
                object[] row = _burger.GetData();
                dataGridView1.Rows.Add(row);
            }
        }

        private void AddItem2ButtonClick(object sender, EventArgs e)
        {
            {
                object[] row = _pizza.GetData();
                dataGridView1.Rows.Add(row);
            }
        }

        private void RemoveSelectedButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }
            }
            catch (Exception) {MessageBox.Show("You cannot delete it.", "Error");}
        }
        
        private void RemoveFirstButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.Rows[0].Index);
                }
            }
            catch (Exception ex) {MessageBox.Show("You cannot delete it.", "Error");}
        }
        
        private void RemoveLastButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.Rows[dataGridView1.Rows.Count - 2].Index);
                }
            }
            catch (Exception ex) {MessageBox.Show("You cannot delete it.", "Error");}
        }

        private void ShowCustomBookTextBoxButtonClick(object sender, EventArgs e)
        {
            textBoxName.Visible = true;
            textBoxPrice.Visible = true;
            textBoxCountry.Visible = true;
            textBoxDescription.Visible = true;
            textBoxDateOfPack.Visible = true;
            textBoxQuantityOfPage.Visible = true;
            textBoxPublishHouse.Visible = true;
            textBoxAuthors.Visible = true;
            textBoxQuantity.Visible = false;
            textBoxExpDate.Visible = false;
            textBoxUnits.Visible = false;
            hideInputButton.Visible = true;
            acceptInputButton.Visible = true;
            showCustomBookTextBoxButton.Enabled = false;
            showCustomProductTextBoxButton.Enabled = true;
            EmptyTextBox();
        }
        
        private void ShowCustomProductTextBoxButtonClick(object sender, EventArgs e)
        {
            textBoxName.Visible = true;
            textBoxPrice.Visible = true;
            textBoxCountry.Visible = true;
            textBoxDescription.Visible = true;
            textBoxDateOfPack.Visible = true;
            textBoxQuantityOfPage.Visible = false;
            textBoxPublishHouse.Visible = false;
            textBoxAuthors.Visible = false;
            textBoxQuantity.Visible = true;
            textBoxExpDate.Visible = true;
            textBoxUnits.Visible = true;
            hideInputButton.Visible = true;
            acceptInputButton.Visible = true;
            showCustomBookTextBoxButton.Enabled = true;
            showCustomProductTextBoxButton.Enabled = false;
            EmptyTextBox();
        }

        private void HideCustomTextBoxButtonClick(object sender, EventArgs e)
        {
            textBoxName.Visible = false;
            textBoxPrice.Visible = false;
            textBoxCountry.Visible = false;
            textBoxDescription.Visible = false;
            textBoxDateOfPack.Visible = false;
            textBoxQuantityOfPage.Visible = false;
            textBoxPublishHouse.Visible = false;
            textBoxAuthors.Visible = false;
            textBoxQuantity.Visible = false;
            textBoxExpDate.Visible = false;
            textBoxUnits.Visible = false;
            acceptInputButton.Visible = false;
            hideInputButton.Visible = false;
            showCustomBookTextBoxButton.Enabled = true;
            showCustomProductTextBoxButton.Enabled = true;
        }

        private void AddCustomDataButtonClick(object sender, EventArgs e)
        {
            string message = "Please, enter the correct data", caption = "Solution";
            
            if (textBoxName.Text == "" || textBoxCountry.Text == "" ||
                textBoxDescription.Text == "" || !int.TryParse(textBoxPrice.Text, out int c) ||
                !DateTime.TryParse(textBoxDateOfPack.Text, out DateTime _))
            {
                MessageBox.Show(message, caption);
                return;
            }

            if (showCustomBookTextBoxButton.Enabled == false && 
                textBoxPublishHouse.Text == "" || textBoxAuthors.Text == "" || textBoxQuantityOfPage.Text == "" ||
                 !int.TryParse(textBoxQuantityOfPage.Text, out int _))
            {
                MessageBox.Show(message, caption);
                return;
            }

            if (showCustomProductTextBoxButton.Enabled == false && (textBoxUnits.Text == "" || 
                textBoxQuantity.Text == "" || !int.TryParse(textBoxQuantity.Text, out int _) || 
                !DateTime.TryParse(textBoxExpDate.Text, out DateTime _)))
            {
                MessageBox.Show(message, caption);
                return;
            }

            object[] list = new object[]
            {
                textBoxName.Text, textBoxPrice.Text, textBoxCountry.Text, textBoxDescription.Text,
                textBoxDateOfPack.Text, textBoxQuantityOfPage.Text, textBoxPublishHouse.Text, textBoxAuthors.Text,
                textBoxQuantity.Text, textBoxExpDate.Text, textBoxUnits.Text
            };
            int n = dataGridView1.Rows.Add(list);
            EmptyTextBox();
        }
        
    }
}