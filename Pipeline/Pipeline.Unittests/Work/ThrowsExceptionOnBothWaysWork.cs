using System;
using System.Collections.Generic;
using Pipeline;

namespace Driver.Audio.UnitTests.Work
{
    public class ThrowsExceptionOnBothWaysWork : IWork
    {
        public string Name { get; set; }

        public Exception Forward(IDictionary<string, string> parameters)
        {
            throw new StepForwardException();
        }

        public Exception Backward(IDictionary<string, string> parameterSet)
        {
            throw new StepBackwardException();
        }
    }
}