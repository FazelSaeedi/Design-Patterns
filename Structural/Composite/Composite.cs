using System;
using System.Collections;
using System.Collections.Generic;

namespace Design_Patterns.Structural.Composite
{
    public class Composite : Component, IEnumerable
    {
        private List<Component> _children = new List<Component>();
        public void AddChild(Component child)
        {
            _children.Add(child);
        }
        public void RemoveChild(Component child)
        {
            _children.Remove(child);
        }
        public Component GetChild(int index)
        {
            return _children[index];
        }
        public void Operation()
        {
            string message = string.Format("Composite with {0} child(ren)", _children.Count);
            Console.WriteLine(message);
        }
        public IEnumerator GetEnumerator()
        {
            foreach (Component child in _children)
                yield return child;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
