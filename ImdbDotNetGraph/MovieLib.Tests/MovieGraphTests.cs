using System;
using System.Collections.Generic;
using GraphLib;
using Xunit;

namespace MovieLib.Tests
{
    public class MovieGraphTests
    {
        [Fact]
        public void CanAddAndLookupMoviesAndActorsToDictionary()
        {
            var adjacencyList = new Dictionary<Node, IEnumerable<Node>>();

            var movieNode = new MovieNode("Pulp Fiction", new Movie());
            var castNodes = new[]
            {
                new ActorNode("Uma Thurman", new Actor()),
                new ActorNode("Samuel Jackson", new Actor()),
                new ActorNode("John Travolta", new Actor()),
            };
            
            adjacencyList.Add(movieNode, castNodes);

            movieNode = new MovieNode("Goodfellas", new Movie());
            castNodes = new[]
            {
                new ActorNode("Robert DeNiro", new Actor()),
                new ActorNode("Samuel Jackson", new Actor()),
                new ActorNode("Joe Pesci", new Actor()),
            };

            adjacencyList.Add(movieNode, castNodes);

            var pulpFictionMovieNode = adjacencyList[new MovieNode("Pulp Fiction", new Movie())];
        }

        public void GraphTest()
        {
            var graph = new Graph();
            var movie = new Movie()
            graph.AddCast(movie, new Actor());
            graph.AddCast(movie, new Actor());
            graph.AddCast(movie, new Actor());
            graph.AddCast(movie, new Actor());

        }
    }
}
