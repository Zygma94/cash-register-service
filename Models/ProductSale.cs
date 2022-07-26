namespace CashRegister.Models
{
    public class ProductSale
    {
        public int ProductSaleId { get; set; }

        public int ProductId { get; set; }

        public int SaleId { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public Product? Product { get; set; }
    }
}
