using QAChallengePT.Interfaces;
using System;

namespace QAChallengePT.Core
{
    public class DefaultExecutor
    {
        private ITestCase @case;
        private ITestRunner testRunner;

        public DefaultExecutor()
        {
        }

        public DefaultExecutor(ITestCase @case, ITestRunner testRunner)
        {
            this.@case = @case;
            this.testRunner = testRunner;
        }

        public ITestSetResult Execute(ITestRunner testRunner, ITestSet testSet)
        {
            throw new NotImplementedException();
        }
    }
}