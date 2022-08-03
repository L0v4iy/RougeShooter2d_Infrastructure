using System;
using System.Collections.Generic;
using System.Linq;

namespace Common.Utils
{
    public static class EnumUtil
    {
        /// <summary>
        /// Cast enum to collection with this enum values  
        /// </summary>
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }

        /// <summary>
        /// Return enum value equal to string if exists
        /// Or throw exception  
        /// </summary>
        public static T ParseEnum<T>(string value)
        {
            return (T) Enum.Parse(typeof(T), value);
        }

        /// <summary>
        /// Get enum value by value index
        /// Or throw exception  
        /// </summary>
        public static T ParseEnum<T>(int id)
        {
            foreach (T enumVal in GetValues<T>())
                if (enumVal.GetHashCode() == id)
                    return enumVal;
            throw new IndexOutOfRangeException($"id: {id}");
        }
    }
}