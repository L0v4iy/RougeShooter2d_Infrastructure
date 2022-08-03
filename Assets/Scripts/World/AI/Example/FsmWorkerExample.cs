using World.AI.FsmBase;

namespace World.AI.Example
{
    public class FsmWorkerExample : BaseFsmWorker
    {
        private void Awake()
        {
            AddBehaviour(new FsmBehaviourExample(this));
        }
    }
}

