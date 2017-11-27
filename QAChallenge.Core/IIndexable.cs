using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallengePT.Core
{
    public static class IIndexer<T, I>

    {
        public interface Get { T this[I index] { get; } }

        public interface Set { T this[I index] { set; } }

        public interface Both : Get, Set { }

    }
}
