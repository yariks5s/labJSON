using System.Drawing;
using System.Reflection;

namespace Task5_WinformsApp
{
    public class Item
    {
        public string _price { get; set; }
        public string _country { get; set; }
        public string _name { get; set; }
        public string _dateOfPackaging { get; set; }
        public string _description { get; set; }

                public string[] GetData()
                {
            string[] list = new string[] { _name, _price, _country, _description, _dateOfPackaging, "", "", "", "", "", ""};
            return list;
        }
    }
    public class Books : Item
    {
        public string _quatnityOfPages { get; set; }
        public string _publishingHouse { get; set; }
        public string _authors { get; set; }

        public new object[] GetData()
        {
            string[] list = new string[] { _name, _price, _country, _description, _dateOfPackaging, _quatnityOfPages, _publishingHouse, _authors, "", "", ""};
            return list;
        }
    }
    public class Products : Item
    {
        public string _quantity { get; set; }
        public string _expirationDate { get; set; } 
        public string _units { get; set; }
        public new object[] GetData()
        {
            string[] list = new string[] { _name, _price, _country, _description, _dateOfPackaging, "", "", "", _quantity, _expirationDate, _units};
            return list;
        }
    }
}
