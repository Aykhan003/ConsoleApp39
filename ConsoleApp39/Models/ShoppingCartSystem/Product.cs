namespace ConsoleApp39.Models.ShoppingCartSystem
{
    internal class Product
    {
        private static int _idCounter;
        public int Id { get;}
        public string Name { get; set; }
        public double Price { get; set; }
        public int StuckCount { get; set; }
        public Product(string name, double price, int stuckCount)
        {
            _idCounter++;
            Id = _idCounter;
            Name = name;
            Price = price;
            StuckCount = stuckCount;
        }
    }
}
