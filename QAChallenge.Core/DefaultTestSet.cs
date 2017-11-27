using QAChallengePT.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallengePT.Core
{
    public class DefaultTestSet : ITestSet
    {
        public IEnumerable<ITestCase> Cases
        {
            get; set;
        }

        public ITestSetMetadata Metadata
        {
            get; set;
        }

        //public ITestSetResult Execute(ITestRunner context)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
