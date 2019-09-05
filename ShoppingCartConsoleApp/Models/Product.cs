namespace ShoppingCartConsoleApp.Models
{
    public class Product
    {
        public Product(int id, string name, decimal unitcost, Discount currentDiscount)
        {
            this.Id = id;
            this.Name = name;
            this.UnitCost = unitcost;
            this.CurrentDiscount = currentDiscount;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal UnitCost { get; set; }

        //public Discounts Discount { get; set; }

        public Discount CurrentDiscount { get; set; }
    }
}
