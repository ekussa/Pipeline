namespace Pipeline.WorkSet
{
    public abstract class SingleStepWorkflow : IWorkSet
    {
        private int _counter;
        private readonly IWork _work;
        public string Name { get; set; }

        protected SingleStepWorkflow(IWork work)
        {
            _work = work;
        }

        public IWork Next()
        {
            return _counter++ == 1 ? null : _work;
        }
    }
}
