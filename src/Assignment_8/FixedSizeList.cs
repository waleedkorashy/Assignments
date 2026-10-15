using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_8
{
    //5.Implement a custom list called FixedSizeList<T> with a
    //predetermined capacity. This list should not allow more elements
    //than its capacity and should provide clear messages if one tries to
    //exceed it or access invalid indices.

    //1.Create a generic class named FixedSizeList<T>.
    internal class FixedSizeList<T>
    {
        private readonly List<T> _list;
        private readonly int _capacity;

        public int Capacity => _capacity;
        public int Count => _list.Count;

        //2.Implement a constructor that takes the fixed capacity of the list as a parameter.

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentOutOfRangeException(nameof(capacity),
                    "Capacity must be greater than zero.");

            _capacity = capacity;
            _list = new List<T>(capacity);
        }



        //3.Implement an Add method that adds an element to the list, but throws an exception if the list is already full.

        public void AddElement(T element)
        {
            if (_list.Count >= _capacity)
                throw new InvalidOperationException(
                    $"Cannot add element: the list is full (capacity = {_capacity}).");

            _list.Add(element);
        }


        //4.Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.

        public T GetElement(int index)
        {
            if (index < 0 || index >= _list.Count)
                throw new ArgumentOutOfRangeException(nameof(index),
                    $"Invalid index {index}. Valid indices are 0 to {_list.Count - 1} (current count = {_list.Count}).");

            return _list[index];
        }

    }
}
