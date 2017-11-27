using System.Collections.Generic;

namespace QAChallengePT.Interfaces
{
    public interface ITestCase
    {
        IEnumerable<ITestStep> Steps { get; }
    }
}