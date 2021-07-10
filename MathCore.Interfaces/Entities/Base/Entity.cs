using System;
using System.Collections.Generic;

namespace MathCore.Interfaces.Entities.Base
{
    public abstract class Entity<T> : IEntity<T>, IEquatable<IEntity<T>>, IEquatable<Entity<T>>
    {
        public T Key { get; set; }

        public bool Equals(Entity<T> other) =>
            other != null 
            && other.GetType().IsInstanceOfType(this) 
            && EqualityComparer<T>.Default.Equals(Key, other.Key);

        public bool Equals(IEntity<T> other) =>
            other != null 
            && other.GetType().IsInstanceOfType(this) 
            && EqualityComparer<T>.Default.Equals(Key, other.Key);

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Entity<T>)obj);
        }

        public override int GetHashCode() => EqualityComparer<T>.Default.GetHashCode(Key);

        public static bool operator ==(Entity<T> left, Entity<T> right) => Equals(left, right);
        public static bool operator !=(Entity<T> left, Entity<T> right) => !Equals(left, right);
    }

    public abstract class Entity : Entity<int> { }
}