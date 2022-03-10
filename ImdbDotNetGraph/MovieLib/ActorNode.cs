using GraphLib;

namespace MovieLib
{
    public sealed class ActorNode : Node<Actor>
    {
        public ActorNode(string id, Actor data) : base(id, data)
        {
        }
    }
}