using System;
using System.Collections.Generic;
using System.Linq;

namespace Pipeline
{
    public class Dispatcher : IDispatcher, IDisposable
    {
        private readonly Dictionary<string, IWorkSet> _dic;

        public Dispatcher()
        {
            _dic = new Dictionary<string, IWorkSet>();
        }

        public void Add(IWorkSet workSet)
        {
            _dic.Add(workSet.Name, workSet);
        }

        public Exception Run(string workSetName, IDictionary<string, string> parameterSet)
        {
            try
            {
                if(!_dic.ContainsKey(workSetName))
                    return new KeyNotFoundException(workSetName);
                var workSet = _dic[workSetName];
                var stack = new Stack<IWork>();
                while (true)
                {
                    var work = workSet.Next();
                    if (work == null)
                        break;
                    stack.Push(work);
                    Exception forwardResult;
                    try
                    {
                        forwardResult = work.Forward(parameterSet);
                    }
                    catch (Exception exception)
                    {
                        forwardResult = exception;
                    }
                    if (forwardResult == null) continue;
                    while (true)
                    {
                        if(!stack.Any())
                            break;
                        Exception backwardResult;
                        try
                        {
                            backwardResult = stack.Pop().Backward(parameterSet);
                        }
                        catch (Exception e)
                        {
                            backwardResult = e;
                        }
                        if (backwardResult != null)
                            return backwardResult;
                    }
                    return forwardResult;
                }

                return null;
            }
            catch (Exception exception)
            {
                return exception;
            }
        }

        public void Dispose()
        {
            _dic.Clear();
        }
    }
}
