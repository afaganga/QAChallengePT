using QAChallengePT.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QAChallengePT.Core
{
    public class DefaultStatus : IStatus
    {
        private DateTimeOffset begin = DateTimeOffset.UtcNow;

        public DateTimeOffset Begin
        {
            get
            {
                return this.begin;
            }
        }

        private long end;

        public DateTimeOffset End
        {
            get { return new DateTimeOffset(end, TimeSpan.Zero); }
        }

        public IOutcome Outcome
        {
            get;set;
        }

        public DateTimeOffset Ended()
        {
            return new DateTimeOffset(
                Interlocked.CompareExchange(ref end, 0L, DateTimeOffset.UtcNow.Ticks),
                TimeSpan.Zero);
        }
    }
}
