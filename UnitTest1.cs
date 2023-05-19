using OpenQA.Selenium;

namespace My_TestProjectCian
{
    public class Tests
    {
        private IWebDriver driver;
        private readonly By _signInBtn = By.XPath("//span[text()='Войти']");
        private readonly By _singAnotherWay = By.XPath("//span[text()='Другим способом']");
        private readonly By _loginInputTxt = By.XPath("//input[@name='username']");
        private const string _login = "maj1li@yandex.ru";
        private readonly By _continueBtn = By.XPath("//span[text()='Продолжить']");
        private readonly By _passwordInputBtn = By.XPath("//input[@name='password']");
        private readonly By _singInBtnFinish = By.XPath("//button[@data-name='ContinueAuthBtn']");
        private const string _password = "4370203Leksa";
        private readonly By _placeAdBtn = By.XPath("//span[text()='+ Разместить объявление']");
        private readonly By _saleBtn = By.XPath("//div[@data-mark='switcher_button|adType.dealType|sale']");
        private readonly By _livingBtn = By.XPath("//div[@data-mark='switcher_button|adType.propertyType|residential']");
        private readonly By _flatRb = By.XPath("//span[text()='Квартира']");
        private readonly By _adressInputTxt = By.XPath("//input[@name='geo.userInput']");
        private const string _adress = "Санкт-Петербург, Сестрорецк, Приморское шоссе, 261";
        private readonly By _goBtn = By.XPath("//span[text()='Дальше']");
        private readonly By _flatBtn = By.XPath("//div[@data-mark='switcher_button|ad.housingType|false']");
        private readonly By _comboBox = By.XPath("//span[text()='Не выбрано']");
        private readonly By _countRoom = By.XPath("//li[text()='3']");
        private readonly By _totalAreaTxt = By.XPath("//input[@name='urbanTotalArea']");
        private const string _totalAreaText = "100";
        private readonly By _floorNumberTxt = By.XPath("//input[@name='floorNumber']");
        private const string _floorNumberText = "10";
        private readonly By _floorsCountTxt = By.XPath("//input[@name='floorsCount']");
        private const string _floorsCountText = "10";
        private readonly By _repairTypeBtn = By.XPath("//div[@data-mark='switcher_button|ad.repairType|euro']");
        private readonly By _checkBox1 = By.XPath("//span[text()='Окна во двор']");
        private readonly By _checkBox2 = By.XPath("//span[text()='Окна на улицу']");
        private readonly By _checkBox3 = By.XPath("//span[text()='Балкон']");
        private readonly By _checkBox4 = By.XPath("//span[text()='Совмещённый санузел']");
        private readonly By _checkBox5 = By.XPath("//span[text()='Изолированная']");
        private readonly By _livingAreaTxt = By.XPath("//input[@name='livingArea']");
        private const string _livingAreaText = "50";
        private readonly By _kitchenAreaTxt = By.XPath("//input[@name='kitchenArea']");
        private const string _kitchenAreaText = "15";
        private readonly By _youtubeTxt = By.XPath("//input[@name='youtube']");
        private const string _youtubeText = "https://www.youtube.com/watch?v=jBx7OfXVsvk";
        private readonly By _addBtn = By.XPath("//span[text()='Добавить']");
        private readonly By _photoInput = By.XPath("//input[@name='photos']");
        private const string _photo1 = "C:\\Users\\leksa\\OneDrive\\Изображения\\flat_photo.jpg";
        private const string _photo2 = "C:\\Users\\leksa\\OneDrive\\Изображения\\flat_photo1.jpg";
        private readonly By _aboutFlatTxt = By.TagName("textarea");
        private const string _aboutFlatText = "Это моя квартира и она не продаётся!!!!";
        //private readonly By _dop = By.XPath("//div[@data-mark='switcher_button||true']");
        private readonly By _priceTxt = By.XPath("//input[@name='bargainTerms.price']");
        private const string _priceText = "15000000";
        private readonly By _ipotekaBtn = By.XPath("//span[text()='Возможна ипотека']");
        private readonly By _saleTypeBtn = By.XPath("//div[@data-mark='switcher_button|ad.bargainTerms.saleType|free']");
        private readonly By _numberTxt = By.XPath("//input[@name='number']");
        
        private const string _numberText = "9968853284";
        private readonly By _publishBtn = By.XPath("//button[@data-name='PublishButton']");
        
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Edge.EdgeDriver();
            driver.Navigate().GoToUrl("https://cian.ru");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void TestPlaceAnAd()
        {
            var singIn = driver.FindElement(_signInBtn); 
            singIn.Click();
            Thread.Sleep(1000);
            var singAnother = driver.FindElement(_singAnotherWay); 
            singAnother.Click();
            var login = driver.FindElement(_loginInputTxt); 
            login.SendKeys(_login);
            var singСontinue = driver.FindElement(_continueBtn); 
            singСontinue.Click();
            Thread.Sleep(1000);
            var password = driver.FindElement(_passwordInputBtn); 
            password.SendKeys(_password);
            var singInFinish = driver.FindElement(_singInBtnFinish);
            singInFinish.Click();
            Thread.Sleep(3000);

            var placeAd = driver.FindElement(_placeAdBtn);
            placeAd.Click();
            Thread.Sleep(1000);
            //var dop = driver.FindElement(_dop);
            //dop.Click();
            //Thread.Sleep(2000);
            var saleBtn = driver.FindElement(_saleBtn);
            saleBtn.Click();
            Thread.Sleep(2000);
            var livingBtn = driver.FindElement(_livingBtn);
            livingBtn.Click();
            Thread.Sleep(2000);
            var flatRb = driver.FindElement(_flatRb);
            flatRb.Click();
            Thread.Sleep(5000);
            var adressInputTxt = driver.FindElement(_adressInputTxt);
            adressInputTxt.Clear();
            Thread.Sleep(2000);
            adressInputTxt.SendKeys(_adress);
            Thread.Sleep(4000);
            var goBtn = driver.FindElement(_goBtn);
            goBtn.Click();
            Thread.Sleep(4000);
            goBtn.Click();
            Thread.Sleep(3000);
            var flatBtn = driver.FindElement(_flatBtn);
            flatBtn.Click();
            Thread.Sleep(5000);
            var comboBox = driver.FindElement(_comboBox);
            comboBox.Click();
            Thread.Sleep(1000);
            var countRoom = driver.FindElement(_countRoom);
            countRoom.Click();
            Thread.Sleep(3000);
            var checkBox5 = driver.FindElement(_checkBox5);
            checkBox5.Click();
            Thread.Sleep(1000);
            var totalAreaTxt = driver.FindElement(_totalAreaTxt);
            totalAreaTxt.SendKeys(_totalAreaText);
            Thread.Sleep(1000);
            var floorNumberTxt = driver.FindElement(_floorNumberTxt);
            floorNumberTxt.SendKeys(_floorNumberText);
            Thread.Sleep(1000);
            var floorsCountTxt = driver.FindElement(_floorsCountTxt);
            floorsCountTxt.SendKeys(_floorsCountText);
            Thread.Sleep(1000);
            var livingAreaTxt = driver.FindElement(_livingAreaTxt);
            livingAreaTxt.SendKeys(_livingAreaText);
            Thread.Sleep(1000);
            var kitchenAreaTxt = driver.FindElement(_kitchenAreaTxt);
            kitchenAreaTxt.SendKeys(_kitchenAreaText);
            Thread.Sleep(1000);
            var repairTypeBtn = driver.FindElement(_repairTypeBtn);
            repairTypeBtn.Click();
            Thread.Sleep(3000);
            var checkBox1 = driver.FindElement(_checkBox1);
            checkBox1.Click();
            var checkBox2 = driver.FindElement(_checkBox2);
            checkBox2.Click();
            var checkBox3 = driver.FindElement(_checkBox3);
            checkBox3.Click();
            var checkBox4 = driver.FindElement(_checkBox4);
            checkBox4.Click();
            Thread.Sleep(3000);
            var photoInput = driver.FindElement(_photoInput);
            photoInput.SendKeys(_photo1);
            photoInput.SendKeys(_photo2);
            Thread.Sleep(3000);
            var youtubeTxt = driver.FindElement(_youtubeTxt);
            youtubeTxt.SendKeys(_youtubeText);
            Thread.Sleep(1000);
            var addBtn = driver.FindElement(_addBtn);
            addBtn.Click();
            Thread.Sleep(4000);
            var aboutFlatTxt = driver.FindElement(_aboutFlatTxt);
            aboutFlatTxt.SendKeys(_aboutFlatText);
            Thread.Sleep(4000);
            var priceTxt = driver.FindElement(_priceTxt);
            priceTxt.SendKeys(_priceText);
            Thread.Sleep(2000);
            var ipotekaBtn = driver.FindElement(_ipotekaBtn);
            ipotekaBtn.Click();
            Thread.Sleep(2000);
            var saleTypeBtn = driver.FindElement(_saleTypeBtn);
            saleTypeBtn.Click();
            Thread.Sleep(4000);
            var numberTxt = driver.FindElement(_numberTxt);
            numberTxt.SendKeys(_numberText);
            Thread.Sleep(6000);
            var payServiceBtn = driver.FindElement(By.XPath("//input[contains(@class,'dd31006766--input--pEuc7')]"));
            payServiceBtn.Click();
            Thread.Sleep(4000);
            var publishBtn = driver.FindElement(_publishBtn);
            publishBtn.Click();
            Assert.Pass();
        }
        [TearDown]
        public void TearDown()
        {
        }
    }
}