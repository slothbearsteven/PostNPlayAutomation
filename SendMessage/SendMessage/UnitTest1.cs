using SendMessage.Pages;

namespace SendMessage
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]

        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void SendMessageTest()
        {
            LoginPage login = new LoginPage(driver);
            login.GoToPage();
            login.Login();

            HomePage home = new HomePage(driver);
            home.NavigateToChat();

            ChatPage chat = new ChatPage(driver);
            chat.SendMessage();

        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}