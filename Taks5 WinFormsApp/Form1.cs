namespace Taks5_WinFormsApp;

public partial class Form1 : Form
{
    class Item
    {
        private double _price;
        private string _country, _name, _dateOfPackaging, _description;
    }

    class Products : Item
    {
        private string _expirationDate, _units;
        private int _quantity;
    }

    class Books : Item
    {
        private int _quatnityOfPages;
        private string _publishingHouse, _authors;
    }
    public Form1()
    {
        InitializeComponent();
    }
}