namespace CashRegister.Models
{
    public class Sale
    {
        public int SaleId { get; set; }

        public DateTime Date { get; set; }

        public int Total { get; set; }

        public bool IsLoan { get; set; }

        public string? ApartmentNumber { get; set; }

        public int Payment { get; set; }

        public List<ProductSale> ProductSales { get; set; } = null!;

    }
}