using System;

namespace GraphLib
{
    public class Node
    {
        public string Id { get; }

        protected Node(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException($"{nameof(id)} parameter must have a non-null, non-empty value.",
                    nameof(id));
            }

            Id = id;
        }

        protected bool Equals(Node other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Node) obj);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    public class Node<T> : Node
    {
        public T Data { get; }

        protected Node(string id, T data) : base(id)
        {
            Data = data;
        }
    }
}
