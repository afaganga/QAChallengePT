using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallengePT.Core
{
    public abstract class SeleniumPageObject
    {
        private abstract class DriverIndexer<T, I> : IIndexer<T, I>.Get
        {
            public abstract T this[I index] { get; }

            public virtual IWebDriver Driver { get; protected set; }
        }

        private class ElementIndexer : DriverIndexer<IWebElement, By>
        {
            public ElementIndexer(IWebDriver driver)
            {
                Driver = driver;
            }

            public override IWebElement this[By index]
            {
                get
                {
                    return Driver.FindElement(index);
                }
            }

            public IIndexer<IWebElement, string>.Get Id
            {
                get
                {
                    return new AdaptorIndexer<IWebElement, By, string>(this, By.Id);
                }
            }

            public IIndexer<IWebElement, string>.Get XPath
            {
                get
                {
                    return new AdaptorIndexer<IWebElement, By, string>(this, By.XPath);
                }
            }
        }

        protected IWebDriver Driver { get; set; }

        public abstract string Url { get; }

        public void NavigateToUrl()
        {
            Driver.Navigate().GoToUrl(Url);
        }

        public void MoveTo(IWebElement elem)
        {
            new Actions(Driver).MoveToElement(elem).Perform();
        }

        protected virtual IIndexer<IWebElement, By>.Get Element
        {
            get
            {
                return new ElementIndexer(Driver);
            }
        }

        protected virtual IWebElement this[By by]
        {
            get
            {
                return Element[by];
            }
        }

        protected virtual IIndexer<IWebElement, string>.Get ById
        {
            get
            {
                return new ElementIndexer(Driver).Id;
            }
        }

        protected virtual IIndexer<IWebElement, string>.Get ByXPath
        {
            get
            {
                return new ElementIndexer(Driver).XPath;
            }
        }

        public virtual IDisposable SwitchTo(IWebElement frame)
        {
            var switchTo = Driver.SwitchTo();
            var holder = new Holder(switchTo);
            Driver.SwitchTo().Frame(frame);
            return holder;
        }

        private class Holder : IDisposable
        {
            private ITargetLocator targetLocator;

            public Holder(ITargetLocator targetLocator)
            {
                this.targetLocator = targetLocator;
            }

            public void Dispose()
            {
                targetLocator.ParentFrame();
            }
        }
    }
}
