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
        public void Print()
        {
            Console.WriteLine("! MENU !");
            Console.WriteLine("1. AddValue");
            Console.WriteLine("2. RemoveValue");
            Console.WriteLine("3. Print_Index");
            Console.WriteLine("4. Remove_Index");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        int a = int.Parse(Console.ReadLine());
                        Class1<int> obj = new Class1<int>();
                        obj.AddValue(a);
                        break;
                    }
                case 2:
                    {
                        int a = int.Parse(Console.ReadLine());
                        Class1<int> obj = new Class1<int>();
                        obj.RemoveValue(a);
                        break;
                    }
            }
        }
    }
}

