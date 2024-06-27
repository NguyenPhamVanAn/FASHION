using NUnit.Framework;
using WebBanHang.Models;

namespace TestCart
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void Can_Add_To_Cart()
        {
            Product p1 = new Product { Id = 1, Name = "A" };
            Product p2 = new Product { Id = 2, Name = "B" };
            Product p3 = new Product { Id = 1, Name = "C" };


            Cart cart = new Cart();
            cart.Add(p1, 1);
            cart.Add(p2, 1);

            CartItem[] _Item = cart.Items.ToArray();
            Assert.AreEqual(2, _Item.Length);
            Assert.AreEqual(p1, _Item[0].Product);
            Assert.AreEqual(p2, _Item[1].Product);

            cart.Update(2, 5);
            _Item = cart.Items.ToArray();
            Assert.AreEqual(2, _Item.Length);
            Assert.AreEqual(5, _Item[1].Quantity);

        }
    }
}