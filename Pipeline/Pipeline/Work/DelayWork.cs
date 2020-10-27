using System;
using System.Collections.Generic;
using System.Threading;

namespace Pipeline.Work
{
    public class DelayWork : IWork
    {
        public string Name { get; set; }
        public Exception Forward(IDictionary<string, string> parameters)
        {
            try
            {
                Thread.Sleep(Convert.ToInt32(parameters["Sleep"]));
                return null;
            }
            catch (Exception exception)
            {
                return exception;
            }
        }

        public Exception Backward(IDictionary<string, string> parameterSet)
        {
            return null;
        }
    }
}
