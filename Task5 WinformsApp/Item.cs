namespace Task5_WinformsApp
{
    public class Item
    {
        public double _price { get; set; }
        public string _country { get; set; }
        public string _name { get; set; }
        public string _dateOfPackaging { get; set; }
        public string _description { get; set; }
    }
    public class Books : Item
    {
        public int _quatnityOfPages { get; set; }
        public string _publishingHouse { get; set; }
        public string _authors { get; set; }
    }
    public class Products : Item
    {
        public int _quantity { get; set; }
        public string _expirationDate { get; set; } 
        public string _units { get; set; }
    }
}