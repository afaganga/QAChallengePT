using System.Collections.Generic;

namespace QAChallengePT.Interfaces
{
    public interface ITestSetResult
    {
        ITestSet TestSet { get; }

        IList<ITestCaseResult> Results { get; }

        IStatus Status { get; set; }

        //IContext Context { get; set; }
    }
}