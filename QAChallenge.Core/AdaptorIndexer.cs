using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallengePT.Core
{
    internal class AdaptorIndexer<T1, A1, I1> : IIndexer<T1, I1>.Get
    {
        private readonly Func<I1, A1> adaptor;
        private readonly IIndexer<T1, A1>.Get toAdapt;

        public AdaptorIndexer(IIndexer<T1, A1>.Get indexer, Func<I1, A1> func)
        {
            toAdapt = indexer;
            this.adaptor = func;
        }

        public T1 this[I1 index]
        {
            get
            {
                return toAdapt[adaptor(index)];
            }
        }
    }
}
