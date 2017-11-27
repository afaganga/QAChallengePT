using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallengePT.Interfaces
{
    public interface ITestStepResult
    {
        ITestStep Step { get; }

        IStatus Status { get; }
    }
}
