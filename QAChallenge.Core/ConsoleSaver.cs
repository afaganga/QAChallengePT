using QAChallengePT.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace QAChallengePT.Core
{
    public class ConsoleSaver : ISaver
    {
        TextWriter writer = System.Console.Out;
        public void Save(ITestSetResult result)
        {
            Save(result.TestSet);
            Save(result.Results);
        }

        private void Save(IList<ITestCaseResult> testCasesResult)
        {
            foreach (var result in testCasesResult)
                Save(result);
        }

        private void Save(ITestCaseResult result)
        {
            
        }

        private void Save(ITestSet testSet)
        {
            Save(testSet?.Metadata);
        }

        private void Save(ITestSetMetadata metadata)
        {
            writer.WriteLine(metadata?.Name);
        }
    }
}