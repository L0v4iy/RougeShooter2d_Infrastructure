using System.Collections.Generic;
using UnityEngine;
using World.AI.Example;

namespace World.AI.FsmBase
{
    /// <summary>
    /// Put inherited class as <see cref="World.Unit.Components"/> to unit >
    /// Example: <see cref="FsmWorkerExample"/>
    /// </summary>
    public abstract class BaseFsmWorker : MonoBehaviour
    {
        private readonly List<IFsmBehaviour> _behaviours = new List<IFsmBehaviour>();

        internal void AddBehaviour(BaseFsmBehaviour behaviour)
        {
            if (_behaviours.Contains(behaviour))
            {
                Debug.LogError($"Behaviour {behaviour.GetType().Name} already registered");
                return;
            }

            _behaviours.Add(behaviour);
        }

        internal void RemoveBehaviour(FsmBehaviourExample behaviour)
        {
            if (_behaviours.Contains(behaviour))
                _behaviours.Remove(behaviour);
        }

        private void Update()
        {
            // to prevent array changes
            //TODO:2022-05-03 13:38:21 rework as in EntityCommandBuffer 'DOTS'
            foreach (IFsmBehaviour behaviour in _behaviours.ToArray())
            {
                behaviour.Update();
            }
        }

        public void SetWorkerState(string state) => _behaviours.ForEach(b => b.OnWorkerStateChanged(state));
    }
}