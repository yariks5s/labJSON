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
        public Form1()
        {
            InitializeComponent();
        }
        
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
            _price = "65", _quantity = "1", _units = "item", _expirationDate = "6-10-2022",
            _dateOfPackaging = "02-10-2022"
        };
        
        private Books _annaKarenina = new Books()
        {
            _name = "Anna Karenina", _country = "Ukraine", _authors = "Lev Tolstoy",
            _description =
                "Anna Karenina is a novel by the Russian author Leo Tolstoy, first published in book form in 1878. Widely considered to be one of the greatest works of literature ever written, Tolstoy himself called it his first true novel.",
            _price = "150", _publishingHouse = "FreshBooks", _dateOfPackaging = "23-05-2019", _quatnityOfPages = "230"
        };

        private Books _kobzar = new Books()
        {
            _name = "Kobzar", _country = "Ukraine", _authors = "Taras Shevchenko",
            _description =
                "This is a book of poems by Ukrainian poet and painter Taras Shevchenko, first published by him in 1840 in Saint Petersburg, Russia. Taras Shevchenko was nicknamed The Kobzar after the publishing of this book. From that time on this title has been applied to Shevchenko's poetry in general and acquired a symbolic meaning of the Ukrainian national and literary revival.",
            _price = "230", _publishingHouse = "Freshbooks", _dateOfPackaging = "13-02-2020", _quatnityOfPages = "400"
        };


        void Headers()
        {
            dataGridView1.ColumnCount = 11;
            dataGridView1.Columns[0].Name = "Product Name";
            dataGridView1.Columns[1].Name = "Product Price";
            dataGridView1.Columns[2].Name = "Product Country";
            dataGridView1.Columns[3].Name = "Product Description";
            dataGridView1.Columns[4].Name = "Product Date Of Packaging";
            dataGridView1.Columns[5].Name = "Product Quantity Of Pages";
            dataGridView1.Columns[6].Name = "Product Publishing House";
            dataGridView1.Columns[7].Name = "Product Authors";
            dataGridView1.Columns[8].Name = "Product Quantity";
            dataGridView1.Columns[9].Name = "Product Expiration Date";
            dataGridView1.Columns[10].Name = "Product Units";
        }

        private void Form1_load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Headers();
            
            string[] row = _annaKarenina.GetData();
            dataGridView1.Rows.Add(row);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                Headers();

                string[] row = _kobzar.GetData();
                dataGridView1.Rows.Add(row);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                Headers();

                string[] row = _burger.GetData();
                dataGridView1.Rows.Add(row);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                Headers();

                string[] row = _pizza.GetData();
                dataGridView1.Rows.Add(row);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.Rows[0].Index);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.Rows[dataGridView1.Rows.Count - 2].Index);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Headers();

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[n].Cells[3].Value = textBox4.Text;
            dataGridView1.Rows[n].Cells[4].Value = textBox5.Text;
            dataGridView1.Rows[n].Cells[5].Value = textBox6.Text;
            dataGridView1.Rows[n].Cells[6].Value = textBox7.Text;
            dataGridView1.Rows[n].Cells[7].Value = textBox8.Text;
            dataGridView1.Rows[n].Cells[8].Value = textBox9.Text;
            dataGridView1.Rows[n].Cells[9].Value = textBox10.Text;
            dataGridView1.Rows[n].Cells[10].Value = textBox11.Text;
        }
    }
}