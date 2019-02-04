﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PushkaGraphCore
{
    public class Vertex
    {
        private readonly HashSet<Vertex> _adjacentVertices;
        private readonly HashSet<Edge> _incidentEdges;

        public Vertex[] AdjacentVertices => _adjacentVertices.ToArray();
        public Edge[] IncidentEdges => _incidentEdges.ToArray();

        internal Vertex()
        {
            _adjacentVertices = new HashSet<Vertex>();
            _incidentEdges = new HashSet<Edge>();
        }

        public Vertex GetAdjacentVertexBy(Edge edge)
        {
            Vertex adjacentVertex = null;

            if (edge.FirstVertex == this)
                adjacentVertex = edge.SecondVertex;

            if (edge.SecondVertex == this)
                adjacentVertex = edge.FirstVertex;

            return adjacentVertex;
        }

        internal void AddAdjacentVertex(Vertex vertex)
        {
            _adjacentVertices.Add(vertex);        
        }

        internal void DeleteAdjacentVertex(Vertex vertex)
        {
            _adjacentVertices.Remove(vertex);
        }

        internal void AddIncidentEdge(Edge edge)
        {
            _incidentEdges.Add(edge);
        }

        internal void DeleteIncidentEdge(Edge edge)
        {
             _incidentEdges.Remove(edge);
        }
    }
}
