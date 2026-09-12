namespace ConsoleApp39.Models.ShoppingCartSystem
{
    internal class ShoppingCart
    {
        private Product[] _products;
        public void AddProduct(Product product)
        {
            if (_products == null)
            {
                _products = new Product[1];
                _products[0] = product;
            }
            else
            {
                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length - 1] = product;
            }
        }
        public void RemoveProduct(int productId)
        {
            if (_products == null)
            {
                throw new NotFoundException($"No products in the shopping cart.");
            }
            int indexToRemove = -1;
            for (int i = 0; i < _products.Length; i++)
            {
                if (_products[i] != null && _products[i].Id == productId)
                {
                    indexToRemove = i;
                    break;
                }
            }
            if (indexToRemove == -1)
            {
                throw new NotFoundException($"Product with ID {productId} not found in the shopping cart.");
            }
            for (int i = indexToRemove; i < _products.Length - 1; i++)
            {
                _products[i] = _products[i + 1];
            }
            Array.Resize(ref _products, _products.Length - 1);
        }
    }
}
