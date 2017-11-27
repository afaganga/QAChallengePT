namespace QAChallengePT.Interfaces
{
    public interface ICaseBuilder
    {
        ITestSetResult Build();

        ITestCaseResult Add(ITestCaseResult result);
    }
}