using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QAChallengePT.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallengePT.Core
{
    public class TestCaseRunner : ITestRunner
    {
        private IContext context;


        public TestCaseRunner(IContext context)
        {
            this.context = context;
        }

        protected ITestSet LoadTestSet(IContext context)
        {
            return new DefaultLoader(context).Load(this);
        }

        protected void Save(ITestSetResult result)
        {
            ISaver saver = GetSaver(result);
            saver.Save(result);
        }

        private ISaver GetSaver(ITestSetResult result)
        {
            return new ConsoleSaver();
        }

        protected virtual ITestSetResult Run(ITestSet testSet)
        {
            using (Driver = new ChromeDriver())
            {
                var res = new DefaultTestSetResult();
                res.TestSet = testSet;
                res.Results = testSet.Cases.Select(testCase => Run(testCase)).ToList();

                return res;
            }
        }

        protected virtual ITestCaseResult Run(ITestCase testCase)
        {
            var res = new DefaultTestCaseResult();
            dynamic dynamicTestCase = res.Case = testCase;
            res.Results = dynamicTestCase.Run(context);
            return res;
        }

        protected virtual ITestStepResult Run(ITestStep step)
        {
            var status = new DefaultStatus();
            var res = new DefaultTestStepResult()
            {
                Step = step,
                Status = status
            };
            try
            {
                var seleniumStep = (SeleniumTestStep)step;
                seleniumStep.Driver = Driver;
            }
            catch
            {
                status.Outcome = null;
            }

            return res;
        }

        public void Run(IContext context)
        {
            ITestSet testSet = LoadTestSet(context);
            ITestSetResult result = Run(testSet);
            Save(result);
        }

        IWebDriver Driver
        {
            get { return (IWebDriver)context.Data["Driver"]; }
            set { context.Data["Driver"] = value; }
        }
    }
}
