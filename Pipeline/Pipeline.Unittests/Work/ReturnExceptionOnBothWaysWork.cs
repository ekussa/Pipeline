using System;
using System.Collections.Generic;
using Pipeline;

namespace Driver.Audio.UnitTests.Work
{
    public class ReturnExceptionOnBothWaysWork : IWork
    {
        public string Name { get; set; }

        public Exception Forward(IDictionary<string, string> parameters)
        {
            return new StepForwardException();
        }

        public Exception Backward(IDictionary<string, string> parameterSet)
        {
            return new StepBackwardException();
        }
    }
}