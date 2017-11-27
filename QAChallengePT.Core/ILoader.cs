namespace QAChallengePT.Interfaces
{
    public interface ILoader
    {
        ITestSet Load(ITestRunner context);
    }
}