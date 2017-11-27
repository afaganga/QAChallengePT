using QAChallengePT.Interfaces;
using QAChallengePT.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QAChallengePT.Console
{
    class Program
    {

        static void Main(string[] args)
        {
            IContext context = CreateContext(args);
            ITestRunner runner = CreateRunner(context);
            runner.Run(context);
        }

        private static IContext CreateContext(string[] args)
        {
            var ctx = new DefaultContext();
            ctx.Data["args"] = args;
            return ctx;
        }

        private static ITestRunner CreateRunner(IContext context)
        {
            //TODO: DI
            //return new DefaultRunner(context);
            return new TestCaseRunner(context);
        }
    }
}
