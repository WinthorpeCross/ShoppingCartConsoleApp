namespace ShoppingCartConsoleApp.Models
{
    public class Product
    {
        public Product(int id, string name, decimal unitcost, Discounts currentDiscount)
        {
            this.Id = id;
            this.Name = name;
            this.UnitCost = unitcost;
            this.Discount = currentDiscount;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal UnitCost { get; set; }

        public Discounts Discount { get; set; }
    }
}
