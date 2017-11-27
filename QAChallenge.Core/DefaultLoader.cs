using Newtonsoft.Json;
using QAChallengePT.Interfaces;
using System;
using System.IO;

namespace QAChallengePT.Core
{
    public class DefaultLoader : ILoader
    {
        private IContext context;

        public DefaultLoader(IContext context)
        {
            this.context = context;
        }

        protected string[] Args
        {
            get
            {
                return (string[])context.Data["args"];
            }
        }

        private string FileName { get { return Args[0]; } }

        public ITestSet Load(ITestRunner runner)
        {
            var text = File.ReadAllText(FileName);

            var deserialized = (ITestSet)JsonConvert.DeserializeObject(text, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });

            return deserialized;
        }
    }
}