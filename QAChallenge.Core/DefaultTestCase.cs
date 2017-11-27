using QAChallengePT.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallengePT.Core
{
    public class DefaultTestCase : ITestCase
    {
        public IEnumerable<ITestStep> Steps
        {
            get; set;
        }
    }
}
