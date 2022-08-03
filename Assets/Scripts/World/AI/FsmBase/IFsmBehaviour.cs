namespace World.AI.FsmBase
{
    public interface IFsmBehaviour
    {
        void SetInvokeState(string invokeState);
        void OnWorkerStateChanged(string workerState);
        void Update();
    }
}