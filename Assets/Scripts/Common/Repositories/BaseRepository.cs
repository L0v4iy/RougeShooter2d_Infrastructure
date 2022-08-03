using System.Collections.Generic;
using System.Linq;

namespace Common.Repositories
{
    /// <summary>
    /// Keeps objects typeof "T"
    /// </summary>
    /// <typeparam name="T">object type</typeparam>
    public abstract class BaseRepository<T> : IRepository
    {
        private readonly List<T> _items = new List<T>();

        public void AddItem(T item)
        {
            _items.Add(item);
        }

        public void RemoveItem(T item)
        {
            _items.Remove(item);
        }

        public List<T> GetItems()
        {
            return new List<T>(_items);
        }

        public TS GetItemOfType<TS>() where TS : T
        {
            return (TS) _items.FirstOrDefault(i => i.GetType() == typeof(TS));
        }

        public int CountItems()
        {
            return _items.Count;
        }

        public void Clear()
        {
            _items.Clear();
        }
    }
}