using OpenQA.Selenium;
using QAChallengePT.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace QAChallengePT.Core
{
    public abstract class SeleniumTestStep : ITestStep
    {

        [IgnoreDataMember]
        public IWebDriver Driver { get; set; }
        public abstract ITestStepResult Execute(IContext context);
    }
}
