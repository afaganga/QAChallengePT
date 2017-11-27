using System;
using System.Collections.Generic;
using QAChallengePT.Interfaces;

namespace QAChallengePT.Core
{
    internal class DefaultTestSetResult : ITestSetResult
    {
        public IStatus Status
        {
            get;set;
        }

        public IList<ITestCaseResult> Results
        {
            get;set;
        }

        public ITestSet TestSet
        {
            get;set;
        }
    }
}