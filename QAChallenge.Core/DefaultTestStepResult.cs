using System;
using QAChallengePT.Interfaces;

namespace QAChallengePT.Core
{
    internal class DefaultTestStepResult : ITestStepResult
    {
        public DefaultTestStepResult()
        {
        }

        public IStatus Status
        {
            get; set;
        }

        public ITestStep Step
        {
            get; set;
        }
    }
}