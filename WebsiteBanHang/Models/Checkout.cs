using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebsiteBanHang.Models
{
    public class Checkout
    {
        public List<CheckoutLine> Lines { get; set; } = new List<CheckoutLine>();
        public void AddItem(Product product, int quantity)
        {
            CheckoutLine? line = Lines
            .Where(p => p.Product.ProductId == product.ProductId)
            .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CheckoutLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public void RemoveLine(Product product) => Lines.RemoveAll(l => l.Product.ProductId == product.ProductId);
        public decimal ComputeTotalValue() => (decimal)Lines.Sum(e => e.Product?.ProductPrice * (1 - e.Product.ProductDiscount) * e.Quantity);
        public void Clear() => Lines.Clear();
    }

    public class CheckoutLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; } = new();
        public int Quantity { get; set; }
    }
}
