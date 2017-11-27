using System.Collections.Generic;

namespace QAChallengePT.Interfaces
{
    public interface ITestSet
    {
        //ITestSetResult Execute(ITestRunner context);

        IEnumerable<ITestCase> Cases { get; }
        ITestSetMetadata Metadata { get; set; }
    }
}