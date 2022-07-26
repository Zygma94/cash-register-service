namespace CashRegister.Models
{
    public class SaleRequest
    {

        public bool IsLoan { get; set; }

        public string? ApartmentNumber { get; set; }

        public int Payment { get; set; }

        public List<ProductSaleRequest> ProductSales { get; set; } = null!;
    }
}