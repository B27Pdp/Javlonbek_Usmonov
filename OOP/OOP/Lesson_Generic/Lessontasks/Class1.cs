namespace OOP.Lesson_Generic.Lessontasks
{
    public class Class1<T>
    {
        
        private List<T> list = new List<T>(5);
        public T this[int i]
        {
            get { return list[i]; }
        }
        public void AddValue(T item)
        {
            list.Add(item);
        }
        public void RemoveValue(T item)
        {
            list.Remove(item);
        }
        public void Print()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void Print_Index(int n)
        {
            for (int i = 0; i < list.Capacity; i++)
            {
                if (i == n)
                {
                    Console.WriteLine(list[n]);
                }
            }
        }
        public void Remove_Index(int n)
        {
            list.RemoveAt(n);
        }
    }
}

