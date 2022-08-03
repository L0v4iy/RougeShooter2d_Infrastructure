using World.AI.FsmBase;

namespace World.AI.Example
{
    public class FsmBehaviourExample : BaseFsmBehaviour
    {
        public FsmBehaviourExample(BaseFsmWorker worker) : base(worker)
        {
            SetInvokeState("Kill");
        }

        protected override void OnUpdate()
        {
            // Some actions
            // get unit with Worker.GetComponent on Constructor method
            Worker.SetWorkerState("Killed");
            Worker.RemoveBehaviour(this);
        }
    }
}