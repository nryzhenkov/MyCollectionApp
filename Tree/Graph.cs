using MyCollectionLib.Item;

namespace MyCollectionLib
{
    public class Graph<T>
    {
        Set<Vertex<T>> vertexes = new Set<Vertex<T>>();
        Set<Edge<Vertex<T>>> edges = new Set<Edge<Vertex<T>>>();

        public void AddEdge(Edge<Vertex<T>> edge)
        {
            edges.Add(edge);
        }

        public void AddVertex(Vertex<T> vertex)
        {
            vertexes.Add(vertex);
        }
    }
}
