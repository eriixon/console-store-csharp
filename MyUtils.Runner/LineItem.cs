namespace MyUtils.Runner
{
    public class LineItem
    {
        public LineItem(int productId, string name, decimal price)
        {
            ProductId = productId;
            Name = name;
            Price = price;
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}