using System;
using System.Collections.Generic;
using System.Text;

namespace MyCollectionLib.Item
{
    public class Edge<T>
    {
        public Vertex<T> LeftVertex { get; }
        public Vertex<T> RightVertex { get; }

        public Edge(Vertex<T> left, Vertex<T> right)
        {
            LeftVertex = left;
            RightVertex = right;
        }
    }
}
