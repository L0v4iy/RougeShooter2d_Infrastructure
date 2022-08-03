using World.AI.Example;

namespace World.AI.FsmBase
{
    /// <summary>
    /// /// Example: <see cref="FsmBehaviourExample"/>
    /// </summary>
    public abstract class BaseFsmBehaviour : IFsmBehaviour
    {
        protected readonly BaseFsmWorker Worker;
    
        /// <summary>
        /// State which allows to <see cref="Update()"/> fsm behaviour
        /// </summary>
        protected string BehaviourInvokeState { get; private set; }

        /// <summary>
        /// Enable or disable <see cref="Update()"/>
        /// </summary>
        private bool _active;

        protected BaseFsmBehaviour(BaseFsmWorker worker)
        {
            Worker = worker;
        }

        public void SetInvokeState(string invokeState)
        {
            BehaviourInvokeState = invokeState;
        }

        public void OnWorkerStateChanged(string workerState)
        {
            _active = BehaviourInvokeState.Equals(workerState);
        }

        /// <summary>
        /// <see cref="World.AI.FsmBase.IFsmBehaviour"/>'s worker cog
        /// </summary>
        public void Update()
        {
            if (_active)
                OnUpdate();
        }

        protected abstract void OnUpdate();
    }
}