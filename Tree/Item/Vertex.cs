using System;
using System.Collections.Generic;
using System.Text;

namespace MyCollectionLib.Item
{
    public class Vertex<T>
    {
        public string name;
        public T Value { get; set; }

        public Vertex(T value) 
        {
            Value = value;
        }
    }
}
