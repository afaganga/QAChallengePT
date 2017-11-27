using OpenQA.Selenium;
using QAChallengePT.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallengePT.Core
{
    public class DefaultContext : IContext
    {
        private Dictionary<string, object> data = new Dictionary<string, object>();

        public IDictionary<string, object> Data
        {
            get
            {
                return data;
            }
        }

        public IWebDriver Driver
        {
            get
            {
                return (IWebDriver)data[nameof(Driver)];
            }
            set
            {
                data[nameof(Driver)] = value;
            }
        }
    }
}
