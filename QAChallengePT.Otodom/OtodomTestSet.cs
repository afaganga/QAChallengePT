using OpenQA.Selenium;
using QAChallengePT.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace QAChallengePT.Otodom
{
    public class OtodomTestSet : ITestSet
    {
        static string Email
        {
            get
            {
                var number = new Random().Next(1000, 9999);
                return $"qachallengept+{number}@gmail.com";
            }
        }

        private const string defaultText = "QAChallenge";

        IWebDriver Driver { get; set; }
        public IEnumerable<ITestCase> Cases
        {
            get
            {
                return new[]
                {
                        new Case1()
                    };
            }
        }

        [DataMember]
        public ITestSetMetadata Metadata
        {
            get; set;
        }

        public class Case1 : ITestCase
        {
            [IgnoreDataMember]
            public IEnumerable<ITestStep> Steps
            {
                get
                {
                    throw new NotImplementedException("Use Run instead");
                }
            }

            public ITestCaseResult Run(IContext ctx)
            {
                var sut = new RentFlatPage(ctx);
                sut.NavigateToUrl();
                sut.CookiesButton.Click();
                sut.Title.SendKeys(defaultText);
                sut.Price.SendKeys("1234");
                sut.Surface.SendKeys("1234");
                sut.Rooms.SendKeys("1");
                sut.Type.Click();
                sut.MoveTo(sut.Map);
                sut.Map.Click();
                sut.Place.SendKeys("Kraków, małopolskie");
                using (var switchBack = sut.SwitchTo(sut.DescriptionFrame))
                {
                    sut.Description.SendKeys(Enumerable.Range(1, 30).Aggregate("", (str, idx) => str + " " + defaultText));
                }
                sut.Name.SendKeys(defaultText);
                sut.Email.SendKeys(Email);
                sut.TermsAndconditions.Click(); // map focus
                sut.TermsAndconditions.Click();
                sut.CreateButton.Click();
                return null;
            }

        }
    }


}
