using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using QAChallengePT.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace QAChallengePT.Core
{
    public class SeleniumElementActionsTestStep : SeleniumTestStep, ITestStep
    {

        [DataMember]
        public string Action { get; set; }

        [DataMember]
        public string ByStrategy { get; set; }

        [DataMember]
        public string ByParam { get; set; }

        [DataMember]
        public string Data { get; set; }


        [IgnoreDataMember]
        By By
        {
            get
            {
                var method = typeof(By).GetMethod(ByStrategy, BindingFlags.Public | BindingFlags.Static);
                return (By)method.Invoke(null, new[] { ByParam });
            }
        }

        public override ITestStepResult Execute(IContext context)
        {
            var elem = Driver.FindElement(By);
            var actions = new Actions(Driver);
            var method = typeof(Actions).GetMethods().First(m => m.Name == Action);
            var parameters = method.GetParameters().Any() ? new[] { elem } : new object[] { };
            method.Invoke(actions, parameters);
            return null;
        }
    }
}
