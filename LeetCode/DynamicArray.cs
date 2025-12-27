
namespace LeetCode
{
    public class DynamicArray
    {
        private int[] _array;
        private int _size;

        public DynamicArray(int capacity)
        {
            _array = new int[capacity];
            _size = 0;
        }

        public int Get(int i)
        {
            if(i < 0 || i >= _size)
                throw new IndexOutOfRangeException();
            return _array[i];
        }
        public void Set(int i , int n)
        {
            if(n < 0 || n >= _size)
                throw new IndexOutOfRangeException();
            _array[i] = n;
        }
        public void PushBack(int n)
        {
            if(_size == _array.Length)
                Resize();
            _array[_size++] = n;
        }
        public int PopBack()
        {
            if (_size == 0)
                throw new InvalidOperationException("Array is empty!!!");
            int value= _array[_size - 1];
            _array[_size - 1] = 0;

            _size--;
            return value;
        }
        private void Resize()
        {
            int newSize = _array.Length * 2;
            int[] newArray = new int[newSize];
            for(int i=0; i< _size; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
        public int GetSize()
        {
            return _size;
        }

        public int GetCapacity()
        {
            return _array.Length;
        }
    }
}
