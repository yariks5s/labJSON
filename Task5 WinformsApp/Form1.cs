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
        public List<Books> BooksList { get; set; }
        public List<Products> ProductsList { get; set; }
        public Form1()
        {
            BooksList = GetBooks();
            ProductsList = GetProductsList();
            InitializeComponent();
        }

        public List<Products> GetProductsList()
        {
            var list = new List<Products>();
            list.Add(new Products(){_name = "Burger", _country = "Ukraine", _description = "Burger made from meat, burger buns, tomato and pickles", _price = 50, _quantity = 1, _units = "item", _expirationDate = "5-10-2022", _dateOfPackaging = "02-10-2022"});
            list.Add(new Products(){ _name = "Pizza", _country = "Ukraine", _description = "Pizza made from pizza dough, tomato sauce, meat and cheese", _price = 65, _quantity = 1, _units = "item", _expirationDate = "6-10-2022", _dateOfPackaging = "02-10-2022"});
            return list;
        }

        public List<Books> GetBooks()
        {
            var list = new List<Books>();
            list.Add(new Books(){ _name = "Anna Karenina", _country = "Ukraine", _authors = "Lev Tolstoy", _description = "Anna Karenina is a novel by the Russian author Leo Tolstoy, first published in book form in 1878. Widely considered to be one of the greatest works of literature ever written, Tolstoy himself called it his first true novel.", _price = 150, _publishingHouse = "FreshBooks", _dateOfPackaging = "23-05-2019", _quatnityOfPages = 230});
            list.Add(new Books(){_name = "Kobzar", _country = "Ukraine", _authors = "Taras Shevchenko", _description = "This is a book of poems by Ukrainian poet and painter Taras Shevchenko, first published by him in 1840 in Saint Petersburg, Russia. Taras Shevchenko was nicknamed The Kobzar after the publishing of this book. From that time on this title has been applied to Shevchenko's poetry in general and acquired a symbolic meaning of the Ukrainian national and literary revival.", _price = 230, _publishingHouse = "Freshbooks", _dateOfPackaging = "13-02-2020", _quatnityOfPages = 400});
            return list;
        }
        

        private void Form1_load(object sender, EventArgs e)
        {
            var books = BooksList;
            dataGridView1.DataSource = books;
        }
        
    }
}