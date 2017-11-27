using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using QAChallengePT.Core;
using QAChallengePT.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallengePT.Otodom
{
    public class RentFlatPage : SeleniumPageObject
    {
        public RentFlatPage(IContext context)
        {
            Driver = context.Data["Driver"] as IWebDriver;
        }

        public override string Url { get { return "https://www.otodom.pl/wynajem/mieszkanie/nowe-ogloszenie/"; } }


        public IWebElement CookiesButton
        {
            get
            {
                return ByXPath["//*[@id=\"cookiesBar\"]/a"];
            }
        }

        public IWebElement Title
        {
            get { return ById["add-title"]; }
        }

        public IWebElement Price
        {
            get { return ByXPath["//*[@id=\"newOffer\"]/fieldset[1]/div[2]/div[1]/div/div/div/div[1]/input"]; } 
        }

        public IWebElement Surface
        {
            get { return ById["param7"]; }
        }

        public IWebElement Rooms
        {
            get { return ById["param57"]; }
        }

        public IWebElement Type
        {
            get { return ByXPath["//*[@id=\"private-business-div\"]/div[1]/div"]; }
        }

        public IWebElement Map
        {
            get { return this[By.XPath("//*[@id=\"newOffer\"]/fieldset[3]/div[1]/div[1]/div/span")]; }
        }

        public IWebElement Place
        {
            get { return ByXPath["/html/body/span/span/span[1]/input"]; }
        }

        public IWebElement DescriptionFrame
        {
            get { return ById["wysiwyg_ifr"]; }
        }

        public IWebElement Description
        {
            get { return ById["tinymce"]; }
        }

        public IWebElement Name
        {
            get { return this[By.Id("add-person")]; }
        }

        public IWebElement Email
        {
            get { return Element[By.Id("add-email")]; }
        }

        public IWebElement TermsAndconditions
        {
            get { return ByXPath["//*[@id=\"accept\"]/div/label"]; }
        }

        public IWebElement CreateButton
        {
            get { return ById["preview-link"]; }
        }


    }
}
