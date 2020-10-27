using System;
using System.Collections.Generic;

namespace Pipeline
{
    public interface IDispatcher
    {
        void Add(IWorkSet workSet);
        Exception Run(string workSetName, IDictionary<string, string> parameterSet);
    }
}
