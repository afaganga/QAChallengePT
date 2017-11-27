using System;

namespace QAChallengePT.Interfaces
{
    public interface IStatus
    {
        DateTimeOffset Begin { get; }
        DateTimeOffset End { get; }

        IOutcome Outcome { get; }
    }
}