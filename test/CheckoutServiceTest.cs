using Xunit;
using Silpo;

namespace SilpoTest
{
    public class CheckoutServiceTest
    {
        [Fact]
        public void closeCheck__withOneProduct()
        {
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.OpenCheck();

            checkoutService.AddProduct(new Product(7, "Milk"));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(7, check.GetTotalCost());
        }

        [Fact]
        public void closeCheck__withTwoProduct()
        {
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.OpenCheck();

            checkoutService.AddProduct(new Product(7, "Milk"));
            checkoutService.AddProduct(new Product(3, "Bread"));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(10, check.GetTotalCost());
        }

        [Fact]
        public void addProduct__whenCheckIsClosed__opensNewCheck()
        {
            CheckoutService checkoutService = new CheckoutService();

            checkoutService.AddProduct(new Product(7, "Milk"));
            Check milkCheck = checkoutService.CloseCheck();
            Assert.Equal(7, milkCheck.GetTotalCost());

            checkoutService.AddProduct(new Product(3, "Bread"));
            Check breadCheck = checkoutService.CloseCheck();
            Assert.Equal(3, breadCheck.GetTotalCost());
        }
    }
}
