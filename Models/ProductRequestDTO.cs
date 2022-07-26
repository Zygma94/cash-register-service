namespace CashRegister.Models
{
    public class ProductRequest
    {


        public string Name { get; set; } = string.Empty;

        public int SalePrice { get; set; }


        public int BuyPrice { get; set; }


        public int Quantity { get; set; }

    }
}