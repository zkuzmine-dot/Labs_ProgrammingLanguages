namespace Lab_1
{
    public class MyQueue<T>
    {
        private T[] _items;        
        private int _size;         
        private const int DefaultCapacity = 4; 

        public MyQueue()
        {
            _items = new T[DefaultCapacity];
            _size = 0;
        }

        public int Count => _size;  

        
        public void Enqueue(T item)
        {
            if (_size == _items.Length)
                EnsureCapacity();

            _items[_size] = item;
            _size++;
        }

        
        public T Dequeue()
        {
            if (_size == 0)
                throw new InvalidOperationException("Queue is empty");

            T item = _items[0];
            
            for (int i = 1; i < _size; i++)
            {
                _items[i - 1] = _items[i];
            }
            _items[_size - 1] = default(T); 
            _size--;
            return item;
        }

        
        public T Peek()
        {
            if (_size == 0)
                throw new InvalidOperationException("Queue is empty");
            return _items[0];
        }

        
        public bool Contains(T item)
        {
            for (int i = 0; i < _size; i++)
            {
                if (Equals(_items[i], item))
                    return true;
            }
            return false;
        }

        
        private void EnsureCapacity()
        {
            int newCapacity = _items.Length * 2;
            T[] newArray = new T[newCapacity];
            
            Array.Copy(_items, 0, newArray, 0, _size);
            _items = newArray;
        }
    }
}
