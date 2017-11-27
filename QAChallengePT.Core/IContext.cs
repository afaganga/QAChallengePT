using System.Collections;
using System.Collections.Generic;

namespace QAChallengePT.Interfaces
{
    public interface IContext
    {
        IDictionary<string, object> Data { get; }
    }
}