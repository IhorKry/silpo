using Xunit;
using Silpo;

namespace SilpoTest
{
    public class CheckoutServiceTest
    {
        private Product Milk_7;
        private Product Bread_3;
        private CheckoutService CheckoutService;

        public CheckoutServiceTest()
        {
            CheckoutService = new CheckoutService();
            CheckoutService.OpenCheck();

            Milk_7 = new Product(7, "Milk");
            Bread_3 = new Product(3, "Bread");
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
    }
}
