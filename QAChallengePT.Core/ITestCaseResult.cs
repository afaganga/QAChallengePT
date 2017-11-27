using System.Collections.Generic;

namespace QAChallengePT.Interfaces
{
    public interface ITestCaseResult
    {
        ITestCase Case { get; }

        IStatus Status { get; }

        IList<ITestCaseResult> Results { get; }
    }
}