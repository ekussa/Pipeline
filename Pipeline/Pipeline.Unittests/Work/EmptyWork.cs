using System;
using System.Collections.Generic;
using Pipeline;

namespace Driver.Audio.UnitTests.Work
{
    public class EmptyWork : IWork
    {
        public string Name { get; set; }

        public Exception Forward(IDictionary<string, string> parameters)
        {
            return null;
        }

        public Exception Backward(IDictionary<string, string> parameterSet)
        {
            return null;
        }
    }
}
