using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphLib;

namespace MovieLib
{
    public sealed class MovieNode : Node<Movie>
    {
        public MovieNode(string id, Movie data) : base(id, data)
        {
        }
    }
}
