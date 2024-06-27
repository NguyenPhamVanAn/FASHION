using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    // lớp biểu diễn một phần tử của giỏ hàng
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
    // lớp biểu diễn giỏ hàng
    public class Cart
    {
        private List<CartItem> _items;
        public Cart()
        {
            _items = new List<CartItem>();
        }
        public List<CartItem> Items { get { return _items; } }
        // ---------các phương  thức xử lý trên giỏ hàng------------
        // phương thức thêm sản phẩm
        public void Add(Product p,int qty)
        {
            var item = _items.FirstOrDefault(x => x.Product.Id == p.Id);
            if (item == null) //nếu chưa có
            {
                _items.Add(new CartItem {Product=p,Quantity=qty});
            }
            else
            {
                item.Quantity += qty;
            }
        }
        // phương thức cập nhậ số lượng sản phẩm
        public void Update(int productId,int qty)
        {
            var item = _items.FirstOrDefault(x => x.Product.Id == productId);
            if (item != null)
            {
                if (qty > 0)
                {
                    item.Quantity = qty;
                }
                else
                {
                    _items.Remove(item);
                }
            }
        }
        // xóa sản phẩm
        public void Remove(int productId)
        {
            var item = _items.FirstOrDefault(x => x.Product.Id == productId);
            if (item != null)
            {
                 _items.Remove(item);
            }
        }
        // phương thức tính tổng thành tiền
            //public double Total()
            //{
            //     double total = _items.Sum(x => x.Quantity * x.Product.Price);
            //     return total;   
            //}
            public double Total
            {
                get  {
                        double total = _items.Sum(x => x.Quantity * x.Product.Price);
                        return total;
                     }
            }
        // tính tổng số lượng sản phẩm
            public double Quantity
            {
                get
                {
                    double total = _items.Sum(x => x.Quantity);
                    return total;
                }
            }

    }
}
