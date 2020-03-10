using System;
using Xunit;
using Silpo;

namespace SilpoTest
{
    public class CheckoutServiceTest
    {
        private Product Milk_7;
        private Product Bread_3;
        private Product Sprite_10;
        private CheckoutService CheckoutService;

        public CheckoutServiceTest()
        {
            CheckoutService = new CheckoutService();
            CheckoutService.OpenCheck();

            Milk_7 = new Product(7, "Milk", Category.MILK);
            Bread_3 = new Product(3, "Bread", Category.BREAD);
            Sprite_10 = new Product(10, "Sprite", Category.WATER, Brand.SPRITE);
        }

        [Fact]
        public void closeCheck__withOneProduct()
        {
            CheckoutService.AddProduct(Milk_7);
            Check check = CheckoutService.CloseCheck();

            Assert.Equal(7, check.GetTotalCost());
        }

        [Fact]
        public void closeCheck__withTwoProduct()
        {
            CheckoutService.AddProduct(Milk_7);
            CheckoutService.AddProduct(Bread_3);
            Check check = CheckoutService.CloseCheck();

            Assert.Equal(10, check.GetTotalCost());
        }

        [Fact]
        public void addProduct__whenCheckIsClosed__opensNewCheck()
        {
            CheckoutService.AddProduct(Milk_7);
            Check milkCheck = CheckoutService.CloseCheck();
            Assert.Equal(7, milkCheck.GetTotalCost());

            CheckoutService.AddProduct(Bread_3);
            Check breadCheck = CheckoutService.CloseCheck();
            Assert.Equal(3, breadCheck.GetTotalCost());
        }

        [Fact]
        public void closeCheck__calcTotalPoints()
        {
            CheckoutService.AddProduct(Milk_7);
            CheckoutService.AddProduct(Bread_3);
            Check Check = CheckoutService.CloseCheck();

            Assert.Equal(10, Check.GetTotalPoints());
        }

        [Fact]
        public void useOffer__addOfferPoints()
        {
            CheckoutService.AddProduct(Milk_7);
            CheckoutService.AddProduct(Bread_3);

            CheckoutService.UseOffer(new AnyGoodsOffer(6, 2));
            Check Check = CheckoutService.CloseCheck();

            Assert.Equal(12, Check.GetTotalPoints());
        }

        [Fact]
        public void useOffer__whenCostLessThenRequired__doNothing()
        {
            CheckoutService.AddProduct(Bread_3);

            CheckoutService.UseOffer(new AnyGoodsOffer(6, 2));
            Check Check = CheckoutService.CloseCheck();

            Assert.Equal(3, Check.GetTotalPoints());
        }

        [Fact]
        public void useOffer__factorByCategory()
        {
            CheckoutService.AddProduct(Milk_7);
            CheckoutService.AddProduct(Milk_7);
            CheckoutService.AddProduct(Bread_3);

            CheckoutService.UseOffer(new FactorByCategoryOffer(Category.MILK, 2));
            Check Check = CheckoutService.CloseCheck();

            Assert.Equal(31, Check.GetTotalPoints());
        }

        [Fact]
        public void useOffer__atStartShopping()
        {
            CheckoutService.UseOffer(new FactorByCategoryOffer(Category.MILK, 2));
            CheckoutService.AddProduct(Milk_7);
            CheckoutService.AddProduct(Bread_3);

            Check Check = CheckoutService.CloseCheck();

            Assert.Equal(17, Check.GetTotalPoints());
        }

        [Fact]
        public void useOffer__ifOfferExpired__doNotAddPoints()
        {
            CheckoutService.AddProduct(Milk_7);
            CheckoutService.UseOffer(new FactorByCategoryOffer(Category.MILK, 2, new DateTime(2000, 1, 1)));

            Check Check = CheckoutService.CloseCheck();

            Assert.Equal(7, Check.GetTotalPoints());
        }

        [Fact]
        public void useOffer__factorByBrandOffer__addPoints()
        {
            CheckoutService.AddProduct(Sprite_10);
            CheckoutService.UseOffer(new FactorByBrandOffer(Category.WATER, 3, DateTime.MaxValue, Brand.SPRITE));

            Check Check = CheckoutService.CloseCheck();

            Assert.Equal(30, Check.GetTotalPoints());            
        }
    }
}
