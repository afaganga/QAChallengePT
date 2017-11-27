using System;
using System.Collections.Generic;
using QAChallengePT.Interfaces;

namespace QAChallengePT.Core
{
    internal class DefaultTestCaseResult : ITestCaseResult
    {
        public ITestCase Case
        {
            get;set;
        }

        public IList<ITestCaseResult> Results
        {
            get;set;
        }

        public IStatus Status
        {
            get;set;
        }
    }
}