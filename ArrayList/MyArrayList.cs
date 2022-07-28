using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

class MyArrayList<T> : IEnumerable<T>
{
    private const int InitialCapacity = 2;
    private T[] data;

    public MyArrayList(int capacity = InitialCapacity)
    {
        this.Capacity = capacity;
        this.data = new T[this.Capacity];
    }

    public int Count { get; set; }
    public int Capacity { get; set; }

    public void Add(T item)
    {
        if (this.Count == this.Capacity)
        {
            this.Capacity *= 2;
            T[] newData = new T[this.Capacity];
            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i];
            }
            this.data = newData;
        }
        this.data[this.Count++] = item;
    }
    public T Get(int index)
    {
        if (index >= this.Count)
        {
            throw new IndexOutOfRangeException();
        }
        return data[index];
    }
    public T RemoveAt(int index)
    {
        T item = this.data[index];
        T[] newData = new T[this.Capacity];
        if (index >= this.Count)
        {
            throw new IndexOutOfRangeException();
        }
        if (index == 0)
        {
            for (int i = 1; i < this.Count; i++)
            {
                newData[i] = this.data[i];
            }
        }
        else if (index == this.Count - 1)
        {
            for (int i = 0; i < this.Count - 1; i++)
            {
                newData[i] = this.data[i];
            }
        }
        else
        {
            for (int i = 0; i < index; i++)
            {
                newData[i] = data[i];
            }
            for (int i = index; i < this.Count - 1; i++)
            {
                newData[i] = this.data[i + 1];
            }
        }
        this.Count--;
        this.data = newData;

        if (this.Count <= this.Capacity / 4)
        {
            this.Capacity /= 2;
            T[] copy = new T[this.Capacity];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = data[i];
            }

            this.data = copy;
        }
        return item;
    }

    private void ThrowIndexOutOfRangeException(int index)
    {

        if (index >= this.Count)
        {
            throw new IndexOutOfRangeException();
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < this.Count; i++)
        {
            sb.Append($"{data[i]}");
        }
        return sb.ToString().Remove(sb.Length - 2);
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.Count; i++)
        {
            yield return data[i];
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

