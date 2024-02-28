using System;
using System.Diagnostics.Metrics;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace S01_saucedemo_tesing_standard_user
{ 
    [TestFixture]
    public class T1_saucedemo_test_login
    {
        //**IMPORTANT NOTE:THIS TEST FOR USERNAME:standard_user,PASSWORD:secret_sauce**

        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");
        
        [Test]
        public void TC_01_Login_valid_username_password()
        {
            // 1 - enter valid username 2 - enter valid password

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            Task timeoutTask = Task.Delay(TimeSpan.FromSeconds(30), cancellationToken);


            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : proceed to List of product


        }
        [Test]
        public void TC_02_Login_invalid_username_password()
        {
            // 1 - enter invalid username 2 - enter invalid password

            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("standard_user1");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce1");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : erorr message: Username or password didn�t match

        }
    }
    [TestFixture]
    public class T2_saucedemo_test_Sort
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");
        [Test]
        public void TC_03_functionality_of_sort_option()
        {
            // Fuctionaltiy of SORT options form (A to Z), (Z to A), (Low to High), (High to Low).
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Name (Z to A)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Price (low to high)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Price (high to low)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Name (A to Z)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : Sort them as alphabet and price.


        }

    }


    [TestFixture]
    public class T3_saucedemo_test_Open_products
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_04_Click_on_products()
        {
            // 1- click on the products in product list page 


            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[0].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[1].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[2].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[3].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[4].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[5].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : show product details for each item

        }

    }

    [TestFixture]
    public class T4_add_to_cart
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_05_Add_to_cart()
        {
            //click on add to cart for the all product  

            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : Transfer the product to the cart

        }


    }

    [TestFixture]
    public class T5_open_cart_page
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_06_open_cart_after_add_items()
        {
            // Open cart page after add all the product to it
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //Expected result:Proceed to cart page and show all chosen items 
        }

    }
    [TestFixture]
    public class T6_open_checkout_page
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_07_open_checkoutpage_fill_informations()
        {
            //open checkout page and fill the required informations
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(200);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(200);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(200);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(200);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(200);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(200);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(200);
            Driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("checkout")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("first-name")).SendKeys("john");
            Driver.FindElement(By.Id("last-name")).SendKeys("robert");
            Driver.FindElement(By.Id("postal-code")).SendKeys("21110");
            Thread.Sleep(1000);
            Driver.Quit();
            //Expected result : proceed to checkout informations and show the invoice statement 

        }
    }
    [TestFixture]
    public class T7_Make_the_order
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_08_Make_the_order_and_back_to_productslist()
        {
            //Make the order and back to products list page
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(200);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(100);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(100);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(100);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(100);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(100);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(100);
            Driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(100);
            Driver.FindElement(By.Id("checkout")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("first-name")).SendKeys("john");
            Driver.FindElement(By.Id("last-name")).SendKeys("robert");
            Driver.FindElement(By.Id("postal-code")).SendKeys("21110");
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("continue")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("finish")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //Expected result : take the order and back to product page 
        }
    }
    [TestFixture]
    public class T8_Check_Logout
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_09_Logout()
        {
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("react-burger-menu-btn")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("logout_sidebar_link")).Click();
            Thread.Sleep(1000);
            Driver.Quit();

        }
    }
}
namespace S02_saucedemo_tesing_locked_out_user
{
    [TestFixture]
    public class T1_saucedemo_test_login
    {
        //** IMPORTANT NOTE:THIS TEST FOR USERNAME:locked_out_user,PASSWORD:secret_sauce **

        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_01_Login_valid_username_password()
        {
            // 1 - enter valid username 2 - enter valid password

            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("locked_out_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : proceed to List of product


        }
        [Test]
        public void TC_02_Login_invalid_username_password()
        {
            // 1 - enter invalid username 2 - enter invalid password

            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("locked_out_user1");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce1");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : erorr message: Username or password didn�t match

        }
    }
   
    }
namespace S03_saucedemo_tesing_problem_user

{
    [TestFixture]
    public class T01_saucedemo_test_login
    {
        //**IMPORTANT NOTE:THIS TEST FOR USERNAME:problem_user,PASSWORD:secret_sauce**

        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_001_Login_valid_username_password()
        {
            // 1 - enter valid username 2 - enter valid password

            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("problem_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : proceed to List of product


        }
        [Test]
        public void TC_002_Login_invalid_username_password()
        {
            // 1 - enter invalid username 2 - enter invalid password

            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("problem_user1");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce1");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : erorr message: Username or password didn�t match

        }
    }
    [TestFixture]
    public class T02_saucedemo_test_Sort
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");
        [Test]
        public void TC_03_functionality_of_sort_option()
        {
            // Fuctionaltiy of SORT options form (A to Z), (Z to A), (Low to High), (High to Low).
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("problem_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Name (Z to A)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Price (low to high)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Price (high to low)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Name (A to Z)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : Sort them as alphabet and price.


        }

    }


    [TestFixture]
    public class T03_saucedemo_test_Open_products
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_04_Click_on_products()
        {
            // 1- click on the products in product list page 


            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("problem_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[0].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[1].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[2].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[3].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[4].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[5].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : show product details for each item

        }

    }

    [TestFixture]
    public class T04_add_to_cart
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_05_Add_to_cart()
        {
            //click on add to cart for the all product  

            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("problem_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : Transfer the product to the cart

        }


    }

    [TestFixture]
    public class T05_open_cart_page
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_06_open_cart_after_add_items()
        {
            // Open cart page after add all the product to it
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("problem_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //Expected result:Proceed to cart page and show all chosen items 
        }

    }
    [TestFixture]
    public class T06_open_checkout_page
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_07_open_checkoutpage_fill_informations()
        {
            //open checkout page and fill the required informations
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("problem_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("checkout")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("first-name")).SendKeys("john");
            Driver.FindElement(By.Id("last-name")).SendKeys("robert");
            Driver.FindElement(By.Id("postal-code")).SendKeys("21110");
            Thread.Sleep(1000);
            Driver.Quit();
            //Expected result : proceed to checkout informations and show the invoice statement 

        }
    }
    [TestFixture]
    public class T07_Make_the_order
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_08_Make_the_order_and_back_to_productslist()
        {
            //Make the order and back to products list page
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("problem_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("checkout")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("first-name")).SendKeys("john");
            Driver.FindElement(By.Id("last-name")).SendKeys("robert");
            Driver.FindElement(By.Id("postal-code")).SendKeys("21110");
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("continue")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("finish")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //Expected result : take the order and back to product page 
        }
    }
    [TestFixture]
    public class T08_Check_Logout
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_09_Logout()
        {
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("problem_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("react-burger-menu-btn")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("logout_sidebar_link")).Click();
            Thread.Sleep(1000);
            Driver.Quit();

        }
    }
}
namespace S04_saucedemo_tesing_performance_glitch_user

{
    [TestFixture]
    public class T01_saucedemo_test_login
    {
        //**IMPORTANT NOTE:THIS TEST FOR USERNAME:performance_glitch_user,PASSWORD:secret_sauce**

        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_001_Login_valid_username_password()
        {
            // 1 - enter valid username 2 - enter valid password
            
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("performance_glitch_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : proceed to List of product


        }
        [Test]
        public void TC_002_Login_invalid_username_password()
        {
            // 1 - enter invalid username 2 - enter invalid password

            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("performance_glitch_user1");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce1");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : erorr message: Username or password didn�t match

        }
    }
    [TestFixture]
    public class T02_saucedemo_test_Sort
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");
        [Test]
        public void TC_03_functionality_of_sort_option()
        {
            // Fuctionaltiy of SORT options form (A to Z), (Z to A), (Low to High), (High to Low).
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("performance_glitch_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Name (Z to A)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Price (low to high)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Price (high to low)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Name (A to Z)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : Sort them as alphabet and price.


        }

    }


    [TestFixture]
    public class T03_saucedemo_test_Open_products
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_04_Click_on_products()
        {
            // 1- click on the products in product list page 


            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("performance_glitch_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[0].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[1].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[2].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[3].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[4].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[5].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : show product details for each item

        }

    }

    [TestFixture]
    public class T04_add_to_cart
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_05_Add_to_cart()
        {
            //click on add to cart for the all product  

            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("performance_glitch_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : Transfer the product to the cart

        }


    }

    [TestFixture]
    public class T05_open_cart_page
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_06_open_cart_after_add_items()
        {
            // Open cart page after add all the product to it
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("performance_glitch_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //Expected result:Proceed to cart page and show all chosen items 
        }

    }
    [TestFixture]
    public class T06_open_checkout_page
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_07_open_checkoutpage_fill_informations()
        {
            //open checkout page and fill the required informations
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("performance_glitch_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("checkout")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("first-name")).SendKeys("john");
            Driver.FindElement(By.Id("last-name")).SendKeys("robert");
            Driver.FindElement(By.Id("postal-code")).SendKeys("21110");
            Thread.Sleep(1000);
            Driver.Quit();
            //Expected result : proceed to checkout informations and show the invoice statement 

        }
    }
    [TestFixture]
    public class T07_Make_the_order
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_08_Make_the_order_and_back_to_productslist()
        {
            //Make the order and back to products list page
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("performance_glitch_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("checkout")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("first-name")).SendKeys("john");
            Driver.FindElement(By.Id("last-name")).SendKeys("robert");
            Driver.FindElement(By.Id("postal-code")).SendKeys("21110");
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("continue")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("finish")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //Expected result : take the order and back to product page 
        }
    }
    [TestFixture]
    public class T08_Check_Logout
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_09_Logout()
        {
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("performance_glitch_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("react-burger-menu-btn")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("logout_sidebar_link")).Click();
            Thread.Sleep(1000);
            Driver.Quit();

        }
    }
}
namespace S05_saucedemo_tesing_error_user

{
    [TestFixture]
    public class T01_saucedemo_test_login
    {
        //**IMPORTANT NOTE:THIS TEST FOR USERNAME:error_user,PASSWORD:secret_sauce**

        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_001_Login_valid_username_password()
        {
            // 1 - enter valid username 2 - enter valid password

            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("error_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : proceed to List of product


        }
        [Test]
        public void TC_002_Login_invalid_username_password()
        {
            // 1 - enter invalid username 2 - enter invalid password

            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("error_user1");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce1");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : erorr message: Username or password didn�t match

        }
    }
    [TestFixture]
    public class T02_saucedemo_test_Sort
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");
        [Test]
        public void TC_03_functionality_of_sort_option()
        {
            // Fuctionaltiy of SORT options form (A to Z), (Z to A), (Low to High), (High to Low).
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("error_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Name (Z to A)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Price (low to high)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Price (high to low)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Name (A to Z)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : Sort them as alphabet and price.


        }

    }


    [TestFixture]
    public class T03_saucedemo_test_Open_products
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_04_Click_on_products()
        {
            // 1- click on the products in product list page 


            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("error_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[0].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[1].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[2].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[3].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[4].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[5].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : show product details for each item

        }

    }

    [TestFixture]
    public class T04_add_to_cart
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_05_Add_to_cart()
        {
            //click on add to cart for the all product  

            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("error_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : Transfer the product to the cart

        }


    }

    [TestFixture]
    public class T05_open_cart_page
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_06_open_cart_after_add_items()
        {
            // Open cart page after add all the product to it
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("error_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //Expected result:Proceed to cart page and show all chosen items 
        }

    }
    [TestFixture]
    public class T06_open_checkout_page
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_07_open_checkoutpage_fill_informations()
        {
            //open checkout page and fill the required informations
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("error_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("checkout")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("first-name")).SendKeys("john");
            Driver.FindElement(By.Id("last-name")).SendKeys("robert");
            Driver.FindElement(By.Id("postal-code")).SendKeys("21110");
            Thread.Sleep(1000);
            Driver.Quit();
            //Expected result : proceed to checkout informations and show the invoice statement 

        }
    }
    [TestFixture]
    public class T07_Make_the_order
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_08_Make_the_order_and_back_to_productslist()
        {
            //Make the order and back to products list page
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("error_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(100);
            Driver.FindElement(By.Id("checkout")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("first-name")).SendKeys("john");
            Driver.FindElement(By.Id("last-name")).SendKeys("robert");
            Driver.FindElement(By.Id("postal-code")).SendKeys("21110");
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("continue")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("finish")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //Expected result : take the order and back to product page 
        }
    }
    [TestFixture]
    public class T08_Check_Logout
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_09_Logout()
        {
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("error_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("react-burger-menu-btn")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("logout_sidebar_link")).Click();
            Thread.Sleep(1000);
            Driver.Quit();

        }
    }
}
namespace S06_saucedemo_tesing_visual_user

{
    [TestFixture]
    public class T01_saucedemo_test_login
    {
        //**IMPORTANT NOTE:THIS TEST FOR USERNAME:visual_user,PASSWORD:secret_sauce**

        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_001_Login_valid_username_password()
        {
            // 1 - enter valid username 2 - enter valid password

            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("visual_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : proceed to List of product


        }
        [Test]
        public void TC_002_Login_invalid_username_password()
        {
            // 1 - enter invalid username 2 - enter invalid password

            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("visual_user1");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce1");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : erorr message: Username or password didn�t match

        }
    }
    [TestFixture]
    public class T02_saucedemo_test_Sort
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");
        [Test]
        public void TC_03_functionality_of_sort_option()
        {
            // Fuctionaltiy of SORT options form (A to Z), (Z to A), (Low to High), (High to Low).
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("visual_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Name (Z to A)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Price (low to high)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Price (high to low)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("product_sort_container")).SendKeys("Name (A to Z)");
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Driver.FindElement(By.ClassName("product_sort_container")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : Sort them as alphabet and price.


        }

    }


    [TestFixture]
    public class T03_saucedemo_test_Open_products
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_04_Click_on_products()
        {
            // 1- click on the products in product list page 


            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("visual_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[0].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[1].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[2].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[3].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[4].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.FindElements(By.ClassName("inventory_item_name"))[5].Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : show product details for each item

        }

    }

    [TestFixture]
    public class T04_add_to_cart
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_05_Add_to_cart()
        {
            //click on add to cart for the all product  

            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("visual_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //"EXPECTED RESULT" : Transfer the product to the cart

        }


    }

    [TestFixture]
    public class T05_open_cart_page
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_06_open_cart_after_add_items()
        {
            // Open cart page after add all the product to it
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("visual_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //Expected result:Proceed to cart page and show all chosen items 
        }

    }
    [TestFixture]
    public class T06_open_checkout_page
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_07_open_checkoutpage_fill_informations()
        {
            //open checkout page and fill the required informations
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("visual_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("checkout")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("first-name")).SendKeys("john");
            Driver.FindElement(By.Id("last-name")).SendKeys("robert");
            Driver.FindElement(By.Id("postal-code")).SendKeys("21110");
            Thread.Sleep(1000);
            Driver.Quit();
            //Expected result : proceed to checkout informations and show the invoice statement 

        }
    }
    [TestFixture]
    public class T07_Make_the_order
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_08_Make_the_order_and_back_to_productslist()
        {
            //Make the order and back to products list page
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("visual_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("checkout")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("first-name")).SendKeys("john");
            Driver.FindElement(By.Id("last-name")).SendKeys("robert");
            Driver.FindElement(By.Id("postal-code")).SendKeys("21110");
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("continue")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("finish")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("back-to-products")).Click();
            Thread.Sleep(1000);
            Driver.Quit();
            //Expected result : take the order and back to product page 
        }
    }
    [TestFixture]
    public class T08_Check_Logout
    {
        IWebDriver Driver = new ChromeDriver(@"C:\Users\alawn\.nuget\packages\selenium.webdriver.chromedriver\120.0.6099.10900\driver\win32");

        [Test]
        public void TC_09_Logout()
        {
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.saucedemo.com/";
            Driver.FindElement(By.Id("user-name")).SendKeys("visual_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("react-burger-menu-btn")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.Id("logout_sidebar_link")).Click();
            Thread.Sleep(1000);
            Driver.Quit();

        }
    }
}