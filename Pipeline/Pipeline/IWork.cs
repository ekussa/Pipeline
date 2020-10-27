using System;
using System.Collections.Generic;

namespace Pipeline
{
    public interface IWork
    {
        string Name { get; set; }
        Exception Forward(IDictionary<string, string> parameters);
        Exception Backward(IDictionary<string, string> parameterSet);
    }
}
