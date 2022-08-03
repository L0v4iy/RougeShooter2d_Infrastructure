using System;
using System.Collections.Generic;
using System.Linq;

namespace Common.Services
{
    /// <summary>
    /// Has single class inherited from "T" inside
    /// </summary>
    /// <typeparam name="T">Parent type</typeparam>
    public abstract class BaseEventService<T> : IService<T>
    {
        private readonly List<T> _subscribers = new List<T>();

        public void AddSubscriber(T subscriber)
        {
            _subscribers.Add(subscriber);
            OnAddSubscriber(subscriber);
        }
        
        protected virtual void OnAddSubscriber(T subscriber)
        {
        }

        public void RemoveSubscriber(T subscriber)
        {
            _subscribers.Remove(subscriber);
            OnRemoveSubscriber(subscriber);
        }
        
        protected virtual void OnRemoveSubscriber(T subscriber)
        {
        }

        protected void CallSubscribers<TS>(Action<TS> action) where TS : T
        {
            foreach (T subscriber in _subscribers)
            {
                action((TS) subscriber);
            }
        }

        protected void RemoveSubscribers()
        {
            _subscribers.ToList().ForEach(RemoveSubscriber);
        }
    }
}