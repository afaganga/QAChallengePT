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
    public class SeleniumNavigateTestStep : SeleniumTestStep, ITestStep
    {


        [DataMember]
        public string Data { get; set; }


        public override ITestStepResult Execute(IContext context)
        {
            var target = Driver.Navigate();
            typeof(INavigation).GetMethod("GoToUrl", new[] { typeof(string) }).Invoke(target, new[] { Data });
            return null;
        }
    }
}
