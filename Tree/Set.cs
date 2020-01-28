using System;
using System.Collections.Generic;
using System.Text;

namespace MyCollectionLib
{
    public class Set<T>
    {
        List<T> list;
        public Set(T value)
        {
            list = new List<T>();
            list.Add(value);
        }

        public bool Add(T value)
        {
            if (isExist(value))
            {
                list.Add(value);
                return true;
            }
            return false;
        }
        bool isExist(T value)
        {
            foreach(T t in list)
            {
                if (t.Equals(value))
                    return false;
            }
            return true;
        }
    }
}
