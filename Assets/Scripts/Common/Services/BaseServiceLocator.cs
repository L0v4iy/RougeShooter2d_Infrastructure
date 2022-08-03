using System;
using System.Collections.Generic;
using System.Linq;

namespace Common.Services
{
    /// <summary>
    /// Has multiple classes inherited from "T" inside
    /// </summary>
    /// <typeparam name="T">Parent type</typeparam>
    public abstract class BaseServiceLocator<T> : IService<T>
    {
        private readonly Dictionary<Type, List<T>> _subscribers =
            new Dictionary<Type, List<T>>();

        public void AddSubscriber(T subscriber)
        {
            Type t = subscriber.GetType();
            if (!_subscribers.ContainsKey(t))
                _subscribers.Add(t, new List<T>());
            _subscribers[t].Add(subscriber);
        }

        public void RemoveSubscriber(T subscriber)
        {
            Type t = subscriber.GetType();
            _subscribers[t].Remove(subscriber);
            if (!_subscribers[t].Any())
                _subscribers.Remove(t);
        }

        public void CallSubscribers<TS>(Action<TS> action) where TS : T
        {
            Type t = typeof(T);
            if (!_subscribers.ContainsKey(t)) return;
            foreach (T s in _subscribers[t])
                action((TS) s);
        }

        protected void CallAllSubscribers(Action<T> action)
        {
            List<T> subs = new List<T>();
            foreach (KeyValuePair<Type, List<T>> ts in _subscribers)
            {
                subs.AddRange(ts.Value);
            }

            foreach (T sub in subs)
            {
                action(sub);
            }
        }
    }
}