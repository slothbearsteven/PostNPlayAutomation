using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMessage.Pages
{
    internal class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='app'']/div/div/div[2]/div/div[2]/div/div/strong/a")]
        private IWebElement chatLink;

        public ChatPage NavigateToChat()
        {
            chatLink.Click();

            return new ChatPage(driver);
        }

    }
}
